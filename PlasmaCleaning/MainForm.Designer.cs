namespace PlasmaCleaning
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pal_interfaceBtn = new System.Windows.Forms.Panel();
            this.btn_aboutInterface = new System.Windows.Forms.Button();
            this.btn_dataMonitoringInterface = new System.Windows.Forms.Button();
            this.btn_communicationSettingInterface = new System.Windows.Forms.Button();
            this.btn_recipeManagementInterface = new System.Windows.Forms.Button();
            this.btn_alarmListInterface = new System.Windows.Forms.Button();
            this.btn_manualOperationInterface = new System.Windows.Forms.Button();
            this.btn_userManagementInterface = new System.Windows.Forms.Button();
            this.btn_automaticOperationInterface = new System.Windows.Forms.Button();
            this.btn_systemSettingInterface = new System.Windows.Forms.Button();
            this.btn_homePageInterface = new System.Windows.Forms.Button();
            this.pal_picBar = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pal_form = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_currentUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_currentUserLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_alarm = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_alarmLed = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_nowTime = new System.Windows.Forms.Label();
            this.t_update = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.pal_interfaceBtn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pal_interfaceBtn
            // 
            this.pal_interfaceBtn.Controls.Add(this.btn_aboutInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_dataMonitoringInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_communicationSettingInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_recipeManagementInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_alarmListInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_manualOperationInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_userManagementInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_automaticOperationInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_systemSettingInterface);
            this.pal_interfaceBtn.Controls.Add(this.btn_homePageInterface);
            this.pal_interfaceBtn.Controls.Add(this.pal_picBar);
            this.pal_interfaceBtn.Location = new System.Drawing.Point(0, 80);
            this.pal_interfaceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pal_interfaceBtn.Name = "pal_interfaceBtn";
            this.pal_interfaceBtn.Size = new System.Drawing.Size(150, 660);
            this.pal_interfaceBtn.TabIndex = 0;
            // 
            // btn_aboutInterface
            // 
            this.btn_aboutInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.关于;
            this.btn_aboutInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_aboutInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aboutInterface.Location = new System.Drawing.Point(10, 360);
            this.btn_aboutInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_aboutInterface.Name = "btn_aboutInterface";
            this.btn_aboutInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_aboutInterface.TabIndex = 19;
            this.btn_aboutInterface.Text = "    关于";
            this.btn_aboutInterface.UseVisualStyleBackColor = true;
            this.btn_aboutInterface.Click += new System.EventHandler(this.btn_aboutInterface_Click);
            // 
            // btn_dataMonitoringInterface
            // 
            this.btn_dataMonitoringInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.监控;
            this.btn_dataMonitoringInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_dataMonitoringInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dataMonitoringInterface.Location = new System.Drawing.Point(10, 160);
            this.btn_dataMonitoringInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dataMonitoringInterface.Name = "btn_dataMonitoringInterface";
            this.btn_dataMonitoringInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_dataMonitoringInterface.TabIndex = 14;
            this.btn_dataMonitoringInterface.Text = "    数据查询";
            this.btn_dataMonitoringInterface.UseVisualStyleBackColor = true;
            this.btn_dataMonitoringInterface.Click += new System.EventHandler(this.btn_dataMonitoringInterface_Click);
            // 
            // btn_communicationSettingInterface
            // 
            this.btn_communicationSettingInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.网络自动化;
            this.btn_communicationSettingInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_communicationSettingInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_communicationSettingInterface.Location = new System.Drawing.Point(10, 320);
            this.btn_communicationSettingInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_communicationSettingInterface.Name = "btn_communicationSettingInterface";
            this.btn_communicationSettingInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_communicationSettingInterface.TabIndex = 18;
            this.btn_communicationSettingInterface.Text = "    通讯设置";
            this.btn_communicationSettingInterface.UseVisualStyleBackColor = true;
            this.btn_communicationSettingInterface.Click += new System.EventHandler(this.btn_communicationSettingInterface_Click);
            // 
            // btn_recipeManagementInterface
            // 
            this.btn_recipeManagementInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.配方方案;
            this.btn_recipeManagementInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_recipeManagementInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recipeManagementInterface.Location = new System.Drawing.Point(10, 120);
            this.btn_recipeManagementInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_recipeManagementInterface.Name = "btn_recipeManagementInterface";
            this.btn_recipeManagementInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_recipeManagementInterface.TabIndex = 13;
            this.btn_recipeManagementInterface.Text = "    配方管理";
            this.btn_recipeManagementInterface.UseVisualStyleBackColor = true;
            this.btn_recipeManagementInterface.Click += new System.EventHandler(this.btn_recipeManagementInterface_Click);
            // 
            // btn_alarmListInterface
            // 
            this.btn_alarmListInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.报警列表;
            this.btn_alarmListInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_alarmListInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alarmListInterface.Location = new System.Drawing.Point(10, 280);
            this.btn_alarmListInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_alarmListInterface.Name = "btn_alarmListInterface";
            this.btn_alarmListInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_alarmListInterface.TabIndex = 17;
            this.btn_alarmListInterface.Text = "    报警列表";
            this.btn_alarmListInterface.UseVisualStyleBackColor = true;
            this.btn_alarmListInterface.Click += new System.EventHandler(this.btn_alarmListInterface_Click);
            // 
            // btn_manualOperationInterface
            // 
            this.btn_manualOperationInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.手动同步;
            this.btn_manualOperationInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_manualOperationInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manualOperationInterface.Location = new System.Drawing.Point(10, 80);
            this.btn_manualOperationInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_manualOperationInterface.Name = "btn_manualOperationInterface";
            this.btn_manualOperationInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_manualOperationInterface.TabIndex = 12;
            this.btn_manualOperationInterface.Text = "    手动操作";
            this.btn_manualOperationInterface.UseVisualStyleBackColor = true;
            this.btn_manualOperationInterface.Click += new System.EventHandler(this.btn_manualOperationInterface_Click);
            // 
            // btn_userManagementInterface
            // 
            this.btn_userManagementInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.用户;
            this.btn_userManagementInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_userManagementInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userManagementInterface.Location = new System.Drawing.Point(10, 240);
            this.btn_userManagementInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_userManagementInterface.Name = "btn_userManagementInterface";
            this.btn_userManagementInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_userManagementInterface.TabIndex = 16;
            this.btn_userManagementInterface.Text = "    用户管理";
            this.btn_userManagementInterface.UseVisualStyleBackColor = true;
            this.btn_userManagementInterface.Click += new System.EventHandler(this.btn_userManagementInterface_Click);
            // 
            // btn_automaticOperationInterface
            // 
            this.btn_automaticOperationInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.自动;
            this.btn_automaticOperationInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_automaticOperationInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_automaticOperationInterface.Location = new System.Drawing.Point(10, 40);
            this.btn_automaticOperationInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_automaticOperationInterface.Name = "btn_automaticOperationInterface";
            this.btn_automaticOperationInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_automaticOperationInterface.TabIndex = 11;
            this.btn_automaticOperationInterface.Text = "    自动操作";
            this.btn_automaticOperationInterface.UseVisualStyleBackColor = true;
            this.btn_automaticOperationInterface.Click += new System.EventHandler(this.btn_automaticOperationInterface_Click);
            // 
            // btn_systemSettingInterface
            // 
            this.btn_systemSettingInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.系统;
            this.btn_systemSettingInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_systemSettingInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_systemSettingInterface.Location = new System.Drawing.Point(10, 200);
            this.btn_systemSettingInterface.Margin = new System.Windows.Forms.Padding(0);
            this.btn_systemSettingInterface.Name = "btn_systemSettingInterface";
            this.btn_systemSettingInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_systemSettingInterface.TabIndex = 15;
            this.btn_systemSettingInterface.Text = "    系统设置";
            this.btn_systemSettingInterface.UseVisualStyleBackColor = true;
            this.btn_systemSettingInterface.Click += new System.EventHandler(this.btn_systemSettingInterface_Click);
            // 
            // btn_homePageInterface
            // 
            this.btn_homePageInterface.BackgroundImage = global::PlasmaCleaning.Properties.Resources.主页;
            this.btn_homePageInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_homePageInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_homePageInterface.Location = new System.Drawing.Point(10, 0);
            this.btn_homePageInterface.Name = "btn_homePageInterface";
            this.btn_homePageInterface.Size = new System.Drawing.Size(140, 40);
            this.btn_homePageInterface.TabIndex = 9;
            this.btn_homePageInterface.Text = "    主页";
            this.btn_homePageInterface.UseVisualStyleBackColor = true;
            this.btn_homePageInterface.Click += new System.EventHandler(this.btn_homePageInterface_Click);
            // 
            // pal_picBar
            // 
            this.pal_picBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pal_picBar.Location = new System.Drawing.Point(0, 0);
            this.pal_picBar.Name = "pal_picBar";
            this.pal_picBar.Size = new System.Drawing.Size(10, 40);
            this.pal_picBar.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "报警列表.png");
            this.imageList1.Images.SetKeyName(1, "关于.png");
            this.imageList1.Images.SetKeyName(2, "配方方案.png");
            this.imageList1.Images.SetKeyName(3, "网络自动化.png");
            this.imageList1.Images.SetKeyName(4, "系统.png");
            this.imageList1.Images.SetKeyName(5, "用户.png");
            this.imageList1.Images.SetKeyName(6, "主页.png");
            this.imageList1.Images.SetKeyName(7, "自动.png");
            // 
            // pal_form
            // 
            this.pal_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pal_form.Location = new System.Drawing.Point(150, 80);
            this.pal_form.Margin = new System.Windows.Forms.Padding(0);
            this.pal_form.Name = "pal_form";
            this.pal_form.Size = new System.Drawing.Size(1300, 660);
            this.pal_form.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 40);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_currentUserName,
            this.toolStripStatusLabel3,
            this.tssl_currentUserLevel,
            this.tssl_alarm,
            this.tssl_alarmLed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 14);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1300, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 21);
            this.toolStripStatusLabel1.Text = "当前登录用户:";
            // 
            // tssl_currentUserName
            // 
            this.tssl_currentUserName.Name = "tssl_currentUserName";
            this.tssl_currentUserName.Size = new System.Drawing.Size(171, 21);
            this.tssl_currentUserName.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(46, 21);
            this.toolStripStatusLabel3.Text = "权限:";
            // 
            // tssl_currentUserLevel
            // 
            this.tssl_currentUserLevel.Name = "tssl_currentUserLevel";
            this.tssl_currentUserLevel.Size = new System.Drawing.Size(171, 21);
            this.tssl_currentUserLevel.Text = "toolStripStatusLabel4";
            // 
            // tssl_alarm
            // 
            this.tssl_alarm.ForeColor = System.Drawing.Color.Red;
            this.tssl_alarm.Name = "tssl_alarm";
            this.tssl_alarm.Size = new System.Drawing.Size(84, 21);
            this.tssl_alarm.Text = "tssl_alarm";
            this.tssl_alarm.Click += new System.EventHandler(this.tssl_alarm_Click);
            // 
            // tssl_alarmLed
            // 
            this.tssl_alarmLed.Image = global::PlasmaCleaning.Properties.Resources.报警灯___副本__3_;
            this.tssl_alarmLed.Name = "tssl_alarmLed";
            this.tssl_alarmLed.Size = new System.Drawing.Size(20, 21);
            // 
            // lb_nowTime
            // 
            this.lb_nowTime.AutoSize = true;
            this.lb_nowTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_nowTime.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_nowTime.Location = new System.Drawing.Point(820, 34);
            this.lb_nowTime.Name = "lb_nowTime";
            this.lb_nowTime.Size = new System.Drawing.Size(361, 31);
            this.lb_nowTime.TabIndex = 8;
            this.lb_nowTime.Text = "2022年5月5日  10:57:30";
            this.lb_nowTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t_update
            // 
            this.t_update.Tick += new System.EventHandler(this.t_update_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlasmaCleaning.Properties.Resources.煤矿企业__1_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 59);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 749);
            this.Controls.Add(this.lb_nowTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pal_form);
            this.Controls.Add(this.pal_interfaceBtn);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "               XXXxxx机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pal_interfaceBtn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pal_interfaceBtn;
        private System.Windows.Forms.Panel pal_picBar;
        private System.Windows.Forms.Panel pal_form;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Label lb_nowTime;
        private System.Windows.Forms.ToolStripStatusLabel tssl_alarm;
        private System.Windows.Forms.ToolStripStatusLabel tssl_alarmLed;
        public System.Windows.Forms.Timer t_update;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_currentUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssl_currentUserLevel;
        private System.Windows.Forms.Button btn_homePageInterface;
        private System.Windows.Forms.Button btn_automaticOperationInterface;
        private System.Windows.Forms.Button btn_aboutInterface;
        private System.Windows.Forms.Button btn_dataMonitoringInterface;
        private System.Windows.Forms.Button btn_communicationSettingInterface;
        private System.Windows.Forms.Button btn_recipeManagementInterface;
        private System.Windows.Forms.Button btn_alarmListInterface;
        private System.Windows.Forms.Button btn_manualOperationInterface;
        private System.Windows.Forms.Button btn_userManagementInterface;
        private System.Windows.Forms.Button btn_systemSettingInterface;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}