namespace PlasmaCleaning.界面
{
    partial class 报警列表
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
            this.dgv_AlarmLog = new System.Windows.Forms.DataGridView();
            this.lv_listAlarm = new System.Windows.Forms.ListBox();
            this.ctr_deleteAlarmLogs = new PlasmaCleaning.自定义.控件.批量删除数据库数据();
            this.bt_clearAllAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlarmLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AlarmLog
            // 
            this.dgv_AlarmLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_AlarmLog.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_AlarmLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AlarmLog.Location = new System.Drawing.Point(524, 91);
            this.dgv_AlarmLog.Name = "dgv_AlarmLog";
            this.dgv_AlarmLog.RowTemplate.Height = 23;
            this.dgv_AlarmLog.Size = new System.Drawing.Size(568, 463);
            this.dgv_AlarmLog.TabIndex = 5;
            // 
            // lv_listAlarm
            // 
            this.lv_listAlarm.FormattingEnabled = true;
            this.lv_listAlarm.ItemHeight = 16;
            this.lv_listAlarm.Location = new System.Drawing.Point(61, 91);
            this.lv_listAlarm.Name = "lv_listAlarm";
            this.lv_listAlarm.Size = new System.Drawing.Size(387, 452);
            this.lv_listAlarm.TabIndex = 7;
            this.lv_listAlarm.Click += new System.EventHandler(this.lv_listAlarm_Click);
            // 
            // ctr_deleteAlarmLogs
            // 
            this.ctr_deleteAlarmLogs.Location = new System.Drawing.Point(521, 577);
            this.ctr_deleteAlarmLogs.Margin = new System.Windows.Forms.Padding(4);
            this.ctr_deleteAlarmLogs.Name = "ctr_deleteAlarmLogs";
            this.ctr_deleteAlarmLogs.Size = new System.Drawing.Size(616, 83);
            this.ctr_deleteAlarmLogs.SQLBLL = PlasmaCleaning.自定义.控件.批量删除数据库数据.MYBLL.AlarmLogBLL;
            this.ctr_deleteAlarmLogs.Str_TbName = "ModelAlarmLogs";
            this.ctr_deleteAlarmLogs.Str_TimeName = "AlarmLogTime";
            this.ctr_deleteAlarmLogs.TabIndex = 6;
            // 
            // bt_clearAllAlarm
            // 
            this.bt_clearAllAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_clearAllAlarm.Location = new System.Drawing.Point(65, 591);
            this.bt_clearAllAlarm.Name = "bt_clearAllAlarm";
            this.bt_clearAllAlarm.Size = new System.Drawing.Size(128, 34);
            this.bt_clearAllAlarm.TabIndex = 8;
            this.bt_clearAllAlarm.Text = "清除所有报警";
            this.bt_clearAllAlarm.UseVisualStyleBackColor = true;
            this.bt_clearAllAlarm.Click += new System.EventHandler(this.bt_clearAllAlarm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "当前报警列表";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "报警记录";
            // 
            // 报警列表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_clearAllAlarm);
            this.Controls.Add(this.lv_listAlarm);
            this.Controls.Add(this.ctr_deleteAlarmLogs);
            this.Controls.Add(this.dgv_AlarmLog);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "报警列表";
            this.Text = "报警列表";
            this.Load += new System.EventHandler(this.报警列表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlarmLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox lv_listAlarm;
        public 自定义.控件.批量删除数据库数据 ctr_deleteAlarmLogs;
        public System.Windows.Forms.DataGridView dgv_AlarmLog;
        private System.Windows.Forms.Button bt_clearAllAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}