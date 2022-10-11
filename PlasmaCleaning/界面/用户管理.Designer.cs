namespace PlasmaCleaning.界面
{
    partial class 用户管理
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
            this.Tp_UserManager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Manager = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.comb_level = new System.Windows.Forms.ComboBox();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_changeUser = new System.Windows.Forms.Button();
            this.btn_switchUser = new System.Windows.Forms.Button();
            this.Tp_UserManager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // Tp_UserManager
            // 
            this.Tp_UserManager.Controls.Add(this.tabPage1);
            this.Tp_UserManager.Location = new System.Drawing.Point(33, 33);
            this.Tp_UserManager.Name = "Tp_UserManager";
            this.Tp_UserManager.SelectedIndex = 0;
            this.Tp_UserManager.Size = new System.Drawing.Size(1085, 607);
            this.Tp_UserManager.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_switchUser);
            this.tabPage1.Controls.Add(this.btn_changeUser);
            this.tabPage1.Controls.Add(this.btn_deleteUser);
            this.tabPage1.Controls.Add(this.btn_addUser);
            this.tabPage1.Controls.Add(this.comb_level);
            this.tabPage1.Controls.Add(this.txt_passWord);
            this.tabPage1.Controls.Add(this.txt_userName);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_Manager);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1077, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "用户管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Manager
            // 
            this.dgv_Manager.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Manager.Location = new System.Drawing.Point(32, 16);
            this.dgv_Manager.Name = "dgv_Manager";
            this.dgv_Manager.ReadOnly = true;
            this.dgv_Manager.RowHeadersWidth = 51;
            this.dgv_Manager.RowTemplate.Height = 27;
            this.dgv_Manager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Manager.Size = new System.Drawing.Size(477, 531);
            this.dgv_Manager.TabIndex = 2;
            this.dgv_Manager.SelectionChanged += new System.EventHandler(this.dgv_Manager_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "1 权限越高，权限等级数越小";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "4 修改正在登陆用户需重新登录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "3 只能修改自身或低于自身权限的用户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "2 只能增加或删除低于自身权限的用户";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(596, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "说明：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(617, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "用户名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "密  码：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "权  限：";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(711, 41);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(222, 26);
            this.txt_userName.TabIndex = 30;
            // 
            // txt_passWord
            // 
            this.txt_passWord.Location = new System.Drawing.Point(711, 107);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.Size = new System.Drawing.Size(222, 26);
            this.txt_passWord.TabIndex = 31;
            // 
            // comb_level
            // 
            this.comb_level.FormattingEnabled = true;
            this.comb_level.Items.AddRange(new object[] {
            "工程师",
            "管理员",
            "操作员"});
            this.comb_level.Location = new System.Drawing.Point(711, 173);
            this.comb_level.Name = "comb_level";
            this.comb_level.Size = new System.Drawing.Size(222, 24);
            this.comb_level.TabIndex = 32;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addUser.Location = new System.Drawing.Point(533, 250);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(98, 34);
            this.btn_addUser.TabIndex = 33;
            this.btn_addUser.Text = "添加";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_deleteUser.Location = new System.Drawing.Point(673, 250);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(98, 34);
            this.btn_deleteUser.TabIndex = 34;
            this.btn_deleteUser.Text = "删除";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_changeUser
            // 
            this.btn_changeUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_changeUser.Location = new System.Drawing.Point(813, 250);
            this.btn_changeUser.Name = "btn_changeUser";
            this.btn_changeUser.Size = new System.Drawing.Size(98, 34);
            this.btn_changeUser.TabIndex = 35;
            this.btn_changeUser.Text = "修改";
            this.btn_changeUser.UseVisualStyleBackColor = true;
            this.btn_changeUser.Click += new System.EventHandler(this.btn_changeUser_Click);
            // 
            // btn_switchUser
            // 
            this.btn_switchUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_switchUser.Location = new System.Drawing.Point(953, 250);
            this.btn_switchUser.Name = "btn_switchUser";
            this.btn_switchUser.Size = new System.Drawing.Size(98, 34);
            this.btn_switchUser.TabIndex = 36;
            this.btn_switchUser.Text = "切换用户";
            this.btn_switchUser.UseVisualStyleBackColor = true;
            this.btn_switchUser.Click += new System.EventHandler(this.btn_switchUser_Click);
            // 
            // 用户管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 673);
            this.Controls.Add(this.Tp_UserManager);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "用户管理";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.用户管理_Load);
            this.Tp_UserManager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tp_UserManager;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Manager;
        private System.Windows.Forms.Button btn_switchUser;
        private System.Windows.Forms.Button btn_changeUser;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.ComboBox comb_level;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.TextBox txt_userName;
    }
}