namespace PlasmaCleaning.界面
{
    partial class 报警提示框
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_alarmInfo = new System.Windows.Forms.TextBox();
            this.txb_sln = new System.Windows.Forms.TextBox();
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_true = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "报警信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "解决办法：";
            // 
            // txb_alarmInfo
            // 
            this.txb_alarmInfo.Location = new System.Drawing.Point(123, 59);
            this.txb_alarmInfo.Name = "txb_alarmInfo";
            this.txb_alarmInfo.Size = new System.Drawing.Size(326, 26);
            this.txb_alarmInfo.TabIndex = 9;
            // 
            // txb_sln
            // 
            this.txb_sln.Location = new System.Drawing.Point(123, 104);
            this.txb_sln.Multiline = true;
            this.txb_sln.Name = "txb_sln";
            this.txb_sln.Size = new System.Drawing.Size(326, 123);
            this.txb_sln.TabIndex = 10;
            // 
            // btn_yes
            // 
            this.btn_yes.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_yes.Location = new System.Drawing.Point(155, 255);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(53, 33);
            this.btn_yes.TabIndex = 11;
            this.btn_yes.Text = "是";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_no
            // 
            this.btn_no.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_no.Location = new System.Drawing.Point(384, 255);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(53, 33);
            this.btn_no.TabIndex = 12;
            this.btn_no.Text = "否";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_true
            // 
            this.btn_true.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_true.Location = new System.Drawing.Point(257, 255);
            this.btn_true.Name = "btn_true";
            this.btn_true.Size = new System.Drawing.Size(84, 33);
            this.btn_true.TabIndex = 13;
            this.btn_true.Text = "确定";
            this.btn_true.UseVisualStyleBackColor = true;
            this.btn_true.Click += new System.EventHandler(this.btn_true_Click);
            // 
            // 报警提示框
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 339);
            this.Controls.Add(this.btn_true);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.txb_sln);
            this.Controls.Add(this.txb_alarmInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "报警提示框";
            this.Padding = new System.Windows.Forms.Padding(27, 80, 27, 27);
            this.Text = "报警确认";
            this.Load += new System.EventHandler(this.报警提示框_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_alarmInfo;
        private System.Windows.Forms.TextBox txb_sln;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_true;
    }
}