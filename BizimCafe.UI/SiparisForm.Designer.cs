namespace BizimCafe.UI
{
    partial class SiparisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.nmrUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dGridSiparisGoster = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxMasaNo = new System.Windows.Forms.ComboBox();
            this.btnMasaTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.btnSiparisIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnaSayfaDon = new System.Windows.Forms.Button();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiparisGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUrun
            // 
            this.cbxUrun.BackColor = System.Drawing.Color.Silver;
            this.cbxUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Location = new System.Drawing.Point(36, 46);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(202, 23);
            this.cbxUrun.TabIndex = 0;
            // 
            // nmrUrunAdet
            // 
            this.nmrUrunAdet.BackColor = System.Drawing.Color.White;
            this.nmrUrunAdet.Location = new System.Drawing.Point(244, 46);
            this.nmrUrunAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUrunAdet.Name = "nmrUrunAdet";
            this.nmrUrunAdet.Size = new System.Drawing.Size(120, 23);
            this.nmrUrunAdet.TabIndex = 1;
            this.nmrUrunAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.DarkGray;
            this.btnUrunEkle.Location = new System.Drawing.Point(372, 30);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(136, 48);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dGridSiparisGoster
            // 
            this.dGridSiparisGoster.AllowUserToAddRows = false;
            this.dGridSiparisGoster.AllowUserToDeleteRows = false;
            this.dGridSiparisGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridSiparisGoster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGridSiparisGoster.Location = new System.Drawing.Point(36, 86);
            this.dGridSiparisGoster.Name = "dGridSiparisGoster";
            this.dGridSiparisGoster.ReadOnly = true;
            this.dGridSiparisGoster.RowTemplate.Height = 25;
            this.dGridSiparisGoster.Size = new System.Drawing.Size(480, 376);
            this.dGridSiparisGoster.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAd";
            this.Column1.HeaderText = "Ürün";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle1.Format = "C2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Birim Fiyatı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Adet";
            this.Column3.HeaderText = "Adet";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TutarTL";
            this.Column4.HeaderText = "Tutar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbxMasaNo
            // 
            this.cbxMasaNo.BackColor = System.Drawing.Color.Silver;
            this.cbxMasaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMasaNo.FormattingEnabled = true;
            this.cbxMasaNo.Location = new System.Drawing.Point(620, 46);
            this.cbxMasaNo.Name = "cbxMasaNo";
            this.cbxMasaNo.Size = new System.Drawing.Size(120, 23);
            this.cbxMasaNo.TabIndex = 4;
            // 
            // btnMasaTasi
            // 
            this.btnMasaTasi.BackColor = System.Drawing.Color.DarkGray;
            this.btnMasaTasi.Location = new System.Drawing.Point(748, 38);
            this.btnMasaTasi.Name = "btnMasaTasi";
            this.btnMasaTasi.Size = new System.Drawing.Size(72, 40);
            this.btnMasaTasi.TabIndex = 5;
            this.btnMasaTasi.Text = "TAŞI";
            this.btnMasaTasi.UseVisualStyleBackColor = false;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMasaNo.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.ForeColor = System.Drawing.Color.White;
            this.lblMasaNo.Location = new System.Drawing.Point(532, 86);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(288, 184);
            this.lblMasaNo.TabIndex = 6;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.BackColor = System.Drawing.Color.Red;
            this.btnSiparisIptal.ForeColor = System.Drawing.Color.White;
            this.btnSiparisIptal.Location = new System.Drawing.Point(532, 334);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(128, 64);
            this.btnSiparisIptal.TabIndex = 7;
            this.btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            this.btnSiparisIptal.UseVisualStyleBackColor = false;
            this.btnSiparisIptal.Click += new System.EventHandler(this.btnSiparisIptal_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.Green;
            this.btnOdemeAl.ForeColor = System.Drawing.Color.White;
            this.btnOdemeAl.Location = new System.Drawing.Point(692, 334);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(128, 64);
            this.btnOdemeAl.TabIndex = 8;
            this.btnOdemeAl.Text = "ÖDEME AL";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnAnaSayfaDon
            // 
            this.btnAnaSayfaDon.BackColor = System.Drawing.Color.Yellow;
            this.btnAnaSayfaDon.ForeColor = System.Drawing.Color.Black;
            this.btnAnaSayfaDon.Location = new System.Drawing.Point(532, 406);
            this.btnAnaSayfaDon.Name = "btnAnaSayfaDon";
            this.btnAnaSayfaDon.Size = new System.Drawing.Size(288, 48);
            this.btnAnaSayfaDon.TabIndex = 9;
            this.btnAnaSayfaDon.Text = "ANASAYFAYA DÖN";
            this.btnAnaSayfaDon.UseVisualStyleBackColor = false;
            this.btnAnaSayfaDon.Click += new System.EventHandler(this.btnAnaSayfaDon_Click);
            // 
            // lblOdeme
            // 
            this.lblOdeme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOdeme.Location = new System.Drawing.Point(596, 302);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(120, 24);
            this.lblOdeme.TabIndex = 10;
            this.lblOdeme.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOdemeTutari.Location = new System.Drawing.Point(724, 302);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(72, 24);
            this.lblOdemeTutari.TabIndex = 11;
            this.lblOdemeTutari.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(244, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(620, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Masa No";
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.lblOdeme);
            this.Controls.Add(this.btnAnaSayfaDon);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnSiparisIptal);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnMasaTasi);
            this.Controls.Add(this.cbxMasaNo);
            this.Controls.Add(this.dGridSiparisGoster);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.nmrUrunAdet);
            this.Controls.Add(this.cbxUrun);
            this.Name = "SiparisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiparisGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxUrun;
        private NumericUpDown nmrUrunAdet;
        private Button btnUrunEkle;
        private DataGridView dGridSiparisGoster;
        private ComboBox cbxMasaNo;
        private Button btnMasaTasi;
        private Label lblMasaNo;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnaSayfaDon;
        private Label lblOdeme;
        private Label lblOdemeTutari;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}