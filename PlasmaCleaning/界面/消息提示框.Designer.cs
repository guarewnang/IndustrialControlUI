namespace PlasmaCleaning.界面
{
    partial class 消息提示框
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(消息提示框));
            this.lb_message = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_message.Location = new System.Drawing.Point(58, 57);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(71, 16);
            this.lb_message.TabIndex = 2;
            this.lb_message.Text = "提示内容";
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(157, 151);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(93, 38);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // 消息提示框
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 256);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lb_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "消息提示框";
            this.Text = "注意!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.Button btn_OK;
    }
}