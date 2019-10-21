namespace BB_app.View
{
    partial class Kosevi_popup
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
            this.rbtnKoseviPopup02 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnKoseviPopup03 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnKoseviPopup04 = new MetroFramework.Controls.MetroRadioButton();
            this.lblKoseviPopup01 = new MetroFramework.Controls.MetroLabel();
            this.chbKoseviPogodeno = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // rbtnKoseviPopup02
            // 
            this.rbtnKoseviPopup02.AutoSize = true;
            this.rbtnKoseviPopup02.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnKoseviPopup02.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbtnKoseviPopup02.Location = new System.Drawing.Point(22, 76);
            this.rbtnKoseviPopup02.Name = "rbtnKoseviPopup02";
            this.rbtnKoseviPopup02.Size = new System.Drawing.Size(34, 20);
            this.rbtnKoseviPopup02.TabIndex = 1;
            this.rbtnKoseviPopup02.Text = "1";
            this.rbtnKoseviPopup02.UseSelectable = true;
            this.rbtnKoseviPopup02.CheckedChanged += new System.EventHandler(this.rbtnKoseviPopup02_CheckedChanged);
            // 
            // rbtnKoseviPopup03
            // 
            this.rbtnKoseviPopup03.AutoSize = true;
            this.rbtnKoseviPopup03.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnKoseviPopup03.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbtnKoseviPopup03.Location = new System.Drawing.Point(78, 76);
            this.rbtnKoseviPopup03.Name = "rbtnKoseviPopup03";
            this.rbtnKoseviPopup03.Size = new System.Drawing.Size(34, 20);
            this.rbtnKoseviPopup03.TabIndex = 2;
            this.rbtnKoseviPopup03.Text = "2";
            this.rbtnKoseviPopup03.UseSelectable = true;
            this.rbtnKoseviPopup03.CheckedChanged += new System.EventHandler(this.rbtnKoseviPopup03_CheckedChanged);
            // 
            // rbtnKoseviPopup04
            // 
            this.rbtnKoseviPopup04.AutoSize = true;
            this.rbtnKoseviPopup04.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbtnKoseviPopup04.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rbtnKoseviPopup04.Location = new System.Drawing.Point(131, 76);
            this.rbtnKoseviPopup04.Name = "rbtnKoseviPopup04";
            this.rbtnKoseviPopup04.Size = new System.Drawing.Size(34, 20);
            this.rbtnKoseviPopup04.TabIndex = 3;
            this.rbtnKoseviPopup04.Text = "3";
            this.rbtnKoseviPopup04.UseSelectable = true;
            this.rbtnKoseviPopup04.CheckedChanged += new System.EventHandler(this.rbtnKoseviPopup04_CheckedChanged);
            // 
            // lblKoseviPopup01
            // 
            this.lblKoseviPopup01.AutoSize = true;
            this.lblKoseviPopup01.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKoseviPopup01.Location = new System.Drawing.Point(50, 9);
            this.lblKoseviPopup01.Name = "lblKoseviPopup01";
            this.lblKoseviPopup01.Size = new System.Drawing.Size(94, 20);
            this.lblKoseviPopup01.TabIndex = 4;
            this.lblKoseviPopup01.Text = "Broj bodova";
            // 
            // chbKoseviPogodeno
            // 
            this.chbKoseviPogodeno.AutoSize = true;
            this.chbKoseviPogodeno.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chbKoseviPogodeno.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chbKoseviPogodeno.Location = new System.Drawing.Point(48, 41);
            this.chbKoseviPogodeno.Name = "chbKoseviPogodeno";
            this.chbKoseviPogodeno.Size = new System.Drawing.Size(96, 20);
            this.chbKoseviPogodeno.TabIndex = 5;
            this.chbKoseviPogodeno.Text = "Pogođeno";
            this.chbKoseviPogodeno.UseSelectable = true;
            // 
            // Kosevi_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(200, 108);
            this.Controls.Add(this.chbKoseviPogodeno);
            this.Controls.Add(this.lblKoseviPopup01);
            this.Controls.Add(this.rbtnKoseviPopup04);
            this.Controls.Add(this.rbtnKoseviPopup03);
            this.Controls.Add(this.rbtnKoseviPopup02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kosevi_popup";
            this.Text = "Kosevi_popup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton rbtnKoseviPopup02;
        private MetroFramework.Controls.MetroRadioButton rbtnKoseviPopup03;
        private MetroFramework.Controls.MetroRadioButton rbtnKoseviPopup04;
        private MetroFramework.Controls.MetroLabel lblKoseviPopup01;
        private MetroFramework.Controls.MetroCheckBox chbKoseviPogodeno;
    }
}