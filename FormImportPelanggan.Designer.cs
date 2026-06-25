namespace EZTailor
{
    partial class FormImportPelanggan
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnPilihFile = new System.Windows.Forms.Button();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.idpelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tailorDBDataSet = new EZTailor.TailorDBDataSet();
            this.pelangganTableAdapter = new EZTailor.TailorDBDataSetTableAdapters.PelangganTableAdapter();
            this.btnImport = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDownloadTemplate = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.chkTimpaDuplikat = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailorDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(33, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(83, 75);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(386, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnPilihFile
            // 
            this.btnPilihFile.Location = new System.Drawing.Point(633, 355);
            this.btnPilihFile.Name = "btnPilihFile";
            this.btnPilihFile.Size = new System.Drawing.Size(138, 23);
            this.btnPilihFile.TabIndex = 2;
            this.btnPilihFile.Text = "Pilih File Excel";
            this.btnPilihFile.UseVisualStyleBackColor = true;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AutoGenerateColumns = false;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpelangganDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.nohpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dgvPreview.DataSource = this.pelangganBindingSource;
            this.dgvPreview.Location = new System.Drawing.Point(56, 273);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersWidth = 51;
            this.dgvPreview.RowTemplate.Height = 24;
            this.dgvPreview.Size = new System.Drawing.Size(547, 165);
            this.dgvPreview.TabIndex = 3;
            // 
            // idpelangganDataGridViewTextBoxColumn
            // 
            this.idpelangganDataGridViewTextBoxColumn.DataPropertyName = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.HeaderText = "id_pelanggan";
            this.idpelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpelangganDataGridViewTextBoxColumn.Name = "idpelangganDataGridViewTextBoxColumn";
            this.idpelangganDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nohpDataGridViewTextBoxColumn
            // 
            this.nohpDataGridViewTextBoxColumn.DataPropertyName = "no_hp";
            this.nohpDataGridViewTextBoxColumn.HeaderText = "no_hp";
            this.nohpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nohpDataGridViewTextBoxColumn.Name = "nohpDataGridViewTextBoxColumn";
            this.nohpDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.tailorDBDataSet;
            // 
            // tailorDBDataSet
            // 
            this.tailorDBDataSet.DataSetName = "TailorDBDataSet";
            this.tailorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(633, 273);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(138, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(83, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(386, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Location = new System.Drawing.Point(633, 313);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(138, 23);
            this.btnDownloadTemplate.TabIndex = 6;
            this.btnDownloadTemplate.Text = "Download Template";
            this.btnDownloadTemplate.UseVisualStyleBackColor = true;
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(633, 398);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(138, 23);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // chkTimpaDuplikat
            // 
            this.chkTimpaDuplikat.AutoSize = true;
            this.chkTimpaDuplikat.Location = new System.Drawing.Point(83, 116);
            this.chkTimpaDuplikat.Name = "chkTimpaDuplikat";
            this.chkTimpaDuplikat.Size = new System.Drawing.Size(125, 20);
            this.chkTimpaDuplikat.TabIndex = 8;
            this.chkTimpaDuplikat.Text = "Timpa Duplokat";
            this.chkTimpaDuplikat.UseVisualStyleBackColor = true;
            // 
            // FormImportPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkTimpaDuplikat);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnDownloadTemplate);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvPreview);
            this.Controls.Add(this.btnPilihFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblStatus);
            this.Name = "FormImportPelanggan";
            this.Text = "FormImportPelanggan";
            this.Load += new System.EventHandler(this.FormImportPelanggan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailorDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnPilihFile;
        private System.Windows.Forms.DataGridView dgvPreview;
        private TailorDBDataSet tailorDBDataSet;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private TailorDBDataSetTableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDownloadTemplate;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.CheckBox chkTimpaDuplikat;
    }
}