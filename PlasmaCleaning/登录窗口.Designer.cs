namespace PlasmaCleaning.界面
{
    partial class 登录窗口
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录窗口));
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_userpassword = new System.Windows.Forms.Label();
            this.comB_userName = new System.Windows.Forms.ComboBox();
            this.txt_passWrod = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_username.Location = new System.Drawing.Point(137, 87);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(67, 16);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "用户名:";
            // 
            // lb_userpassword
            // 
            this.lb_userpassword.AutoSize = true;
            this.lb_userpassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_userpassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_userpassword.Location = new System.Drawing.Point(137, 132);
            this.lb_userpassword.Name = "lb_userpassword";
            this.lb_userpassword.Size = new System.Drawing.Size(68, 16);
            this.lb_userpassword.TabIndex = 1;
            this.lb_userpassword.Text = "密  码:";
            // 
            // comB_userName
            // 
            this.comB_userName.FormattingEnabled = true;
            this.comB_userName.Location = new System.Drawing.Point(217, 83);
            this.comB_userName.Name = "comB_userName";
            this.comB_userName.Size = new System.Drawing.Size(121, 24);
            this.comB_userName.TabIndex = 2;
            // 
            // txt_passWrod
            // 
            this.txt_passWrod.Location = new System.Drawing.Point(217, 127);
            this.txt_passWrod.Name = "txt_passWrod";
            this.txt_passWrod.PasswordChar = '*';
            this.txt_passWrod.Size = new System.Drawing.Size(121, 26);
            this.txt_passWrod.TabIndex = 3;
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_register.Location = new System.Drawing.Point(130, 177);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 32);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "登录";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.Location = new System.Drawing.Point(305, 177);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 32);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // 登录窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlasmaCleaning.Properties.Resources.无标题;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 238);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_passWrod);
            this.Controls.Add(this.comB_userName);
            this.Controls.Add(this.lb_userpassword);
            this.Controls.Add(this.lb_username);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "登录窗口";
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.登录窗口_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_userpassword;
        private System.Windows.Forms.ComboBox comB_userName;
        private System.Windows.Forms.TextBox txt_passWrod;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_exit;
    }
}