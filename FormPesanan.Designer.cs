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
            this.components = new System.ComponentModel.Container();
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.tailorDBDataSet1 = new EZTailor.TailorDBDataSet1();
            this.pesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesananTableAdapter = new EZTailor.TailorDBDataSet1TableAdapters.PesananTableAdapter();
            this.idpesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenispakaianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalpesanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorpesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailorDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).BeginInit();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpesananDataGridViewTextBoxColumn,
            this.idpelangganDataGridViewTextBoxColumn,
            this.jenispakaianDataGridViewTextBoxColumn,
            this.tanggalpesanDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.nomorpesananDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pesananBindingSource;
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
            this.btnHapus.Size = new System.Drawing.Size(129, 26);
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
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(585, 36);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(129, 23);
            this.btnTambah.TabIndex = 11;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(585, 164);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Ubah";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(585, 208);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(129, 23);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tailorDBDataSet1
            // 
            this.tailorDBDataSet1.DataSetName = "TailorDBDataSet1";
            this.tailorDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesananBindingSource
            // 
            this.pesananBindingSource.DataMember = "Pesanan";
            this.pesananBindingSource.DataSource = this.tailorDBDataSet1;
            // 
            // pesananTableAdapter
            // 
            this.pesananTableAdapter.ClearBeforeFill = true;
            // 
            // idpesananDataGridViewTextBoxColumn
            // 
            this.idpesananDataGridViewTextBoxColumn.DataPropertyName = "id_pesanan";
            this.idpesananDataGridViewTextBoxColumn.HeaderText = "id_pesanan";
            this.idpesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpesananDataGridViewTextBoxColumn.Name = "idpesananDataGridViewTextBoxColumn";
            this.idpesananDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpelangganDataGridViewTextBoxColumn
            // 
            this.idpelangganDataGridViewTextBoxColumn.DataPropertyName = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.HeaderText = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpelangganDataGridViewTextBoxColumn.Name = "idpelangganDataGridViewTextBoxColumn";
            this.idpelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenispakaianDataGridViewTextBoxColumn
            // 
            this.jenispakaianDataGridViewTextBoxColumn.DataPropertyName = "jenis_pakaian";
            this.jenispakaianDataGridViewTextBoxColumn.HeaderText = "jenis_pakaian";
            this.jenispakaianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenispakaianDataGridViewTextBoxColumn.Name = "jenispakaianDataGridViewTextBoxColumn";
            this.jenispakaianDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalpesanDataGridViewTextBoxColumn
            // 
            this.tanggalpesanDataGridViewTextBoxColumn.DataPropertyName = "tanggal_pesan";
            this.tanggalpesanDataGridViewTextBoxColumn.HeaderText = "tanggal_pesan";
            this.tanggalpesanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalpesanDataGridViewTextBoxColumn.Name = "tanggalpesanDataGridViewTextBoxColumn";
            this.tanggalpesanDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomorpesananDataGridViewTextBoxColumn
            // 
            this.nomorpesananDataGridViewTextBoxColumn.DataPropertyName = "nomor_pesanan";
            this.nomorpesananDataGridViewTextBoxColumn.HeaderText = "nomor_pesanan";
            this.nomorpesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomorpesananDataGridViewTextBoxColumn.Name = "nomorpesananDataGridViewTextBoxColumn";
            this.nomorpesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
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
            this.Load += new System.EventHandler(this.FormPesanan_Load_1);
            this.Click += new System.EventHandler(this.FormPesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailorDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReport;
        private TailorDBDataSet1 tailorDBDataSet1;
        private System.Windows.Forms.BindingSource pesananBindingSource;
        private TailorDBDataSet1TableAdapters.PesananTableAdapter pesananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenispakaianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalpesanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorpesananDataGridViewTextBoxColumn;
    }
}