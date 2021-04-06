namespace LCUTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LCUTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoUpdate = new System.Windows.Forms.Timer(this.components);
            this.plMain = new ClassicDarkTheme.Dark.DarkPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimaze = new ClassicDarkTheme.Dark.DarkLabel();
            this.lblClose = new ClassicDarkTheme.Dark.DarkLabel();
            this.lblBlueEssence = new ClassicDarkTheme.Dark.DarkLabel();
            this.lblRP = new ClassicDarkTheme.Dark.DarkLabel();
            this.pbBlueEssence = new System.Windows.Forms.PictureBox();
            this.pbRP = new System.Windows.Forms.PictureBox();
            this.lblLevelText = new ClassicDarkTheme.Dark.DarkLabel();
            this.ChangeProfileIcon = new ClassicDarkTheme.Dark.DarkButton();
            this.tbProfileIcon = new AmongUsExternal.DarkTextbox();
            this.cbAutoAccept = new ClassicDarkTheme.Dark.DarkCheckbox();
            this.lblAutoAccept = new ClassicDarkTheme.Dark.DarkLabel();
            this.pbLevelProgress = new ClassicDarkTheme.Dark.DarkProgressbar();
            this.lblLevel = new ClassicDarkTheme.Dark.DarkLabel();
            this.lblName = new ClassicDarkTheme.Dark.DarkLabel();
            this.pbAvatar = new ClassicDarkTheme.Dark.DarkPicturebox();
            this.dcAvatarCircle = new ClassicDarkTheme.Dark.DarkCircle();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueEssence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // LCUTimer
            // 
            this.LCUTimer.Enabled = true;
            this.LCUTimer.Tick += new System.EventHandler(this.LCUTimer_Tick);
            // 
            // AutoUpdate
            // 
            this.AutoUpdate.Enabled = true;
            this.AutoUpdate.Interval = 5000;
            this.AutoUpdate.Tick += new System.EventHandler(this.AutoUpdate_Tick);
            // 
            // plMain
            // 
            this.plMain.AutoScroll = true;
            this.plMain.AutoSize = true;
            this.plMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plMain.BorderThickness = 3F;
            this.plMain.Controls.Add(this.label1);
            this.plMain.Controls.Add(this.lblMinimaze);
            this.plMain.Controls.Add(this.lblClose);
            this.plMain.Controls.Add(this.lblBlueEssence);
            this.plMain.Controls.Add(this.lblRP);
            this.plMain.Controls.Add(this.pbBlueEssence);
            this.plMain.Controls.Add(this.pbRP);
            this.plMain.Controls.Add(this.lblLevelText);
            this.plMain.Controls.Add(this.ChangeProfileIcon);
            this.plMain.Controls.Add(this.tbProfileIcon);
            this.plMain.Controls.Add(this.cbAutoAccept);
            this.plMain.Controls.Add(this.lblAutoAccept);
            this.plMain.Controls.Add(this.pbLevelProgress);
            this.plMain.Controls.Add(this.lblLevel);
            this.plMain.Controls.Add(this.lblName);
            this.plMain.Controls.Add(this.pbAvatar);
            this.plMain.Controls.Add(this.dcAvatarCircle);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.GradientValue = 90F;
            this.plMain.Location = new System.Drawing.Point(0, 0);
            this.plMain.Name = "plMain";
            this.plMain.PanelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.plMain.PanelBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.plMain.PanelTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.plMain.Size = new System.Drawing.Size(435, 202);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Stigma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMinimaze
            // 
            this.lblMinimaze.AutoSize = true;
            this.lblMinimaze.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimaze.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            this.lblMinimaze.ForeColor = System.Drawing.Color.White;
            this.lblMinimaze.IsLink = false;
            this.lblMinimaze.Link = "";
            this.lblMinimaze.Location = new System.Drawing.Point(377, 12);
            this.lblMinimaze.Name = "lblMinimaze";
            this.lblMinimaze.Size = new System.Drawing.Size(22, 15);
            this.lblMinimaze.TabIndex = 19;
            this.lblMinimaze.Text = "";
            this.lblMinimaze.Click += new System.EventHandler(this.lblMinimaze_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.IsLink = false;
            this.lblClose.Link = "";
            this.lblClose.Location = new System.Drawing.Point(405, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(22, 15);
            this.lblClose.TabIndex = 18;
            this.lblClose.Text = "";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblBlueEssence
            // 
            this.lblBlueEssence.AutoSize = true;
            this.lblBlueEssence.BackColor = System.Drawing.Color.Transparent;
            this.lblBlueEssence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblBlueEssence.ForeColor = System.Drawing.Color.White;
            this.lblBlueEssence.IsLink = false;
            this.lblBlueEssence.Link = "";
            this.lblBlueEssence.Location = new System.Drawing.Point(185, 117);
            this.lblBlueEssence.Name = "lblBlueEssence";
            this.lblBlueEssence.Size = new System.Drawing.Size(15, 16);
            this.lblBlueEssence.TabIndex = 17;
            this.lblBlueEssence.Text = "0";
            // 
            // lblRP
            // 
            this.lblRP.AutoSize = true;
            this.lblRP.BackColor = System.Drawing.Color.Transparent;
            this.lblRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblRP.ForeColor = System.Drawing.Color.White;
            this.lblRP.IsLink = false;
            this.lblRP.Link = "";
            this.lblRP.Location = new System.Drawing.Point(185, 83);
            this.lblRP.Name = "lblRP";
            this.lblRP.Size = new System.Drawing.Size(15, 16);
            this.lblRP.TabIndex = 16;
            this.lblRP.Text = "0";
            // 
            // pbBlueEssence
            // 
            this.pbBlueEssence.BackColor = System.Drawing.Color.Transparent;
            this.pbBlueEssence.Image = ((System.Drawing.Image)(resources.GetObject("pbBlueEssence.Image")));
            this.pbBlueEssence.Location = new System.Drawing.Point(147, 104);
            this.pbBlueEssence.Name = "pbBlueEssence";
            this.pbBlueEssence.Size = new System.Drawing.Size(32, 32);
            this.pbBlueEssence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlueEssence.TabIndex = 15;
            this.pbBlueEssence.TabStop = false;
            // 
            // pbRP
            // 
            this.pbRP.BackColor = System.Drawing.Color.Transparent;
            this.pbRP.Image = ((System.Drawing.Image)(resources.GetObject("pbRP.Image")));
            this.pbRP.Location = new System.Drawing.Point(147, 77);
            this.pbRP.Name = "pbRP";
            this.pbRP.Size = new System.Drawing.Size(32, 32);
            this.pbRP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRP.TabIndex = 14;
            this.pbRP.TabStop = false;
            // 
            // lblLevelText
            // 
            this.lblLevelText.AutoSize = true;
            this.lblLevelText.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLevelText.ForeColor = System.Drawing.Color.White;
            this.lblLevelText.IsLink = false;
            this.lblLevelText.Link = "";
            this.lblLevelText.Location = new System.Drawing.Point(12, 176);
            this.lblLevelText.Name = "lblLevelText";
            this.lblLevelText.Size = new System.Drawing.Size(54, 18);
            this.lblLevelText.TabIndex = 13;
            this.lblLevelText.Text = "Level : ";
            this.lblLevelText.Click += new System.EventHandler(this.lblLevelText_Click);
            // 
            // ChangeProfileIcon
            // 
            this.ChangeProfileIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ChangeProfileIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeProfileIcon.FlatAppearance.BorderSize = 0;
            this.ChangeProfileIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeProfileIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ChangeProfileIcon.ForeColor = System.Drawing.Color.White;
            this.ChangeProfileIcon.Location = new System.Drawing.Point(248, 167);
            this.ChangeProfileIcon.MouseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ChangeProfileIcon.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.ChangeProfileIcon.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ChangeProfileIcon.MouseLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.ChangeProfileIcon.MouseUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ChangeProfileIcon.Name = "ChangeProfileIcon";
            this.ChangeProfileIcon.Size = new System.Drawing.Size(134, 23);
            this.ChangeProfileIcon.TabIndex = 11;
            this.ChangeProfileIcon.Text = "Change Profile Icon";
            this.ChangeProfileIcon.UseVisualStyleBackColor = false;
            this.ChangeProfileIcon.Click += new System.EventHandler(this.ChangeProfileIcon_Click);
            // 
            // tbProfileIcon
            // 
            this.tbProfileIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.tbProfileIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.tbProfileIcon.ForeColor = System.Drawing.Color.White;
            this.tbProfileIcon.Location = new System.Drawing.Point(248, 141);
            this.tbProfileIcon.MaxLength = 32767;
            this.tbProfileIcon.Name = "tbProfileIcon";
            this.tbProfileIcon.OnlyNumbers = true;
            this.tbProfileIcon.Size = new System.Drawing.Size(134, 20);
            this.tbProfileIcon.TabIndex = 10;
            this.tbProfileIcon.TextStr = "";
            // 
            // cbAutoAccept
            // 
            this.cbAutoAccept.BackColor = System.Drawing.Color.Transparent;
            this.cbAutoAccept.BorderThickness = 3;
            this.cbAutoAccept.CheckboxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.cbAutoAccept.CheckboxBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.cbAutoAccept.CheckboxDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.cbAutoAccept.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbAutoAccept.CheckboxLeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.cbAutoAccept.CheckboxUpColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.cbAutoAccept.Checked = false;
            this.cbAutoAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAutoAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbAutoAccept.ForeColor = System.Drawing.Color.White;
            this.cbAutoAccept.Location = new System.Drawing.Point(144, 35);
            this.cbAutoAccept.Name = "cbAutoAccept";
            this.cbAutoAccept.Size = new System.Drawing.Size(25, 24);
            this.cbAutoAccept.TabIndex = 5;
            this.cbAutoAccept.Type = ClassicDarkTheme.Dark.DarkCheckbox.Types.Circle;
            this.cbAutoAccept.CheckedChanged += new System.EventHandler(this.cbAutoAccept_CheckedChanged);
            // 
            // lblAutoAccept
            // 
            this.lblAutoAccept.AutoSize = true;
            this.lblAutoAccept.BackColor = System.Drawing.Color.Transparent;
            this.lblAutoAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblAutoAccept.ForeColor = System.Drawing.Color.White;
            this.lblAutoAccept.IsLink = false;
            this.lblAutoAccept.Link = "";
            this.lblAutoAccept.Location = new System.Drawing.Point(172, 39);
            this.lblAutoAccept.Name = "lblAutoAccept";
            this.lblAutoAccept.Size = new System.Drawing.Size(80, 16);
            this.lblAutoAccept.TabIndex = 6;
            this.lblAutoAccept.Text = "Auto Accept";
            // 
            // pbLevelProgress
            // 
            this.pbLevelProgress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.pbLevelProgress.BorderThickness = 3F;
            this.pbLevelProgress.Location = new System.Drawing.Point(104, 176);
            this.pbLevelProgress.Name = "pbLevelProgress";
            this.pbLevelProgress.ProgressBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(39)))));
            this.pbLevelProgress.ProgressBarLeftProgressColor = System.Drawing.Color.Aqua;
            this.pbLevelProgress.ProgressBarRightProgressColor = System.Drawing.Color.Teal;
            this.pbLevelProgress.Size = new System.Drawing.Size(115, 23);
            this.pbLevelProgress.TabIndex = 4;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.IsLink = false;
            this.lblLevel.Link = "";
            this.lblLevel.Location = new System.Drawing.Point(135, 160);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(44, 16);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "0 (0/0)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.IsLink = false;
            this.lblName.Link = "";
            this.lblName.Location = new System.Drawing.Point(12, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbAvatar.Location = new System.Drawing.Point(20, 19);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Radius = 90;
            this.pbAvatar.Size = new System.Drawing.Size(90, 90);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            // 
            // dcAvatarCircle
            // 
            this.dcAvatarCircle.BackColor = System.Drawing.Color.Transparent;
            this.dcAvatarCircle.BorderThickness = 3F;
            this.dcAvatarCircle.CircleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(53)))));
            this.dcAvatarCircle.CircleBottomColor = System.Drawing.Color.Aqua;
            this.dcAvatarCircle.CircleTopColor = System.Drawing.Color.Teal;
            this.dcAvatarCircle.ForeColor = System.Drawing.Color.White;
            this.dcAvatarCircle.GradientValue = 90F;
            this.dcAvatarCircle.Location = new System.Drawing.Point(8, 6);
            this.dcAvatarCircle.Name = "dcAvatarCircle";
            this.dcAvatarCircle.Size = new System.Drawing.Size(115, 118);
            this.dcAvatarCircle.TabIndex = 0;
            this.dcAvatarCircle.Text = "darkCircle1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(435, 202);
            this.Controls.Add(this.plMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adsız - Not Defteri";
            this.TransparencyKey = System.Drawing.Color.Bisque;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.plMain.ResumeLayout(false);
            this.plMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueEssence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassicDarkTheme.Dark.DarkPanel plMain;
        private ClassicDarkTheme.Dark.DarkCircle dcAvatarCircle;
        private ClassicDarkTheme.Dark.DarkProgressbar pbLevelProgress;
        private ClassicDarkTheme.Dark.DarkLabel lblLevel;
        private ClassicDarkTheme.Dark.DarkLabel lblName;
        private ClassicDarkTheme.Dark.DarkPicturebox pbAvatar;
        private ClassicDarkTheme.Dark.DarkCheckbox cbAutoAccept;
        private ClassicDarkTheme.Dark.DarkLabel lblAutoAccept;
        private ClassicDarkTheme.Dark.DarkButton ChangeProfileIcon;
        private AmongUsExternal.DarkTextbox tbProfileIcon;
        private ClassicDarkTheme.Dark.DarkLabel lblLevelText;
        private ClassicDarkTheme.Dark.DarkLabel lblBlueEssence;
        private ClassicDarkTheme.Dark.DarkLabel lblRP;
        private System.Windows.Forms.PictureBox pbBlueEssence;
        private System.Windows.Forms.PictureBox pbRP;
        private System.Windows.Forms.Timer LCUTimer;
        private System.Windows.Forms.Timer AutoUpdate;
        private ClassicDarkTheme.Dark.DarkLabel lblMinimaze;
        private ClassicDarkTheme.Dark.DarkLabel lblClose;
        private System.Windows.Forms.Label label1;
    }
}

