namespace VormDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label kategooriad;
            this.lisa_kat_btn = new System.Windows.Forms.Button();
            this.kustuta_kat_btn = new System.Windows.Forms.Button();
            this.toode = new System.Windows.Forms.Label();
            this.kogus = new System.Windows.Forms.Label();
            this.hind = new System.Windows.Forms.Label();
            this.hind_txt = new System.Windows.Forms.TextBox();
            this.kogus_txt = new System.Windows.Forms.TextBox();
            this.toode_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toode_pb = new System.Windows.Forms.PictureBox();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.uuenda_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.puhasta_btn = new System.Windows.Forms.Button();
            this.otsi_btn = new System.Windows.Forms.Button();
            this.kat_box = new System.Windows.Forms.ComboBox();
            this.kliendi_kat_box = new System.Windows.Forms.ComboBox();
            this.kliendi_tooted_grid = new System.Windows.Forms.DataGridView();
            this.kliendi_toode_pilt_pb = new System.Windows.Forms.PictureBox();
            this.nimi = new System.Windows.Forms.Label();
            this.hind2 = new System.Windows.Forms.Label();
            this.kogus2 = new System.Windows.Forms.Label();
            this.otsingu_txt = new System.Windows.Forms.TextBox();
            this.otsingu_ikoon_pb = new System.Windows.Forms.PictureBox();
            kategooriad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kliendi_tooted_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kliendi_toode_pilt_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otsingu_ikoon_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // kategooriad
            // 
            kategooriad.AutoSize = true;
            kategooriad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            kategooriad.Location = new System.Drawing.Point(4, 172);
            kategooriad.Name = "kategooriad";
            kategooriad.Size = new System.Drawing.Size(118, 25);
            kategooriad.TabIndex = 5;
            kategooriad.Text = "Kategooriad";
            // 
            // lisa_kat_btn
            // 
            this.lisa_kat_btn.Location = new System.Drawing.Point(75, 209);
            this.lisa_kat_btn.Name = "lisa_kat_btn";
            this.lisa_kat_btn.Size = new System.Drawing.Size(113, 23);
            this.lisa_kat_btn.TabIndex = 0;
            this.lisa_kat_btn.Text = "Lisa kategooriat";
            this.lisa_kat_btn.UseVisualStyleBackColor = true;
            this.lisa_kat_btn.Click += new System.EventHandler(this.lisa_kat_btn_Click);
            // 
            // kustuta_kat_btn
            // 
            this.kustuta_kat_btn.Location = new System.Drawing.Point(194, 209);
            this.kustuta_kat_btn.Name = "kustuta_kat_btn";
            this.kustuta_kat_btn.Size = new System.Drawing.Size(117, 23);
            this.kustuta_kat_btn.TabIndex = 1;
            this.kustuta_kat_btn.Text = "Kustuta kategooriat";
            this.kustuta_kat_btn.UseVisualStyleBackColor = true;
            this.kustuta_kat_btn.Click += new System.EventHandler(this.kustuta_kat_btn_Click);
            // 
            // toode
            // 
            this.toode.AutoSize = true;
            this.toode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.toode.Location = new System.Drawing.Point(60, 33);
            this.toode.Name = "toode";
            this.toode.Size = new System.Drawing.Size(69, 25);
            this.toode.TabIndex = 2;
            this.toode.Text = "Toode";
            // 
            // kogus
            // 
            this.kogus.AutoSize = true;
            this.kogus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.kogus.Location = new System.Drawing.Point(60, 75);
            this.kogus.Name = "kogus";
            this.kogus.Size = new System.Drawing.Size(69, 25);
            this.kogus.TabIndex = 3;
            this.kogus.Text = "Kogus";
            // 
            // hind
            // 
            this.hind.AutoSize = true;
            this.hind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.hind.Location = new System.Drawing.Point(70, 121);
            this.hind.Name = "hind";
            this.hind.Size = new System.Drawing.Size(52, 25);
            this.hind.TabIndex = 4;
            this.hind.Text = "Hind";
            // 
            // hind_txt
            // 
            this.hind_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hind_txt.Location = new System.Drawing.Point(135, 122);
            this.hind_txt.Name = "hind_txt";
            this.hind_txt.Size = new System.Drawing.Size(114, 26);
            this.hind_txt.TabIndex = 10;
            // 
            // kogus_txt
            // 
            this.kogus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kogus_txt.Location = new System.Drawing.Point(135, 74);
            this.kogus_txt.Name = "kogus_txt";
            this.kogus_txt.Size = new System.Drawing.Size(114, 26);
            this.kogus_txt.TabIndex = 11;
            // 
            // toode_txt
            // 
            this.toode_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toode_txt.Location = new System.Drawing.Point(135, 32);
            this.toode_txt.Name = "toode_txt";
            this.toode_txt.Size = new System.Drawing.Size(114, 26);
            this.toode_txt.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 184);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // toode_pb
            // 
            this.toode_pb.Location = new System.Drawing.Point(429, 12);
            this.toode_pb.Name = "toode_pb";
            this.toode_pb.Size = new System.Drawing.Size(316, 188);
            this.toode_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toode_pb.TabIndex = 14;
            this.toode_pb.TabStop = false;
            // 
            // lisa_btn
            // 
            this.lisa_btn.Location = new System.Drawing.Point(75, 238);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(75, 23);
            this.lisa_btn.TabIndex = 15;
            this.lisa_btn.Text = "Lisa";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // uuenda_btn
            // 
            this.uuenda_btn.Location = new System.Drawing.Point(156, 238);
            this.uuenda_btn.Name = "uuenda_btn";
            this.uuenda_btn.Size = new System.Drawing.Size(75, 23);
            this.uuenda_btn.TabIndex = 16;
            this.uuenda_btn.Text = "Uuenda";
            this.uuenda_btn.UseVisualStyleBackColor = true;
            this.uuenda_btn.Click += new System.EventHandler(this.uuenda_btn_Click);
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Location = new System.Drawing.Point(237, 238);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(75, 23);
            this.kustuta_btn.TabIndex = 17;
            this.kustuta_btn.Text = "Kustuta";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            this.kustuta_btn.Click += new System.EventHandler(this.kustuta_btn_Click);
            // 
            // puhasta_btn
            // 
            this.puhasta_btn.Location = new System.Drawing.Point(318, 238);
            this.puhasta_btn.Name = "puhasta_btn";
            this.puhasta_btn.Size = new System.Drawing.Size(75, 23);
            this.puhasta_btn.TabIndex = 18;
            this.puhasta_btn.Text = "Puhasta";
            this.puhasta_btn.UseVisualStyleBackColor = true;
            this.puhasta_btn.Click += new System.EventHandler(this.puhasta_btn_Click);
            // 
            // otsi_btn
            // 
            this.otsi_btn.Location = new System.Drawing.Point(318, 209);
            this.otsi_btn.Name = "otsi_btn";
            this.otsi_btn.Size = new System.Drawing.Size(75, 23);
            this.otsi_btn.TabIndex = 19;
            this.otsi_btn.Text = "Otsi fail";
            this.otsi_btn.UseVisualStyleBackColor = true;
            this.otsi_btn.Click += new System.EventHandler(this.otsi_btn_Click);
            // 
            // kat_box
            // 
            this.kat_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kat_box.FormattingEnabled = true;
            this.kat_box.ItemHeight = 16;
            this.kat_box.Location = new System.Drawing.Point(135, 172);
            this.kat_box.Name = "kat_box";
            this.kat_box.Size = new System.Drawing.Size(114, 24);
            this.kat_box.TabIndex = 20;
            // 
            // kliendi_kat_box
            // 
            this.kliendi_kat_box.FormattingEnabled = true;
            this.kliendi_kat_box.Location = new System.Drawing.Point(920, 12);
            this.kliendi_kat_box.Name = "kliendi_kat_box";
            this.kliendi_kat_box.Size = new System.Drawing.Size(188, 21);
            this.kliendi_kat_box.TabIndex = 21;
            this.kliendi_kat_box.SelectedIndexChanged += new System.EventHandler(this.kliendi_kat_box_SelectedIndexChanged);
            // 
            // kliendi_tooted_grid
            // 
            this.kliendi_tooted_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kliendi_tooted_grid.Location = new System.Drawing.Point(833, 46);
            this.kliendi_tooted_grid.Name = "kliendi_tooted_grid";
            this.kliendi_tooted_grid.Size = new System.Drawing.Size(240, 150);
            this.kliendi_tooted_grid.TabIndex = 22;
            this.kliendi_tooted_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kliendi_tooted_grid_CellClick);
            // 
            // kliendi_toode_pilt_pb
            // 
            this.kliendi_toode_pilt_pb.Location = new System.Drawing.Point(854, 209);
            this.kliendi_toode_pilt_pb.Name = "kliendi_toode_pilt_pb";
            this.kliendi_toode_pilt_pb.Size = new System.Drawing.Size(199, 139);
            this.kliendi_toode_pilt_pb.TabIndex = 23;
            this.kliendi_toode_pilt_pb.TabStop = false;
            // 
            // nimi
            // 
            this.nimi.AutoSize = true;
            this.nimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nimi.Location = new System.Drawing.Point(851, 351);
            this.nimi.Name = "nimi";
            this.nimi.Size = new System.Drawing.Size(48, 24);
            this.nimi.TabIndex = 24;
            this.nimi.Text = "Nimi";
            // 
            // hind2
            // 
            this.hind2.AutoSize = true;
            this.hind2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hind2.Location = new System.Drawing.Point(851, 377);
            this.hind2.Name = "hind2";
            this.hind2.Size = new System.Drawing.Size(50, 24);
            this.hind2.TabIndex = 25;
            this.hind2.Text = "Hind";
            // 
            // kogus2
            // 
            this.kogus2.AutoSize = true;
            this.kogus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.kogus2.Location = new System.Drawing.Point(851, 403);
            this.kogus2.Name = "kogus2";
            this.kogus2.Size = new System.Drawing.Size(64, 24);
            this.kogus2.TabIndex = 26;
            this.kogus2.Text = "Kogus";
            // 
            // otsingu_txt
            // 
            this.otsingu_txt.Location = new System.Drawing.Point(779, 13);
            this.otsingu_txt.Name = "otsingu_txt";
            this.otsingu_txt.Size = new System.Drawing.Size(122, 20);
            this.otsingu_txt.TabIndex = 27;
            this.otsingu_txt.TextChanged += new System.EventHandler(this.otsingu_txt_TextChanged);
            // 
            // otsingu_ikoon_pb
            // 
            this.otsingu_ikoon_pb.Location = new System.Drawing.Point(751, 13);
            this.otsingu_ikoon_pb.Name = "otsingu_ikoon_pb";
            this.otsingu_ikoon_pb.Size = new System.Drawing.Size(25, 25);
            this.otsingu_ikoon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otsingu_ikoon_pb.TabIndex = 28;
            this.otsingu_ikoon_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.otsingu_ikoon_pb);
            this.Controls.Add(this.otsingu_txt);
            this.Controls.Add(this.kogus2);
            this.Controls.Add(this.hind2);
            this.Controls.Add(this.nimi);
            this.Controls.Add(this.kliendi_toode_pilt_pb);
            this.Controls.Add(this.kliendi_tooted_grid);
            this.Controls.Add(this.kliendi_kat_box);
            this.Controls.Add(this.kat_box);
            this.Controls.Add(this.otsi_btn);
            this.Controls.Add(this.puhasta_btn);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.uuenda_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.toode_pb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toode_txt);
            this.Controls.Add(this.kogus_txt);
            this.Controls.Add(this.hind_txt);
            this.Controls.Add(kategooriad);
            this.Controls.Add(this.hind);
            this.Controls.Add(this.kogus);
            this.Controls.Add(this.toode);
            this.Controls.Add(this.kustuta_kat_btn);
            this.Controls.Add(this.lisa_kat_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kliendi_tooted_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kliendi_toode_pilt_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otsingu_ikoon_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lisa_kat_btn;
        private System.Windows.Forms.Button kustuta_kat_btn;
        private System.Windows.Forms.Label toode;
        private System.Windows.Forms.Label kogus;
        private System.Windows.Forms.Label hind;
        private System.Windows.Forms.TextBox hind_txt;
        private System.Windows.Forms.TextBox kogus_txt;
        private System.Windows.Forms.TextBox toode_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox toode_pb;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.Button uuenda_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.Button puhasta_btn;
        private System.Windows.Forms.Button otsi_btn;
        private System.Windows.Forms.ComboBox kat_box;
        private System.Windows.Forms.ComboBox kliendi_kat_box;
        private System.Windows.Forms.DataGridView kliendi_tooted_grid;
        private System.Windows.Forms.PictureBox kliendi_toode_pilt_pb;
        private System.Windows.Forms.Label nimi;
        private System.Windows.Forms.Label hind2;
        private System.Windows.Forms.Label kogus2;
        private System.Windows.Forms.TextBox otsingu_txt;
        private System.Windows.Forms.PictureBox otsingu_ikoon_pb;
    }
}

