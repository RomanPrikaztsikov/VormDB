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
        }

        public void NäitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooriadtabel", connect);
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
                    command = new SqlCommand("DELETE FROM Kategooriadtabel WHERE Id=@id", connect);
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
                command = new SqlCommand("DELETE FROM kategooriadtabel WHERE Kategooria_nimetus=@kat", connect);
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
                        command = new SqlCommand("insert into Kategooriadtabel (kategooria_nimetus) VALUES (@kat)", connect);
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
