using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VormDB
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv24Prikaztsikov\VormDB\Tooded_DB.mdf;Integrated Security=True");
        
        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NäitaKategooriad();
            NaitaAndmed();
        }

        Form popupForm;

        private void Loopilt(Image image, int rowIndex)
        {
            popupForm = new Form();
            popupForm.FormBorderStyle = FormBorderStyle.None;
            popupForm.StartPosition = FormStartPosition.Manual;
            popupForm.Size = new Size(200, 200);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            popupForm.Controls.Add(pictureBox);

            var rect = dataGridView1.GetCellDisplayRectangle(4, rowIndex, true);
            var pos = dataGridView1.PointToScreen(rect.Location);

            pos.X -= rect.Width;

            popupForm.Location = pos;
            popupForm.Show();
        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toodetabel.Id,Toodetabel.Toodenimetus, Toodetabel.Kogus," +
                "Toodetabel.Hind, Toodetabel.Pilt,Toodetabel.Bpilt, Kategooriatabel.Kategooria_nimetus " +
                "as Kategooria_nimetus FROM Toodetabel INNER JOIN Kategooriatabel on Toodetabel.Kategooriad=Kategooriatabel.Id", connect);
             adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;
            DataGridViewComboBoxColumn combo_kat= new DataGridViewComboBoxColumn();
            combo_kat.DataPropertyName = "Kategooria_nimetus";
            HashSet<string> keys = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string kat_n = item["Kategooria_nimetus"].ToString();
                if(!keys.Contains(kat_n))
                {
                    keys.Add(kat_n);
                    combo_kat.Items.Add(kat_n);
                }
            }
            dataGridView1.Columns.Add(combo_kat);
            toode_pb.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Images"), "epood.png"));
            connect.Close();
        }

        public void NäitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooriatabel", connect);
            DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                if (!kat_box.Items.Contains(item["Kategooria_nimetus"]))
                {
                    kat_box.Items.Add(item["Kategooria_nimetus"]);
                }
                else
                {
                    command = new SqlCommand("DELETE FROM Kategooriatabel WHERE Id=@id", connect);
                    command.Parameters.AddWithValue("@id", item["Id"]);
                    command.ExecuteNonQuery();
                }
            }
            connect.Close();
        }

        private void kustuta_kat_btn_Click(object sender, EventArgs e)
        {
            if (kat_box.SelectedItem!=null)
            {
                connect.Open();
                string kat_val = kat_box.SelectedItem.ToString();
                command = new SqlCommand("DELETE FROM Kategooriatabel WHERE Kategooria_nimetus=@kat", connect);
                command.Parameters.AddWithValue("@kat", kat_val);
                command.ExecuteNonQuery();
                connect.Close();
                kat_box.Items.Clear();
                NäitaKategooriad();
            }
        }

        SaveFileDialog save;
        OpenFileDialog open;
        string extension = null;

        private void otsi_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\Pictures";
            open.Multiselect = true;
            open.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            FileInfo open_info = new FileInfo(@"C:\Users\opilane\source\repos\TARpv24Prikaztsikov\VormDB");
            if (open.ShowDialog() == DialogResult.OK && toode_txt.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                extension = Path.GetExtension(open.FileName);
                save.FileName = toode_txt.Text + Path.GetExtension(open.FileName);
                save.Filter="Images"+Path.GetExtension(open.FileName)+"|"+ Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK && toode_txt.Text != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    toode_pb.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või oli vajatud Cancel");
            }
        }

        byte[] imageData;

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 4)
            {
                imageData = dataGridView1.Rows[e.RowIndex].Cells["Bpilt"].Value as byte[];
                if (imageData !=null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        Loopilt(image, e.RowIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (popupForm !=null && !popupForm.IsDisposed)
            {
                popupForm.Close();
            }
        }

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (toode_txt.Text.Trim()!=string.Empty && kogus_txt.Text.Trim()!=string.Empty && hind_txt.Text.Trim()!=string.Empty && kat_box.SelectedItem!=null)
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("SELECT Id FROM Kategooriatabel WHERE Kategooria_nimetus=@kat", connect);
                    command.Parameters.AddWithValue("@kat", kat_box.Text);
                    command.ExecuteNonQuery();
                    var Id = Convert.ToInt32(command.ExecuteScalar());
                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus,Kogus,Hind,Pilt,Bpilt,Kategooriad) " +
                        " VALUES (@toode,@kogus,@hind,@pilt,@bpilt,@kat)", connect);
                    command.Parameters.AddWithValue("@toode", toode_txt.Text);
                    command.Parameters.AddWithValue("@kogus", kogus_txt.Text);
                    command.Parameters.AddWithValue("@hind", hind_txt.Text);
                    extension = Path.GetExtension(open.FileName);
                    command.Parameters.AddWithValue("@pilt", toode_txt.Text + extension);
                    imageData= File.ReadAllBytes(open.FileName);
                    command.Parameters.AddWithValue("@bpilt", imageData);
                    command.Parameters.AddWithValue("@kat", Id);
                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void puhasta_btn_Click(object sender, EventArgs e)
        {
            toode_txt.Text = "";
            kogus_txt.Text = "";
            hind_txt.Text = "";
            kat_box.SelectedItem = null;
            using(FileStream fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\Images"), "epood.png"), FileMode.Open, FileAccess.Read))
            {
                toode_pb.Image = Image.FromStream(fs);
            }

        }

        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            var Id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
            MessageBox.Show(Id.ToString());
            if (Id != 0)
            {
                command = new SqlCommand("DELETE Toodetabel WHERE Id=@Id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.ExecuteNonQuery();
                connect.Close();

                NaitaAndmed();

                MessageBox.Show("Andmed tabelist Tooded on kustutatud");
            }
            else
            {
                MessageBox.Show("Viga Tooded tabelist andmete kustutamisega");
            }
        }

        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (toode_txt.Text != "" && kogus_txt.Text != "" && hind_txt.Text != "" && toode_pb.Image != null)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Id"].Value);
                command = new SqlCommand("UPDATE Toodetabel SET Toodenimetus=@toode, Kogus=@kogus," +
                    "Hind=@hind, Pilt=@pilt WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@toode", toode_txt.Text);
                command.Parameters.AddWithValue("@kogus", kogus_txt.Text);
                command.Parameters.AddWithValue("@hind", hind_txt.Text.Replace(",", "."));
                string pilt = dataGridView1.SelectedCells[0].OwningRow.Cells["Pilt"].Value.ToString();
                string file_pilt = toode_txt.Text + extension;
                command.Parameters.AddWithValue("@pilt", file_pilt);
                command.ExecuteNonQuery();
                connect.Close();
                NaitaAndmed();
                MessageBox.Show("Andmed uuendatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lisa_kat_btn_Click(object sender, EventArgs e)
            {
                bool on = false;
                foreach (var item in kat_box.Items)
                {
                    if (item.ToString() == kat_box.Text)
                    {
                        on = true;
                    }
                }
                if (on == false)
                {
                    command = new SqlCommand("insert into Kategooriatabel (kategooria_nimetus) VALUES (@kat)", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@kat", kat_box.Text);
                    command.ExecuteNonQuery();
                    connect.Close();
                    kat_box.Items.Clear();
                    NäitaKategooriad();
                }
                else
                {
                    MessageBox.Show("Selline kategooriat on juba olemas!");
                }
            }
    }
}
