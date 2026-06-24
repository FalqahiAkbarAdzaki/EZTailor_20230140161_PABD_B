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
            this.lblJenisPakaian = new System.Windows.Forms.Label();
            this.clbJenisPakaian = new System.Windows.Forms.CheckedListBox();
            this.cbPelanggan = new System.Windows.Forms.ComboBox();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPelanggan = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJenisPakaian
            // 
            this.lblJenisPakaian.AutoSize = true;
            this.lblJenisPakaian.Location = new System.Drawing.Point(27, 171);
            this.lblJenisPakaian.Name = "lblJenisPakaian";
            this.lblJenisPakaian.Size = new System.Drawing.Size(95, 16);
            this.lblJenisPakaian.TabIndex = 0;
            this.lblJenisPakaian.Text = "Jenis Pakaian:";
            // 
            // clbJenisPakaian
            // 
            this.clbJenisPakaian.CheckOnClick = true;
            this.clbJenisPakaian.FormattingEnabled = true;
            this.clbJenisPakaian.Items.AddRange(new object[] {
            "Jas",
            "Kemeja",
            "Dress",
            "Vest",
            "Celana",
            "Vest",
            "Topi",
            "Jaket"});
            this.clbJenisPakaian.Location = new System.Drawing.Point(170, 171);
            this.clbJenisPakaian.Name = "clbJenisPakaian";
            this.clbJenisPakaian.Size = new System.Drawing.Size(208, 89);
            this.clbJenisPakaian.TabIndex = 1;
            // 
            // cbPelanggan
            // 
            this.cbPelanggan.FormattingEnabled = true;
            this.cbPelanggan.Location = new System.Drawing.Point(170, 49);
            this.cbPelanggan.Name = "cbPelanggan";
            this.cbPelanggan.Size = new System.Drawing.Size(214, 24);
            this.cbPelanggan.TabIndex = 2;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(585, 76);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(129, 23);
            this.btnImportExcel.TabIndex = 3;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // lblPelanggan
            // 
            this.lblPelanggan.AutoSize = true;
            this.lblPelanggan.Location = new System.Drawing.Point(27, 52);
            this.lblPelanggan.Name = "lblPelanggan";
            this.lblPelanggan.Size = new System.Drawing.Size(76, 16);
            this.lblPelanggan.TabIndex = 5;
            this.lblPelanggan.Text = "Pelanggan:";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(585, 117);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(123, 26);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(170, 89);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(214, 22);
            this.txtHarga.TabIndex = 7;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(27, 92);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(48, 16);
            this.lblHarga.TabIndex = 8;
            this.lblHarga.Text = "Harga:";
            this.lblHarga.Click += new System.EventHandler(this.lblHarga_Click);
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(170, 131);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(200, 22);
            this.dtTanggal.TabIndex = 9;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(27, 136);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(137, 16);
            this.lblTanggal.TabIndex = 10;
            this.lblTanggal.Text = "Tanggal Pemesanan:";
            // 
            // FormPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.lblPelanggan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.cbPelanggan);
            this.Controls.Add(this.clbJenisPakaian);
            this.Controls.Add(this.lblJenisPakaian);
            this.Name = "FormPesanan";
            this.Text = "FormPesanan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJenisPakaian;
        private System.Windows.Forms.CheckedListBox clbJenisPakaian;
        private System.Windows.Forms.ComboBox cbPelanggan;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPelanggan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Label lblTanggal;
    }
}