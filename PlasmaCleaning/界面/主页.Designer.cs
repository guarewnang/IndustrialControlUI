namespace PlasmaCleaning.界面
{
    partial class 主页
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
            this.t_UpdateState = new System.Windows.Forms.Timer(this.components);
            this.dgv_scanProductInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_scanQRCode = new System.Windows.Forms.TextBox();
            this.btn_findProductInfoByIdentifier = new System.Windows.Forms.Button();
            this.btn_changeUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.leD灯1 = new PlasmaCleaning.自定义.控件.LED灯();
            this.通用参数设置3 = new PlasmaCleaning.自定义.控件.通用参数设置();
            this.通用参数设置2 = new PlasmaCleaning.自定义.控件.通用参数设置();
            this.通用参数设置1 = new PlasmaCleaning.自定义.控件.通用参数设置();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_scanProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // t_UpdateState
            // 
            this.t_UpdateState.Tick += new System.EventHandler(this.t_UpdateState_Tick);
            // 
            // dgv_scanProductInfo
            // 
            this.dgv_scanProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_scanProductInfo.Location = new System.Drawing.Point(383, 21);
            this.dgv_scanProductInfo.Name = "dgv_scanProductInfo";
            this.dgv_scanProductInfo.RowTemplate.Height = 23;
            this.dgv_scanProductInfo.Size = new System.Drawing.Size(689, 466);
            this.dgv_scanProductInfo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "扫码编号：";
            // 
            // tbox_scanQRCode
            // 
            this.tbox_scanQRCode.Location = new System.Drawing.Point(174, 23);
            this.tbox_scanQRCode.Name = "tbox_scanQRCode";
            this.tbox_scanQRCode.Size = new System.Drawing.Size(114, 26);
            this.tbox_scanQRCode.TabIndex = 17;
            // 
            // btn_findProductInfoByIdentifier
            // 
            this.btn_findProductInfoByIdentifier.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_findProductInfoByIdentifier.Location = new System.Drawing.Point(174, 81);
            this.btn_findProductInfoByIdentifier.Name = "btn_findProductInfoByIdentifier";
            this.btn_findProductInfoByIdentifier.Size = new System.Drawing.Size(130, 42);
            this.btn_findProductInfoByIdentifier.TabIndex = 18;
            this.btn_findProductInfoByIdentifier.Text = "根据编号查询";
            this.btn_findProductInfoByIdentifier.UseVisualStyleBackColor = true;
            this.btn_findProductInfoByIdentifier.Click += new System.EventHandler(this.btn_findProductInfoByIdentifier_Click);
            // 
            // btn_changeUser
            // 
            this.btn_changeUser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_changeUser.Location = new System.Drawing.Point(174, 144);
            this.btn_changeUser.Name = "btn_changeUser";
            this.btn_changeUser.Size = new System.Drawing.Size(130, 42);
            this.btn_changeUser.TabIndex = 19;
            this.btn_changeUser.Text = "切换用户查验";
            this.btn_changeUser.UseVisualStyleBackColor = true;
            this.btn_changeUser.Click += new System.EventHandler(this.btn_changeUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "PLC测试框体1整数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "PLC测试框体2负数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "PLC测试框体小数";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // leD灯1
            // 
            this.leD灯1.Address = "V100.1";
            this.leD灯1.BorderColor = System.Drawing.Color.White;
            this.leD灯1.BorderWidth = 4;
            this.leD灯1.CenterColor = System.Drawing.Color.White;
            this.leD灯1.FlashInterval = 500;
            this.leD灯1.GapWidth = 2;
            this.leD灯1.IsBorder = true;
            this.leD灯1.IsFlash = false;
            this.leD灯1.IsHighLight = true;
            this.leD灯1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.Green,
        System.Drawing.Color.Yellow};
            this.leD灯1.LEDColor = System.Drawing.Color.Green;
            this.leD灯1.LedFalseColor = System.Drawing.Color.Red;
            this.leD灯1.LedStatus = true;
            this.leD灯1.LedTrueColor = System.Drawing.Color.Green;
            this.leD灯1.Location = new System.Drawing.Point(305, 191);
            this.leD灯1.Margin = new System.Windows.Forms.Padding(4);
            this.leD灯1.Name = "leD灯1";
            this.leD灯1.Size = new System.Drawing.Size(53, 47);
            this.leD灯1.TabIndex = 15;
            // 
            // 通用参数设置3
            // 
            this.通用参数设置3.Location = new System.Drawing.Point(191, 429);
            this.通用参数设置3.Margin = new System.Windows.Forms.Padding(7);
            this.通用参数设置3.Name = "通用参数设置3";
            this.通用参数设置3.Size = new System.Drawing.Size(167, 27);
            this.通用参数设置3.TabIndex = 6;
            this.通用参数设置3.可以下传 = true;
            this.通用参数设置3.可以输入 = true;
            this.通用参数设置3.有小数点 = true;
            this.通用参数设置3.有负数 = true;
            this.通用参数设置3.读取地址 = "VD204";
            // 
            // 通用参数设置2
            // 
            this.通用参数设置2.Location = new System.Drawing.Point(191, 388);
            this.通用参数设置2.Margin = new System.Windows.Forms.Padding(5);
            this.通用参数设置2.Name = "通用参数设置2";
            this.通用参数设置2.Size = new System.Drawing.Size(167, 25);
            this.通用参数设置2.TabIndex = 4;
            this.通用参数设置2.可以下传 = true;
            this.通用参数设置2.可以输入 = true;
            this.通用参数设置2.有小数点 = false;
            this.通用参数设置2.有负数 = true;
            this.通用参数设置2.读取地址 = "VD208";
            // 
            // 通用参数设置1
            // 
            this.通用参数设置1.Location = new System.Drawing.Point(191, 346);
            this.通用参数设置1.Margin = new System.Windows.Forms.Padding(4);
            this.通用参数设置1.Name = "通用参数设置1";
            this.通用参数设置1.Size = new System.Drawing.Size(167, 26);
            this.通用参数设置1.TabIndex = 1;
            this.通用参数设置1.可以下传 = true;
            this.通用参数设置1.可以输入 = true;
            this.通用参数设置1.有小数点 = false;
            this.通用参数设置1.有负数 = false;
            this.通用参数设置1.读取地址 = "VD200";
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
            // 主页
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 673);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_changeUser);
            this.Controls.Add(this.btn_findProductInfoByIdentifier);
            this.Controls.Add(this.tbox_scanQRCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leD灯1);
            this.Controls.Add(this.dgv_scanProductInfo);
            this.Controls.Add(this.通用参数设置3);
            this.Controls.Add(this.通用参数设置2);
            this.Controls.Add(this.通用参数设置1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "主页";
            this.Text = "主页";
            this.Load += new System.EventHandler(this.主页_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_scanProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private 自定义.控件.通用参数设置 通用参数设置1;
        private 自定义.控件.通用参数设置 通用参数设置2;
        private 自定义.控件.通用参数设置 通用参数设置3;
        public System.Windows.Forms.Timer t_UpdateState;
        private System.Windows.Forms.DataGridView dgv_scanProductInfo;
        private 自定义.控件.LED灯 leD灯1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_scanQRCode;
        private System.Windows.Forms.Button btn_findProductInfoByIdentifier;
        private System.Windows.Forms.Button btn_changeUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}