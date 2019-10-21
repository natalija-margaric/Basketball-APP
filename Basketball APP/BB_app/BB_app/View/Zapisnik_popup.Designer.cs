namespace BB_app.View
{
    partial class Zapisnik_popup
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
            this.lblZapisniPop01 = new MetroFramework.Controls.MetroLabel();
            this.btnZapisnikPop01 = new MetroFramework.Controls.MetroButton();
            this.btnZapisnikPop02 = new MetroFramework.Controls.MetroButton();
            this.btnZapisnikPop03 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblZapisniPop01
            // 
            this.lblZapisniPop01.AutoSize = true;
            this.lblZapisniPop01.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblZapisniPop01.Location = new System.Drawing.Point(52, 22);
            this.lblZapisniPop01.Name = "lblZapisniPop01";
            this.lblZapisniPop01.Size = new System.Drawing.Size(95, 20);
            this.lblZapisniPop01.TabIndex = 0;
            this.lblZapisniPop01.Text = "Način unosa";
            // 
            // btnZapisnikPop01
            // 
            this.btnZapisnikPop01.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnZapisnikPop01.Location = new System.Drawing.Point(28, 126);
            this.btnZapisnikPop01.Name = "btnZapisnikPop01";
            this.btnZapisnikPop01.Size = new System.Drawing.Size(136, 40);
            this.btnZapisnikPop01.TabIndex = 3;
            this.btnZapisnikPop01.Text = "Izađi";
            this.btnZapisnikPop01.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnZapisnikPop01.UseSelectable = true;
            this.btnZapisnikPop01.Click += new System.EventHandler(this.btnZapisnikPop01_Click);
            // 
            // btnZapisnikPop02
            // 
            this.btnZapisnikPop02.Location = new System.Drawing.Point(28, 60);
            this.btnZapisnikPop02.Name = "btnZapisnikPop02";
            this.btnZapisnikPop02.Size = new System.Drawing.Size(60, 50);
            this.btnZapisnikPop02.TabIndex = 4;
            this.btnZapisnikPop02.Text = "Ekipa";
            this.btnZapisnikPop02.UseSelectable = true;
            this.btnZapisnikPop02.Click += new System.EventHandler(this.btnZapisnikPop02_Click);
            // 
            // btnZapisnikPop03
            // 
            this.btnZapisnikPop03.Location = new System.Drawing.Point(104, 60);
            this.btnZapisnikPop03.Name = "btnZapisnikPop03";
            this.btnZapisnikPop03.Size = new System.Drawing.Size(60, 50);
            this.btnZapisnikPop03.TabIndex = 5;
            this.btnZapisnikPop03.Text = "Igrač";
            this.btnZapisnikPop03.UseSelectable = true;
            this.btnZapisnikPop03.Click += new System.EventHandler(this.btnZapisnikPop03_Click);
            // 
            // Zapisnik_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(197, 206);
            this.Controls.Add(this.btnZapisnikPop03);
            this.Controls.Add(this.btnZapisnikPop02);
            this.Controls.Add(this.btnZapisnikPop01);
            this.Controls.Add(this.lblZapisniPop01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zapisnik_popup";
            this.Text = "Zapisnik_popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblZapisniPop01;
        private MetroFramework.Controls.MetroButton btnZapisnikPop01;
        private MetroFramework.Controls.MetroButton btnZapisnikPop02;
        private MetroFramework.Controls.MetroButton btnZapisnikPop03;
    }
}