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
            this.SuspendLayout();
            // 
            // FormPesanan
            // 
            this.ClientSize = new System.Drawing.Size(832, 408);
            this.Name = "FormPesanan";
            this.ResumeLayout(false);

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