namespace BB_app.View
{
    partial class Trening_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trening_dashboard));
            this.lblDashboard01 = new System.Windows.Forms.Label();
            this.picbDashboardTeren = new System.Windows.Forms.PictureBox();
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.btnDashboardSprint = new MetroFramework.Controls.MetroButton();
            this.btnDashboardSkUd = new MetroFramework.Controls.MetroButton();
            this.panelDashboardTimer = new MetroFramework.Controls.MetroPanel();
            this.btnTimerReset = new MetroFramework.Controls.MetroButton();
            this.btnTimerStar = new MetroFramework.Controls.MetroButton();
            this.lblDashboradTimer = new System.Windows.Forms.Label();
            this.btnDashboardKraj = new MetroFramework.Controls.MetroButton();
            this.btnDashboardSU = new MetroFramework.Controls.MetroButton();
            this.btnDashboardBrzina = new MetroFramework.Controls.MetroButton();
            this.btnDashboardMjerenja = new MetroFramework.Controls.MetroButton();
            this.panelDashboardUnos = new MetroFramework.Controls.MetroPanel();
            this.btnPanelIzadi = new MetroFramework.Controls.MetroButton();
            this.btnPanelUnos = new MetroFramework.Controls.MetroButton();
            this.lblPanelIgrac = new System.Windows.Forms.Label();
            this.txtbPanelValue = new MetroFramework.Controls.MetroTextBox();
            this.lblPanel01 = new System.Windows.Forms.Label();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.dgvDashboardIgraci = new System.Windows.Forms.DataGridView();
            this.lblDashboardResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbDashboardTeren)).BeginInit();
            this.panelDashboardTimer.SuspendLayout();
            this.panelDashboardUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardIgraci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard01
            // 
            this.lblDashboard01.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard01.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDashboard01.Location = new System.Drawing.Point(243, 9);
            this.lblDashboard01.Name = "lblDashboard01";
            this.lblDashboard01.Size = new System.Drawing.Size(536, 25);
            this.lblDashboard01.TabIndex = 0;
            this.lblDashboard01.Text = "label1";
            // 
            // picbDashboardTeren
            // 
            this.picbDashboardTeren.Image = ((System.Drawing.Image)(resources.GetObject("picbDashboardTeren.Image")));
            this.picbDashboardTeren.Location = new System.Drawing.Point(585, 47);
            this.picbDashboardTeren.Name = "picbDashboardTeren";
            this.picbDashboardTeren.Size = new System.Drawing.Size(665, 621);
            this.picbDashboardTeren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbDashboardTeren.TabIndex = 1;
            this.picbDashboardTeren.TabStop = false;
            this.picbDashboardTeren.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbDashboardTeren_MouseUp);
            // 
            // timerDashboard
            // 
            this.timerDashboard.Tick += new System.EventHandler(this.timerDashboard_Tick);
            // 
            // btnDashboardSprint
            // 
            this.btnDashboardSprint.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardSprint.Location = new System.Drawing.Point(0, 120);
            this.btnDashboardSprint.Name = "btnDashboardSprint";
            this.btnDashboardSprint.Size = new System.Drawing.Size(200, 120);
            this.btnDashboardSprint.TabIndex = 3;
            this.btnDashboardSprint.Text = "Šprint";
            this.btnDashboardSprint.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardSprint.UseSelectable = true;
            this.btnDashboardSprint.Click += new System.EventHandler(this.btnDashboardSprint_Click);
            // 
            // btnDashboardSkUd
            // 
            this.btnDashboardSkUd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardSkUd.Location = new System.Drawing.Point(0, 360);
            this.btnDashboardSkUd.Name = "btnDashboardSkUd";
            this.btnDashboardSkUd.Size = new System.Drawing.Size(200, 120);
            this.btnDashboardSkUd.TabIndex = 4;
            this.btnDashboardSkUd.Text = "Skok udalj";
            this.btnDashboardSkUd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardSkUd.UseSelectable = true;
            this.btnDashboardSkUd.Click += new System.EventHandler(this.btnDashboardSkUd_Click);
            // 
            // panelDashboardTimer
            // 
            this.panelDashboardTimer.BackColor = System.Drawing.Color.LightBlue;
            this.panelDashboardTimer.Controls.Add(this.btnTimerReset);
            this.panelDashboardTimer.Controls.Add(this.btnTimerStar);
            this.panelDashboardTimer.Controls.Add(this.lblDashboradTimer);
            this.panelDashboardTimer.HorizontalScrollbarBarColor = true;
            this.panelDashboardTimer.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDashboardTimer.HorizontalScrollbarSize = 10;
            this.panelDashboardTimer.Location = new System.Drawing.Point(225, 618);
            this.panelDashboardTimer.Name = "panelDashboardTimer";
            this.panelDashboardTimer.Size = new System.Drawing.Size(326, 75);
            this.panelDashboardTimer.TabIndex = 5;
            this.panelDashboardTimer.VerticalScrollbarBarColor = true;
            this.panelDashboardTimer.VerticalScrollbarHighlightOnWheel = false;
            this.panelDashboardTimer.VerticalScrollbarSize = 10;
            // 
            // btnTimerReset
            // 
            this.btnTimerReset.Location = new System.Drawing.Point(235, 3);
            this.btnTimerReset.Name = "btnTimerReset";
            this.btnTimerReset.Size = new System.Drawing.Size(85, 65);
            this.btnTimerReset.TabIndex = 4;
            this.btnTimerReset.Text = "RESET";
            this.btnTimerReset.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTimerReset.UseSelectable = true;
            this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
            // 
            // btnTimerStar
            // 
            this.btnTimerStar.Location = new System.Drawing.Point(3, 3);
            this.btnTimerStar.Name = "btnTimerStar";
            this.btnTimerStar.Size = new System.Drawing.Size(85, 65);
            this.btnTimerStar.TabIndex = 3;
            this.btnTimerStar.Text = "START";
            this.btnTimerStar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTimerStar.UseSelectable = true;
            this.btnTimerStar.Click += new System.EventHandler(this.btnTimerStar_Click);
            // 
            // lblDashboradTimer
            // 
            this.lblDashboradTimer.BackColor = System.Drawing.Color.LightBlue;
            this.lblDashboradTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboradTimer.Location = new System.Drawing.Point(96, 18);
            this.lblDashboradTimer.Name = "lblDashboradTimer";
            this.lblDashboradTimer.Size = new System.Drawing.Size(133, 38);
            this.lblDashboradTimer.TabIndex = 2;
            this.lblDashboradTimer.Text = "00:00:00";
            // 
            // btnDashboardKraj
            // 
            this.btnDashboardKraj.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardKraj.Location = new System.Drawing.Point(0, 600);
            this.btnDashboardKraj.Name = "btnDashboardKraj";
            this.btnDashboardKraj.Size = new System.Drawing.Size(200, 120);
            this.btnDashboardKraj.TabIndex = 6;
            this.btnDashboardKraj.Text = "Završi trening";
            this.btnDashboardKraj.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardKraj.UseSelectable = true;
            this.btnDashboardKraj.Click += new System.EventHandler(this.btnDashboardKraj_Click);
            // 
            // btnDashboardSU
            // 
            this.btnDashboardSU.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardSU.Location = new System.Drawing.Point(0, 240);
            this.btnDashboardSU.Name = "btnDashboardSU";
            this.btnDashboardSU.Size = new System.Drawing.Size(200, 120);
            this.btnDashboardSU.TabIndex = 7;
            this.btnDashboardSU.Text = "Samoubojstvo";
            this.btnDashboardSU.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardSU.UseSelectable = true;
            this.btnDashboardSU.Click += new System.EventHandler(this.btnDashboardSU_Click);
            // 
            // btnDashboardBrzina
            // 
            this.btnDashboardBrzina.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardBrzina.Location = new System.Drawing.Point(0, 0);
            this.btnDashboardBrzina.Name = "btnDashboardBrzina";
            this.btnDashboardBrzina.Size = new System.Drawing.Size(200, 120);
            this.btnDashboardBrzina.TabIndex = 8;
            this.btnDashboardBrzina.Text = "Brzina";
            this.btnDashboardBrzina.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardBrzina.UseSelectable = true;
            this.btnDashboardBrzina.Click += new System.EventHandler(this.btnDashboardBrzina_Click);
            // 
            // btnDashboardMjerenja
            // 
            this.btnDashboardMjerenja.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDashboardMjerenja.Location = new System.Drawing.Point(0, 480);
            this.btnDashboardMjerenja.Name = "btnDashboardMjerenja";
            this.btnDashboardMjerenja.Size = new System.Drawing.Size(200, 120);
            this.btnDashboardMjerenja.TabIndex = 9;
            this.btnDashboardMjerenja.Text = "Mjerenje";
            this.btnDashboardMjerenja.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDashboardMjerenja.UseSelectable = true;
            this.btnDashboardMjerenja.Click += new System.EventHandler(this.btnDashboardMjerenja_Click);
            // 
            // panelDashboardUnos
            // 
            this.panelDashboardUnos.Controls.Add(this.btnPanelIzadi);
            this.panelDashboardUnos.Controls.Add(this.btnPanelUnos);
            this.panelDashboardUnos.Controls.Add(this.lblPanelIgrac);
            this.panelDashboardUnos.Controls.Add(this.txtbPanelValue);
            this.panelDashboardUnos.Controls.Add(this.lblPanel01);
            this.panelDashboardUnos.Controls.Add(this.lblPanelTitle);
            this.panelDashboardUnos.HorizontalScrollbarBarColor = true;
            this.panelDashboardUnos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDashboardUnos.HorizontalScrollbarSize = 10;
            this.panelDashboardUnos.Location = new System.Drawing.Point(228, 360);
            this.panelDashboardUnos.Name = "panelDashboardUnos";
            this.panelDashboardUnos.Size = new System.Drawing.Size(323, 238);
            this.panelDashboardUnos.TabIndex = 10;
            this.panelDashboardUnos.VerticalScrollbarBarColor = true;
            this.panelDashboardUnos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDashboardUnos.VerticalScrollbarSize = 10;
            this.panelDashboardUnos.Visible = false;
            // 
            // btnPanelIzadi
            // 
            this.btnPanelIzadi.Location = new System.Drawing.Point(184, 160);
            this.btnPanelIzadi.Name = "btnPanelIzadi";
            this.btnPanelIzadi.Size = new System.Drawing.Size(85, 65);
            this.btnPanelIzadi.TabIndex = 7;
            this.btnPanelIzadi.Text = "IZAĐI";
            this.btnPanelIzadi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPanelIzadi.UseSelectable = true;
            this.btnPanelIzadi.Click += new System.EventHandler(this.btnPanelIzadi_Click);
            // 
            // btnPanelUnos
            // 
            this.btnPanelUnos.Location = new System.Drawing.Point(53, 160);
            this.btnPanelUnos.Name = "btnPanelUnos";
            this.btnPanelUnos.Size = new System.Drawing.Size(85, 65);
            this.btnPanelUnos.TabIndex = 6;
            this.btnPanelUnos.Text = "UNESI";
            this.btnPanelUnos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPanelUnos.UseSelectable = true;
            this.btnPanelUnos.Click += new System.EventHandler(this.btnPanelUnos_Click);
            // 
            // lblPanelIgrac
            // 
            this.lblPanelIgrac.AutoSize = true;
            this.lblPanelIgrac.BackColor = System.Drawing.Color.White;
            this.lblPanelIgrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelIgrac.Location = new System.Drawing.Point(19, 51);
            this.lblPanelIgrac.Name = "lblPanelIgrac";
            this.lblPanelIgrac.Size = new System.Drawing.Size(52, 17);
            this.lblPanelIgrac.TabIndex = 5;
            this.lblPanelIgrac.Text = "label1";
            // 
            // txtbPanelValue
            // 
            // 
            // 
            // 
            this.txtbPanelValue.CustomButton.Image = null;
            this.txtbPanelValue.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.txtbPanelValue.CustomButton.Name = "";
            this.txtbPanelValue.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtbPanelValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbPanelValue.CustomButton.TabIndex = 1;
            this.txtbPanelValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbPanelValue.CustomButton.UseSelectable = true;
            this.txtbPanelValue.CustomButton.Visible = false;
            this.txtbPanelValue.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtbPanelValue.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtbPanelValue.Lines = new string[0];
            this.txtbPanelValue.Location = new System.Drawing.Point(49, 117);
            this.txtbPanelValue.MaxLength = 32767;
            this.txtbPanelValue.Name = "txtbPanelValue";
            this.txtbPanelValue.PasswordChar = '\0';
            this.txtbPanelValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbPanelValue.SelectedText = "";
            this.txtbPanelValue.SelectionLength = 0;
            this.txtbPanelValue.SelectionStart = 0;
            this.txtbPanelValue.ShortcutsEnabled = true;
            this.txtbPanelValue.Size = new System.Drawing.Size(230, 28);
            this.txtbPanelValue.TabIndex = 4;
            this.txtbPanelValue.UseSelectable = true;
            this.txtbPanelValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbPanelValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPanel01
            // 
            this.lblPanel01.AutoSize = true;
            this.lblPanel01.BackColor = System.Drawing.Color.White;
            this.lblPanel01.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPanel01.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel01.Location = new System.Drawing.Point(46, 85);
            this.lblPanel01.Name = "lblPanel01";
            this.lblPanel01.Size = new System.Drawing.Size(206, 17);
            this.lblPanel01.TabIndex = 3;
            this.lblPanel01.Text = "Unesite vrijednost mjerenja";
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.BackColor = System.Drawing.Color.White;
            this.lblPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTitle.Location = new System.Drawing.Point(18, 15);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(120, 23);
            this.lblPanelTitle.TabIndex = 2;
            this.lblPanelTitle.Text = "label1";
            // 
            // dgvDashboardIgraci
            // 
            this.dgvDashboardIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboardIgraci.Location = new System.Drawing.Point(225, 47);
            this.dgvDashboardIgraci.Name = "dgvDashboardIgraci";
            this.dgvDashboardIgraci.RowTemplate.Height = 24;
            this.dgvDashboardIgraci.Size = new System.Drawing.Size(326, 285);
            this.dgvDashboardIgraci.TabIndex = 11;
            // 
            // lblDashboardResult
            // 
            this.lblDashboardResult.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblDashboardResult.Location = new System.Drawing.Point(958, 9);
            this.lblDashboardResult.Name = "lblDashboardResult";
            this.lblDashboardResult.Size = new System.Drawing.Size(292, 23);
            this.lblDashboardResult.TabIndex = 12;
            this.lblDashboardResult.Text = "label1";
            this.lblDashboardResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDashboardResult.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Trening_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BB_app.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1358, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDashboardResult);
            this.Controls.Add(this.dgvDashboardIgraci);
            this.Controls.Add(this.panelDashboardUnos);
            this.Controls.Add(this.btnDashboardMjerenja);
            this.Controls.Add(this.btnDashboardBrzina);
            this.Controls.Add(this.btnDashboardSU);
            this.Controls.Add(this.btnDashboardKraj);
            this.Controls.Add(this.panelDashboardTimer);
            this.Controls.Add(this.btnDashboardSkUd);
            this.Controls.Add(this.btnDashboardSprint);
            this.Controls.Add(this.picbDashboardTeren);
            this.Controls.Add(this.lblDashboard01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Trening_dashboard";
            this.Text = "BBStat - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.picbDashboardTeren)).EndInit();
            this.panelDashboardTimer.ResumeLayout(false);
            this.panelDashboardUnos.ResumeLayout(false);
            this.panelDashboardUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboardIgraci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard01;
        private System.Windows.Forms.PictureBox picbDashboardTeren;
        private System.Windows.Forms.Timer timerDashboard;
        private MetroFramework.Controls.MetroButton btnDashboardSprint;
        private MetroFramework.Controls.MetroButton btnDashboardSkUd;
        private MetroFramework.Controls.MetroPanel panelDashboardTimer;
        private MetroFramework.Controls.MetroButton btnTimerReset;
        private MetroFramework.Controls.MetroButton btnTimerStar;
        private System.Windows.Forms.Label lblDashboradTimer;
        private MetroFramework.Controls.MetroButton btnDashboardKraj;
        private MetroFramework.Controls.MetroButton btnDashboardSU;
        private MetroFramework.Controls.MetroButton btnDashboardBrzina;
        private MetroFramework.Controls.MetroButton btnDashboardMjerenja;
        private MetroFramework.Controls.MetroPanel panelDashboardUnos;
        private MetroFramework.Controls.MetroButton btnPanelIzadi;
        private MetroFramework.Controls.MetroButton btnPanelUnos;
        private System.Windows.Forms.Label lblPanelIgrac;
        private MetroFramework.Controls.MetroTextBox txtbPanelValue;
        private System.Windows.Forms.Label lblPanel01;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.DataGridView dgvDashboardIgraci;
        private System.Windows.Forms.Label lblDashboardResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}