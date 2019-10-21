namespace BB_app.View
{
    partial class KoseviSut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KoseviSut));
            this.picbKoseviTeren = new System.Windows.Forms.PictureBox();
            this.lblKosevuSutTitle = new System.Windows.Forms.Label();
            this.lblKoseviSutIzvor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKoseviResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbKoseviTeren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbKoseviTeren
            // 
            this.picbKoseviTeren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbKoseviTeren.Image = ((System.Drawing.Image)(resources.GetObject("picbKoseviTeren.Image")));
            this.picbKoseviTeren.Location = new System.Drawing.Point(404, 12);
            this.picbKoseviTeren.Name = "picbKoseviTeren";
            this.picbKoseviTeren.Size = new System.Drawing.Size(673, 614);
            this.picbKoseviTeren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbKoseviTeren.TabIndex = 0;
            this.picbKoseviTeren.TabStop = false;
            this.picbKoseviTeren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbKoseviTeren_MouseUp);
            // 
            // lblKosevuSutTitle
            // 
            this.lblKosevuSutTitle.AutoSize = true;
            this.lblKosevuSutTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblKosevuSutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKosevuSutTitle.ForeColor = System.Drawing.Color.White;
            this.lblKosevuSutTitle.Location = new System.Drawing.Point(86, 9);
            this.lblKosevuSutTitle.Name = "lblKosevuSutTitle";
            this.lblKosevuSutTitle.Size = new System.Drawing.Size(160, 29);
            this.lblKosevuSutTitle.TabIndex = 1;
            this.lblKosevuSutTitle.Text = "Unos koševa";
            // 
            // lblKoseviSutIzvor
            // 
            this.lblKoseviSutIzvor.AutoSize = true;
            this.lblKoseviSutIzvor.BackColor = System.Drawing.Color.Transparent;
            this.lblKoseviSutIzvor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKoseviSutIzvor.ForeColor = System.Drawing.Color.White;
            this.lblKoseviSutIzvor.Location = new System.Drawing.Point(87, 48);
            this.lblKoseviSutIzvor.Name = "lblKoseviSutIzvor";
            this.lblKoseviSutIzvor.Size = new System.Drawing.Size(60, 24);
            this.lblKoseviSutIzvor.TabIndex = 2;
            this.lblKoseviSutIzvor.Text = "label1";
            this.lblKoseviSutIzvor.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblKoseviResult
            // 
            this.lblKoseviResult.AutoSize = true;
            this.lblKoseviResult.BackColor = System.Drawing.Color.Transparent;
            this.lblKoseviResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKoseviResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblKoseviResult.Location = new System.Drawing.Point(41, 595);
            this.lblKoseviResult.Name = "lblKoseviResult";
            this.lblKoseviResult.Size = new System.Drawing.Size(60, 24);
            this.lblKoseviResult.TabIndex = 6;
            this.lblKoseviResult.Text = "label1";
            this.lblKoseviResult.Visible = false;
            // 
            // KoseviSut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 638);
            this.Controls.Add(this.lblKoseviResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKoseviSutIzvor);
            this.Controls.Add(this.lblKosevuSutTitle);
            this.Controls.Add(this.picbKoseviTeren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KoseviSut";
            this.Text = "Kosevi";
            ((System.ComponentModel.ISupportInitialize)(this.picbKoseviTeren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbKoseviTeren;
        private System.Windows.Forms.Label lblKosevuSutTitle;
        private System.Windows.Forms.Label lblKoseviSutIzvor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblKoseviResult;
    }
}