namespace Satis_Takip
{
    partial class frmSatisListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisListesi));
            this.dataGridViewsatislistesi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatislistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewsatislistesi
            // 
            this.dataGridViewsatislistesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewsatislistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsatislistesi.Location = new System.Drawing.Point(147, 76);
            this.dataGridViewsatislistesi.Name = "dataGridViewsatislistesi";
            this.dataGridViewsatislistesi.RowHeadersWidth = 51;
            this.dataGridViewsatislistesi.RowTemplate.Height = 24;
            this.dataGridViewsatislistesi.Size = new System.Drawing.Size(840, 491);
            this.dataGridViewsatislistesi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 70);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yapılan Satışları Tarih Ve Tutara Göre Listeleyen Listedir.";
            // 
            // frmSatisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1078, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewsatislistesi);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatisListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listesi";
            this.Load += new System.EventHandler(this.frmSatisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatislistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewsatislistesi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}