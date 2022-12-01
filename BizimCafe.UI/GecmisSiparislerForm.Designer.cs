namespace BizimCafe.UI
{
    partial class GecmisSiparislerForm
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
            this.sContainerGSiparis = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.dGridSiparisler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dGridSiparisDetaylari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sContainerGSiparis)).BeginInit();
            this.sContainerGSiparis.Panel1.SuspendLayout();
            this.sContainerGSiparis.Panel2.SuspendLayout();
            this.sContainerGSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // sContainerGSiparis
            // 
            this.sContainerGSiparis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainerGSiparis.Location = new System.Drawing.Point(0, 0);
            this.sContainerGSiparis.Name = "sContainerGSiparis";
            this.sContainerGSiparis.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sContainerGSiparis.Panel1
            // 
            this.sContainerGSiparis.Panel1.Controls.Add(this.label2);
            this.sContainerGSiparis.Panel1.Controls.Add(this.dGridSiparisler);
            // 
            // sContainerGSiparis.Panel2
            // 
            this.sContainerGSiparis.Panel2.Controls.Add(this.label1);
            this.sContainerGSiparis.Panel2.Controls.Add(this.dGridSiparisDetaylari);
            this.sContainerGSiparis.Size = new System.Drawing.Size(800, 460);
            this.sContainerGSiparis.SplitterDistance = 211;
            this.sContainerGSiparis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Siparişler";
            // 
            // dGridSiparisler
            // 
            this.dGridSiparisler.AllowUserToAddRows = false;
            this.dGridSiparisler.AllowUserToDeleteRows = false;
            this.dGridSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridSiparisler.Location = new System.Drawing.Point(3, 37);
            this.dGridSiparisler.MultiSelect = false;
            this.dGridSiparisler.Name = "dGridSiparisler";
            this.dGridSiparisler.ReadOnly = true;
            this.dGridSiparisler.RowTemplate.Height = 25;
            this.dGridSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridSiparisler.Size = new System.Drawing.Size(797, 170);
            this.dGridSiparisler.TabIndex = 0;
            this.dGridSiparisler.SelectionChanged += new System.EventHandler(this.dGridSiparisler_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sipariş Detayları";
            // 
            // dGridSiparisDetaylari
            // 
            this.dGridSiparisDetaylari.AllowUserToAddRows = false;
            this.dGridSiparisDetaylari.AllowUserToDeleteRows = false;
            this.dGridSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridSiparisDetaylari.Location = new System.Drawing.Point(3, 49);
            this.dGridSiparisDetaylari.MultiSelect = false;
            this.dGridSiparisDetaylari.Name = "dGridSiparisDetaylari";
            this.dGridSiparisDetaylari.ReadOnly = true;
            this.dGridSiparisDetaylari.RowTemplate.Height = 25;
            this.dGridSiparisDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridSiparisDetaylari.Size = new System.Drawing.Size(794, 192);
            this.dGridSiparisDetaylari.TabIndex = 0;
            // 
            // GecmisSiparislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.sContainerGSiparis);
            this.Name = "GecmisSiparislerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GecmisSiparislerForm";
            this.sContainerGSiparis.Panel1.ResumeLayout(false);
            this.sContainerGSiparis.Panel1.PerformLayout();
            this.sContainerGSiparis.Panel2.ResumeLayout(false);
            this.sContainerGSiparis.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainerGSiparis)).EndInit();
            this.sContainerGSiparis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer sContainerGSiparis;
        private Label label2;
        private DataGridView dGridSiparisler;
        private Label label1;
        private DataGridView dGridSiparisDetaylari;
    }
}