namespace B191210004
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbResim = new System.Windows.Forms.GroupBox();
            this.ptbRstResim = new System.Windows.Forms.PictureBox();
            this.grbAnaMenu = new System.Windows.Forms.GroupBox();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblPuanSayi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAtik = new System.Windows.Forms.Label();
            this.grbOrnagikAtik = new System.Windows.Forms.GroupBox();
            this.btnOrganikAtik = new System.Windows.Forms.Button();
            this.progOrnagik = new System.Windows.Forms.ProgressBar();
            this.lstOrganikAtik = new System.Windows.Forms.ListBox();
            this.btnOrganikBosalt = new System.Windows.Forms.Button();
            this.grbKagitAtik = new System.Windows.Forms.GroupBox();
            this.btnKagitAtik = new System.Windows.Forms.Button();
            this.btnKagitBosalt = new System.Windows.Forms.Button();
            this.progKagit = new System.Windows.Forms.ProgressBar();
            this.lstKagitAtik = new System.Windows.Forms.ListBox();
            this.grbCamAtik = new System.Windows.Forms.GroupBox();
            this.btnCamAtik = new System.Windows.Forms.Button();
            this.btnCamBosalt = new System.Windows.Forms.Button();
            this.progCam = new System.Windows.Forms.ProgressBar();
            this.lstCamAtik = new System.Windows.Forms.ListBox();
            this.grbMetalAtik = new System.Windows.Forms.GroupBox();
            this.btnMetalAtik = new System.Windows.Forms.Button();
            this.btnMetalBosalt = new System.Windows.Forms.Button();
            this.progMetal = new System.Windows.Forms.ProgressBar();
            this.lstMetalAtik = new System.Windows.Forms.ListBox();
            this.grbResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRstResim)).BeginInit();
            this.grbAnaMenu.SuspendLayout();
            this.grbOrnagikAtik.SuspendLayout();
            this.grbKagitAtik.SuspendLayout();
            this.grbCamAtik.SuspendLayout();
            this.grbMetalAtik.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbResim
            // 
            this.grbResim.BackColor = System.Drawing.Color.White;
            this.grbResim.Controls.Add(this.ptbRstResim);
            this.grbResim.Location = new System.Drawing.Point(21, 4);
            this.grbResim.Name = "grbResim";
            this.grbResim.Size = new System.Drawing.Size(202, 202);
            this.grbResim.TabIndex = 0;
            this.grbResim.TabStop = false;
            // 
            // ptbRstResim
            // 
            this.ptbRstResim.Location = new System.Drawing.Point(19, 21);
            this.ptbRstResim.Name = "ptbRstResim";
            this.ptbRstResim.Size = new System.Drawing.Size(163, 153);
            this.ptbRstResim.TabIndex = 0;
            this.ptbRstResim.TabStop = false;
            // 
            // grbAnaMenu
            // 
            this.grbAnaMenu.BackColor = System.Drawing.Color.White;
            this.grbAnaMenu.Controls.Add(this.lblSaniye);
            this.grbAnaMenu.Controls.Add(this.lblPuan);
            this.grbAnaMenu.Controls.Add(this.lblPuanSayi);
            this.grbAnaMenu.Controls.Add(this.btnCikis);
            this.grbAnaMenu.Controls.Add(this.lblSure);
            this.grbAnaMenu.Controls.Add(this.btnYeniOyun);
            this.grbAnaMenu.Location = new System.Drawing.Point(21, 225);
            this.grbAnaMenu.Name = "grbAnaMenu";
            this.grbAnaMenu.Size = new System.Drawing.Size(200, 361);
            this.grbAnaMenu.TabIndex = 1;
            this.grbAnaMenu.TabStop = false;
            this.grbAnaMenu.UseWaitCursor = true;
            // 
            // lblSaniye
            // 
            this.lblSaniye.BackColor = System.Drawing.Color.Silver;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(19, 130);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(163, 46);
            this.lblSaniye.TabIndex = 5;
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaniye.UseWaitCursor = true;
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.Color.Teal;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuan.Location = new System.Drawing.Point(15, 212);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(163, 23);
            this.lblPuan.TabIndex = 4;
            this.lblPuan.Text = "PUAN";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPuan.UseWaitCursor = true;
            // 
            // lblPuanSayi
            // 
            this.lblPuanSayi.BackColor = System.Drawing.Color.LightGray;
            this.lblPuanSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuanSayi.Location = new System.Drawing.Point(16, 235);
            this.lblPuanSayi.Name = "lblPuanSayi";
            this.lblPuanSayi.Size = new System.Drawing.Size(163, 46);
            this.lblPuanSayi.TabIndex = 3;
            this.lblPuanSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPuanSayi.UseWaitCursor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCikis.Location = new System.Drawing.Point(16, 300);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(163, 47);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.UseWaitCursor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.Color.Teal;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.White;
            this.lblSure.Location = new System.Drawing.Point(19, 107);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(163, 23);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "SÜRE";
            this.lblSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSure.UseWaitCursor = true;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnYeniOyun.Location = new System.Drawing.Point(19, 21);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(163, 69);
            this.btnYeniOyun.TabIndex = 0;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.UseWaitCursor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAtik
            // 
            this.lblAtik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAtik.BackColor = System.Drawing.Color.PeachPuff;
            this.lblAtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAtik.Location = new System.Drawing.Point(263, 9);
            this.lblAtik.Name = "lblAtik";
            this.lblAtik.Size = new System.Drawing.Size(433, 34);
            this.lblAtik.TabIndex = 2;
            this.lblAtik.Text = "ATIK KUTULARI";
            this.lblAtik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbOrnagikAtik
            // 
            this.grbOrnagikAtik.BackColor = System.Drawing.Color.Teal;
            this.grbOrnagikAtik.Controls.Add(this.btnOrganikAtik);
            this.grbOrnagikAtik.Controls.Add(this.progOrnagik);
            this.grbOrnagikAtik.Controls.Add(this.lstOrganikAtik);
            this.grbOrnagikAtik.Controls.Add(this.btnOrganikBosalt);
            this.grbOrnagikAtik.Location = new System.Drawing.Point(263, 57);
            this.grbOrnagikAtik.Name = "grbOrnagikAtik";
            this.grbOrnagikAtik.Size = new System.Drawing.Size(208, 258);
            this.grbOrnagikAtik.TabIndex = 3;
            this.grbOrnagikAtik.TabStop = false;
            // 
            // btnOrganikAtik
            // 
            this.btnOrganikAtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrganikAtik.Location = new System.Drawing.Point(12, 18);
            this.btnOrganikAtik.Name = "btnOrganikAtik";
            this.btnOrganikAtik.Size = new System.Drawing.Size(178, 29);
            this.btnOrganikAtik.TabIndex = 5;
            this.btnOrganikAtik.Text = "ORGANİK ATIK";
            this.btnOrganikAtik.UseVisualStyleBackColor = true;
            this.btnOrganikAtik.Click += new System.EventHandler(this.btnOrganikAtik_Click);
            // 
            // progOrnagik
            // 
            this.progOrnagik.Location = new System.Drawing.Point(11, 189);
            this.progOrnagik.Maximum = 700;
            this.progOrnagik.Name = "progOrnagik";
            this.progOrnagik.Size = new System.Drawing.Size(178, 23);
            this.progOrnagik.TabIndex = 4;
            // 
            // lstOrganikAtik
            // 
            this.lstOrganikAtik.FormattingEnabled = true;
            this.lstOrganikAtik.ItemHeight = 16;
            this.lstOrganikAtik.Location = new System.Drawing.Point(11, 50);
            this.lstOrganikAtik.Name = "lstOrganikAtik";
            this.lstOrganikAtik.Size = new System.Drawing.Size(178, 132);
            this.lstOrganikAtik.TabIndex = 3;
            // 
            // btnOrganikBosalt
            // 
            this.btnOrganikBosalt.Location = new System.Drawing.Point(11, 218);
            this.btnOrganikBosalt.Name = "btnOrganikBosalt";
            this.btnOrganikBosalt.Size = new System.Drawing.Size(178, 31);
            this.btnOrganikBosalt.TabIndex = 2;
            this.btnOrganikBosalt.Text = "BOŞALT";
            this.btnOrganikBosalt.UseVisualStyleBackColor = true;
            this.btnOrganikBosalt.Click += new System.EventHandler(this.btnOrganikBosalt_Click);
            // 
            // grbKagitAtik
            // 
            this.grbKagitAtik.BackColor = System.Drawing.Color.Teal;
            this.grbKagitAtik.Controls.Add(this.btnKagitAtik);
            this.grbKagitAtik.Controls.Add(this.btnKagitBosalt);
            this.grbKagitAtik.Controls.Add(this.progKagit);
            this.grbKagitAtik.Controls.Add(this.lstKagitAtik);
            this.grbKagitAtik.Location = new System.Drawing.Point(488, 57);
            this.grbKagitAtik.Name = "grbKagitAtik";
            this.grbKagitAtik.Size = new System.Drawing.Size(208, 258);
            this.grbKagitAtik.TabIndex = 4;
            this.grbKagitAtik.TabStop = false;
            // 
            // btnKagitAtik
            // 
            this.btnKagitAtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKagitAtik.Location = new System.Drawing.Point(15, 19);
            this.btnKagitAtik.Name = "btnKagitAtik";
            this.btnKagitAtik.Size = new System.Drawing.Size(178, 29);
            this.btnKagitAtik.TabIndex = 4;
            this.btnKagitAtik.Text = "KAĞIT ATIK";
            this.btnKagitAtik.UseVisualStyleBackColor = true;
            this.btnKagitAtik.Click += new System.EventHandler(this.btnKagitAtik_Click);
            // 
            // btnKagitBosalt
            // 
            this.btnKagitBosalt.Location = new System.Drawing.Point(15, 217);
            this.btnKagitBosalt.Name = "btnKagitBosalt";
            this.btnKagitBosalt.Size = new System.Drawing.Size(178, 31);
            this.btnKagitBosalt.TabIndex = 3;
            this.btnKagitBosalt.Text = "BOŞALT";
            this.btnKagitBosalt.UseVisualStyleBackColor = true;
            this.btnKagitBosalt.Click += new System.EventHandler(this.btnKagitBosalt_Click);
            // 
            // progKagit
            // 
            this.progKagit.Location = new System.Drawing.Point(15, 188);
            this.progKagit.Maximum = 1200;
            this.progKagit.Name = "progKagit";
            this.progKagit.Size = new System.Drawing.Size(178, 23);
            this.progKagit.TabIndex = 2;
            // 
            // lstKagitAtik
            // 
            this.lstKagitAtik.FormattingEnabled = true;
            this.lstKagitAtik.ItemHeight = 16;
            this.lstKagitAtik.Location = new System.Drawing.Point(15, 50);
            this.lstKagitAtik.Name = "lstKagitAtik";
            this.lstKagitAtik.Size = new System.Drawing.Size(178, 132);
            this.lstKagitAtik.TabIndex = 1;
            // 
            // grbCamAtik
            // 
            this.grbCamAtik.BackColor = System.Drawing.Color.Teal;
            this.grbCamAtik.Controls.Add(this.btnCamAtik);
            this.grbCamAtik.Controls.Add(this.btnCamBosalt);
            this.grbCamAtik.Controls.Add(this.progCam);
            this.grbCamAtik.Controls.Add(this.lstCamAtik);
            this.grbCamAtik.Location = new System.Drawing.Point(263, 321);
            this.grbCamAtik.Name = "grbCamAtik";
            this.grbCamAtik.Size = new System.Drawing.Size(208, 265);
            this.grbCamAtik.TabIndex = 5;
            this.grbCamAtik.TabStop = false;
            // 
            // btnCamAtik
            // 
            this.btnCamAtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCamAtik.Location = new System.Drawing.Point(12, 24);
            this.btnCamAtik.Name = "btnCamAtik";
            this.btnCamAtik.Size = new System.Drawing.Size(178, 29);
            this.btnCamAtik.TabIndex = 4;
            this.btnCamAtik.Text = "CAM ATIK";
            this.btnCamAtik.UseVisualStyleBackColor = true;
            this.btnCamAtik.Click += new System.EventHandler(this.btnCamAtik_Click);
            // 
            // btnCamBosalt
            // 
            this.btnCamBosalt.Location = new System.Drawing.Point(11, 220);
            this.btnCamBosalt.Name = "btnCamBosalt";
            this.btnCamBosalt.Size = new System.Drawing.Size(178, 31);
            this.btnCamBosalt.TabIndex = 3;
            this.btnCamBosalt.Text = "BOŞALT";
            this.btnCamBosalt.UseVisualStyleBackColor = true;
            this.btnCamBosalt.Click += new System.EventHandler(this.btnCamBosalt_Click);
            // 
            // progCam
            // 
            this.progCam.Location = new System.Drawing.Point(11, 191);
            this.progCam.Maximum = 2200;
            this.progCam.Name = "progCam";
            this.progCam.Size = new System.Drawing.Size(178, 23);
            this.progCam.TabIndex = 2;
            // 
            // lstCamAtik
            // 
            this.lstCamAtik.FormattingEnabled = true;
            this.lstCamAtik.ItemHeight = 16;
            this.lstCamAtik.Location = new System.Drawing.Point(12, 53);
            this.lstCamAtik.Name = "lstCamAtik";
            this.lstCamAtik.Size = new System.Drawing.Size(178, 132);
            this.lstCamAtik.TabIndex = 1;
            // 
            // grbMetalAtik
            // 
            this.grbMetalAtik.BackColor = System.Drawing.Color.Teal;
            this.grbMetalAtik.Controls.Add(this.btnMetalAtik);
            this.grbMetalAtik.Controls.Add(this.btnMetalBosalt);
            this.grbMetalAtik.Controls.Add(this.progMetal);
            this.grbMetalAtik.Controls.Add(this.lstMetalAtik);
            this.grbMetalAtik.Location = new System.Drawing.Point(488, 321);
            this.grbMetalAtik.Name = "grbMetalAtik";
            this.grbMetalAtik.Size = new System.Drawing.Size(208, 265);
            this.grbMetalAtik.TabIndex = 6;
            this.grbMetalAtik.TabStop = false;
            // 
            // btnMetalAtik
            // 
            this.btnMetalAtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetalAtik.Location = new System.Drawing.Point(15, 24);
            this.btnMetalAtik.Name = "btnMetalAtik";
            this.btnMetalAtik.Size = new System.Drawing.Size(178, 29);
            this.btnMetalAtik.TabIndex = 4;
            this.btnMetalAtik.Text = "METAL ATIK";
            this.btnMetalAtik.UseVisualStyleBackColor = true;
            this.btnMetalAtik.Click += new System.EventHandler(this.btnMetalAtik_Click);
            // 
            // btnMetalBosalt
            // 
            this.btnMetalBosalt.Location = new System.Drawing.Point(15, 220);
            this.btnMetalBosalt.Name = "btnMetalBosalt";
            this.btnMetalBosalt.Size = new System.Drawing.Size(178, 31);
            this.btnMetalBosalt.TabIndex = 3;
            this.btnMetalBosalt.Text = "BOŞALT";
            this.btnMetalBosalt.UseVisualStyleBackColor = true;
            this.btnMetalBosalt.Click += new System.EventHandler(this.btnMetalBosalt_Click);
            // 
            // progMetal
            // 
            this.progMetal.Location = new System.Drawing.Point(15, 191);
            this.progMetal.Maximum = 2300;
            this.progMetal.Name = "progMetal";
            this.progMetal.Size = new System.Drawing.Size(178, 23);
            this.progMetal.TabIndex = 2;
            // 
            // lstMetalAtik
            // 
            this.lstMetalAtik.FormattingEnabled = true;
            this.lstMetalAtik.ItemHeight = 16;
            this.lstMetalAtik.Location = new System.Drawing.Point(15, 53);
            this.lstMetalAtik.Name = "lstMetalAtik";
            this.lstMetalAtik.Size = new System.Drawing.Size(178, 132);
            this.lstMetalAtik.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(752, 607);
            this.Controls.Add(this.grbMetalAtik);
            this.Controls.Add(this.grbCamAtik);
            this.Controls.Add(this.grbKagitAtik);
            this.Controls.Add(this.grbOrnagikAtik);
            this.Controls.Add(this.lblAtik);
            this.Controls.Add(this.grbAnaMenu);
            this.Controls.Add(this.grbResim);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRstResim)).EndInit();
            this.grbAnaMenu.ResumeLayout(false);
            this.grbOrnagikAtik.ResumeLayout(false);
            this.grbKagitAtik.ResumeLayout(false);
            this.grbCamAtik.ResumeLayout(false);
            this.grbMetalAtik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbResim;
        private System.Windows.Forms.PictureBox ptbRstResim;
        private System.Windows.Forms.GroupBox grbAnaMenu;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAtik;
        private System.Windows.Forms.GroupBox grbOrnagikAtik;
        private System.Windows.Forms.GroupBox grbKagitAtik;
        private System.Windows.Forms.GroupBox grbCamAtik;
        private System.Windows.Forms.GroupBox grbMetalAtik;
        private System.Windows.Forms.Button btnOrganikBosalt;
        private System.Windows.Forms.ListBox lstOrganikAtik;
        private System.Windows.Forms.ProgressBar progOrnagik;
        private System.Windows.Forms.Button btnKagitBosalt;
        private System.Windows.Forms.ProgressBar progKagit;
        private System.Windows.Forms.ListBox lstKagitAtik;
        private System.Windows.Forms.ProgressBar progCam;
        private System.Windows.Forms.ListBox lstCamAtik;
        private System.Windows.Forms.Button btnCamBosalt;
        private System.Windows.Forms.ListBox lstMetalAtik;
        private System.Windows.Forms.ProgressBar progMetal;
        private System.Windows.Forms.Button btnMetalBosalt;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblPuanSayi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOrganikAtik;
        private System.Windows.Forms.Button btnKagitAtik;
        private System.Windows.Forms.Button btnCamAtik;
        private System.Windows.Forms.Button btnMetalAtik;
    }
}

