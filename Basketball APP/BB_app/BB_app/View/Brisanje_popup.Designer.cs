namespace BB_app.View
{
    partial class Brisanje_popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brisanje_popup));
            this.cmbBrisanjeOdabir = new MetroFramework.Controls.MetroComboBox();
            this.dgvBrisanje = new System.Windows.Forms.DataGridView();
            this.btnBrisanjeIzadi = new MetroFramework.Controls.MetroButton();
            this.btnBrisanjeBrisi = new MetroFramework.Controls.MetroButton();
            this.lblBrisanjeResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrisanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBrisanjeOdabir
            // 
            this.cmbBrisanjeOdabir.FormattingEnabled = true;
            this.cmbBrisanjeOdabir.ItemHeight = 24;
            this.cmbBrisanjeOdabir.Items.AddRange(new object[] {
            "EKIPA",
            "IGRAČI",
            "PRISUTNOST",
            "TRENING",
            "STATISTIKA",
            "ZAPISNIK",
            "VJEŽBE",
            "ŠUTEVI"});
            this.cmbBrisanjeOdabir.Location = new System.Drawing.Point(37, 85);
            this.cmbBrisanjeOdabir.Name = "cmbBrisanjeOdabir";
            this.cmbBrisanjeOdabir.Size = new System.Drawing.Size(225, 30);
            this.cmbBrisanjeOdabir.TabIndex = 0;
            this.cmbBrisanjeOdabir.UseSelectable = true;
            this.cmbBrisanjeOdabir.SelectedIndexChanged += new System.EventHandler(this.cmbBrisanjeOdabir_SelectedIndexChanged);
            // 
            // dgvBrisanje
            // 
            this.dgvBrisanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrisanje.Location = new System.Drawing.Point(351, 74);
            this.dgvBrisanje.Name = "dgvBrisanje";
            this.dgvBrisanje.RowTemplate.Height = 24;
            this.dgvBrisanje.Size = new System.Drawing.Size(1153, 585);
            this.dgvBrisanje.TabIndex = 1;
            this.dgvBrisanje.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrisanje_CellClick);
            // 
            // btnBrisanjeIzadi
            // 
            this.btnBrisanjeIzadi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrisanjeIzadi.Location = new System.Drawing.Point(37, 565);
            this.btnBrisanjeIzadi.Name = "btnBrisanjeIzadi";
            this.btnBrisanjeIzadi.Size = new System.Drawing.Size(110, 90);
            this.btnBrisanjeIzadi.TabIndex = 2;
            this.btnBrisanjeIzadi.Text = "Izađi";
            this.btnBrisanjeIzadi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrisanjeIzadi.UseSelectable = true;
            this.btnBrisanjeIzadi.Click += new System.EventHandler(this.btnBrisanjeIzadi_Click);
            // 
            // btnBrisanjeBrisi
            // 
            this.btnBrisanjeBrisi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrisanjeBrisi.Location = new System.Drawing.Point(153, 565);
            this.btnBrisanjeBrisi.Name = "btnBrisanjeBrisi";
            this.btnBrisanjeBrisi.Size = new System.Drawing.Size(110, 90);
            this.btnBrisanjeBrisi.TabIndex = 3;
            this.btnBrisanjeBrisi.Text = "Izbriši";
            this.btnBrisanjeBrisi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBrisanjeBrisi.UseSelectable = true;
            this.btnBrisanjeBrisi.Click += new System.EventHandler(this.btnBrisanjeBrisi_Click);
            // 
            // lblBrisanjeResult
            // 
            this.lblBrisanjeResult.AutoSize = true;
            this.lblBrisanjeResult.BackColor = System.Drawing.Color.Transparent;
            this.lblBrisanjeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrisanjeResult.ForeColor = System.Drawing.Color.LightGreen;
            this.lblBrisanjeResult.Location = new System.Drawing.Point(988, 27);
            this.lblBrisanjeResult.Name = "lblBrisanjeResult";
            this.lblBrisanjeResult.Size = new System.Drawing.Size(64, 25);
            this.lblBrisanjeResult.TabIndex = 4;
            this.lblBrisanjeResult.Text = "label1";
            this.lblBrisanjeResult.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Brisanje_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1530, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBrisanjeResult);
            this.Controls.Add(this.btnBrisanjeBrisi);
            this.Controls.Add(this.btnBrisanjeIzadi);
            this.Controls.Add(this.dgvBrisanje);
            this.Controls.Add(this.cmbBrisanjeOdabir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Brisanje_popup";
            this.Text = "Brisanje_popup";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrisanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbBrisanjeOdabir;
        private System.Windows.Forms.DataGridView dgvBrisanje;
        private MetroFramework.Controls.MetroButton btnBrisanjeIzadi;
        private MetroFramework.Controls.MetroButton btnBrisanjeBrisi;
        private System.Windows.Forms.Label lblBrisanjeResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}