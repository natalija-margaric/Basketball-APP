namespace BB_app.View
{
    partial class Statistika_prikaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistika_prikaz));
            this.chartStatistikaVisina = new LiveCharts.WinForms.CartesianChart();
            this.cmbStatistikaOdabir = new MetroFramework.Controls.MetroComboBox();
            this.chartStatistikaTezina = new LiveCharts.WinForms.CartesianChart();
            this.chartStatistikaBrzinaS = new LiveCharts.WinForms.CartesianChart();
            this.chartStatistikaRasponR = new LiveCharts.WinForms.CartesianChart();
            this.chartStatistikaSkokU = new LiveCharts.WinForms.CartesianChart();
            this.chartStatistikaBrzinaSU = new LiveCharts.WinForms.CartesianChart();
            this.pieStatistikaPrisutnost = new LiveCharts.WinForms.PieChart();
            this.btnStatistikaKosevi = new MetroFramework.Controls.MetroButton();
            this.lblStatistikaTitle01 = new System.Windows.Forms.Label();
            this.lblStatistikaTitle02 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatistikaResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistikaVisina
            // 
            this.chartStatistikaVisina.BackColor = System.Drawing.Color.Transparent;
            this.chartStatistikaVisina.Location = new System.Drawing.Point(462, 34);
            this.chartStatistikaVisina.Name = "chartStatistikaVisina";
            this.chartStatistikaVisina.Size = new System.Drawing.Size(626, 298);
            this.chartStatistikaVisina.TabIndex = 0;
            this.chartStatistikaVisina.Text = "cartesianChart1";
            // 
            // cmbStatistikaOdabir
            // 
            this.cmbStatistikaOdabir.FormattingEnabled = true;
            this.cmbStatistikaOdabir.ItemHeight = 24;
            this.cmbStatistikaOdabir.Items.AddRange(new object[] {
            "Igrači",
            "Ekipe"});
            this.cmbStatistikaOdabir.Location = new System.Drawing.Point(129, 43);
            this.cmbStatistikaOdabir.Name = "cmbStatistikaOdabir";
            this.cmbStatistikaOdabir.Size = new System.Drawing.Size(195, 30);
            this.cmbStatistikaOdabir.TabIndex = 2;
            this.cmbStatistikaOdabir.UseSelectable = true;
            this.cmbStatistikaOdabir.SelectedIndexChanged += new System.EventHandler(this.cmbStatistikaOdabir_SelectedIndexChanged);
            // 
            // chartStatistikaTezina
            // 
            this.chartStatistikaTezina.BackColor = System.Drawing.Color.Transparent;
            this.chartStatistikaTezina.Location = new System.Drawing.Point(1174, 34);
            this.chartStatistikaTezina.Name = "chartStatistikaTezina";
            this.chartStatistikaTezina.Size = new System.Drawing.Size(626, 298);
            this.chartStatistikaTezina.TabIndex = 3;
            this.chartStatistikaTezina.Text = "cartesianChart1";
            // 
            // chartStatistikaBrzinaS
            // 
            this.chartStatistikaBrzinaS.BackColor = System.Drawing.Color.Transparent;
            this.chartStatistikaBrzinaS.Location = new System.Drawing.Point(1174, 358);
            this.chartStatistikaBrzinaS.Name = "chartStatistikaBrzinaS";
            this.chartStatistikaBrzinaS.Size = new System.Drawing.Size(626, 298);
            this.chartStatistikaBrzinaS.TabIndex = 5;
            this.chartStatistikaBrzinaS.Text = "cartesianChart1";
            // 
            // chartStatistikaRasponR
            // 
            this.chartStatistikaRasponR.BackColor = System.Drawing.Color.Transparent;
            this.chartStatistikaRasponR.Location = new System.Drawing.Point(462, 358);
            this.chartStatistikaRasponR.Name = "chartStatistikaRasponR";
            this.chartStatistikaRasponR.Size = new System.Drawing.Size(626, 298);
            this.chartStatistikaRasponR.TabIndex = 4;
            this.chartStatistikaRasponR.Text = "cartesianChart1";
            // 
            // chartStatistikaSkokU
            // 
            this.chartStatistikaSkokU.BackColor = System.Drawing.Color.Transparent;
            this.chartStatistikaSkokU.Location = new System.Drawing.Point(462, 682);
            this.chartStatistikaSkokU.Name = "chartStatistikaSkokU";
            this.chartStatistikaSkokU.Size = new System.Drawing.Size(626, 298);
            this.chartStatistikaSkokU.TabIndex = 6;
            this.chartStatistikaSkokU.Text = "cartesianChart1";
            // 
            // chartStatistikaBrzinaSU
            // 
            this.chartStatistikaBrzinaSU.BackColor = System.Drawing.Color.Transparent;
            this.chartStatistikaBrzinaSU.Location = new System.Drawing.Point(1174, 682);
            this.chartStatistikaBrzinaSU.Name = "chartStatistikaBrzinaSU";
            this.chartStatistikaBrzinaSU.Size = new System.Drawing.Size(626, 298);
            this.chartStatistikaBrzinaSU.TabIndex = 7;
            this.chartStatistikaBrzinaSU.Text = "cartesianChart1";
            // 
            // pieStatistikaPrisutnost
            // 
            this.pieStatistikaPrisutnost.BackColor = System.Drawing.Color.Transparent;
            this.pieStatistikaPrisutnost.Location = new System.Drawing.Point(72, 434);
            this.pieStatistikaPrisutnost.Name = "pieStatistikaPrisutnost";
            this.pieStatistikaPrisutnost.Size = new System.Drawing.Size(343, 305);
            this.pieStatistikaPrisutnost.TabIndex = 8;
            this.pieStatistikaPrisutnost.Text = "pieChart1";
            // 
            // btnStatistikaKosevi
            // 
            this.btnStatistikaKosevi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStatistikaKosevi.Location = new System.Drawing.Point(131, 858);
            this.btnStatistikaKosevi.Name = "btnStatistikaKosevi";
            this.btnStatistikaKosevi.Size = new System.Drawing.Size(193, 66);
            this.btnStatistikaKosevi.TabIndex = 9;
            this.btnStatistikaKosevi.Text = "Prikaz koševa";
            this.btnStatistikaKosevi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStatistikaKosevi.UseSelectable = true;
            this.btnStatistikaKosevi.Click += new System.EventHandler(this.btnStatistikaKosevi_Click);
            // 
            // lblStatistikaTitle01
            // 
            this.lblStatistikaTitle01.AutoSize = true;
            this.lblStatistikaTitle01.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistikaTitle01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistikaTitle01.ForeColor = System.Drawing.Color.White;
            this.lblStatistikaTitle01.Location = new System.Drawing.Point(490, 13);
            this.lblStatistikaTitle01.Name = "lblStatistikaTitle01";
            this.lblStatistikaTitle01.Size = new System.Drawing.Size(61, 20);
            this.lblStatistikaTitle01.TabIndex = 10;
            this.lblStatistikaTitle01.Text = "Visina";
            // 
            // lblStatistikaTitle02
            // 
            this.lblStatistikaTitle02.AutoSize = true;
            this.lblStatistikaTitle02.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistikaTitle02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistikaTitle02.ForeColor = System.Drawing.Color.White;
            this.lblStatistikaTitle02.Location = new System.Drawing.Point(1200, 13);
            this.lblStatistikaTitle02.Name = "lblStatistikaTitle02";
            this.lblStatistikaTitle02.Size = new System.Drawing.Size(65, 20);
            this.lblStatistikaTitle02.TabIndex = 11;
            this.lblStatistikaTitle02.Text = "Težina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1200, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Brzina šprint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(490, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Raspon ruku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1200, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Brzina samoubojstvo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(490, 659);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Skok udalj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(127, 773);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prisutnost na treninzima";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatistikaResult
            // 
            this.lblStatistikaResult.AutoSize = true;
            this.lblStatistikaResult.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistikaResult.ForeColor = System.Drawing.Color.Red;
            this.lblStatistikaResult.Location = new System.Drawing.Point(13, 962);
            this.lblStatistikaResult.Name = "lblStatistikaResult";
            this.lblStatistikaResult.Size = new System.Drawing.Size(46, 17);
            this.lblStatistikaResult.TabIndex = 18;
            this.lblStatistikaResult.Text = "label1";
            this.lblStatistikaResult.Visible = false;
            // 
            // Statistika_prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1836, 992);
            this.Controls.Add(this.lblStatistikaResult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatistikaTitle02);
            this.Controls.Add(this.lblStatistikaTitle01);
            this.Controls.Add(this.btnStatistikaKosevi);
            this.Controls.Add(this.pieStatistikaPrisutnost);
            this.Controls.Add(this.chartStatistikaBrzinaSU);
            this.Controls.Add(this.chartStatistikaSkokU);
            this.Controls.Add(this.chartStatistikaBrzinaS);
            this.Controls.Add(this.chartStatistikaRasponR);
            this.Controls.Add(this.chartStatistikaTezina);
            this.Controls.Add(this.cmbStatistikaOdabir);
            this.Controls.Add(this.chartStatistikaVisina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Statistika_prikaz";
            this.Text = "Statistika_prikaz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chartStatistikaVisina;
        private MetroFramework.Controls.MetroComboBox cmbStatistikaOdabir;
        private LiveCharts.WinForms.CartesianChart chartStatistikaTezina;
        private LiveCharts.WinForms.CartesianChart chartStatistikaBrzinaS;
        private LiveCharts.WinForms.CartesianChart chartStatistikaRasponR;
        private LiveCharts.WinForms.CartesianChart chartStatistikaSkokU;
        private LiveCharts.WinForms.CartesianChart chartStatistikaBrzinaSU;
        private LiveCharts.WinForms.PieChart pieStatistikaPrisutnost;
        private MetroFramework.Controls.MetroButton btnStatistikaKosevi;
        private System.Windows.Forms.Label lblStatistikaTitle01;
        private System.Windows.Forms.Label lblStatistikaTitle02;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatistikaResult;
    }
}