namespace EZTailor
{
    partial class FormPesanan
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
            this.cbPelanggan = new System.Windows.Forms.ComboBox();
            this.lblPelanggan = new System.Windows.Forms.Label();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPelanggan
            // 
            this.cbPelanggan.FormattingEnabled = true;
            this.cbPelanggan.Location = new System.Drawing.Point(122, 32);
            this.cbPelanggan.Name = "cbPelanggan";
            this.cbPelanggan.Size = new System.Drawing.Size(165, 24);
            this.cbPelanggan.TabIndex = 0;
            this.cbPelanggan.SelectedIndexChanged += new System.EventHandler(this.cbPelanggan_SelectedIndexChanged);
            // 
            // lblPelanggan
            // 
            this.lblPelanggan.AutoSize = true;
            this.lblPelanggan.Location = new System.Drawing.Point(22, 40);
            this.lblPelanggan.Name = "lblPelanggan";
            this.lblPelanggan.Size = new System.Drawing.Size(72, 16);
            this.lblPelanggan.TabIndex = 1;
            this.lblPelanggan.Text = "pelanggan";
            this.lblPelanggan.Click += new System.EventHandler(this.lblPelanggan_Click);
            // 
            // txtJenis
            // 
            this.txtJenis.Location = new System.Drawing.Point(122, 84);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.Size = new System.Drawing.Size(165, 22);
            this.txtJenis.TabIndex = 2;
            this.txtJenis.TextChanged += new System.EventHandler(this.txtJenis_TextChanged);
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(12, 91);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(92, 16);
            this.lblJenis.TabIndex = 3;
            this.lblJenis.Text = "Jenis Pakaian";
            this.lblJenis.Click += new System.EventHandler(this.lblJenis_Click);
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(122, 128);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(218, 22);
            this.dtTanggal.TabIndex = 4;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(12, 133);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(100, 16);
            this.lblTanggal.TabIndex = 5;
            this.lblTanggal.Text = "Tanggal Pesan";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(122, 176);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(218, 22);
            this.txtHarga.TabIndex = 6;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(34, 179);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(45, 16);
            this.lblHarga.TabIndex = 7;
            this.lblHarga.Text = "Harga";
            this.lblHarga.Click += new System.EventHandler(this.lblHarga_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 177);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(478, 32);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(478, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(478, 133);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // FormPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.txtJenis);
            this.Controls.Add(this.lblPelanggan);
            this.Controls.Add(this.cbPelanggan);
            this.Name = "FormPesanan";
            this.Text = "FormPesanan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPelanggan;
        private System.Windows.Forms.Label lblPelanggan;
        private System.Windows.Forms.TextBox txtJenis;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
    }
}