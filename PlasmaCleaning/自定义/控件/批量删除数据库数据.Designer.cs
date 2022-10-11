namespace PlasmaCleaning.自定义.控件
{
    partial class 批量删除数据库数据
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comb_timeUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ALLdel = new System.Windows.Forms.Button();
            this.nudown_timeValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_timeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comb_timeUnit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ALLdel);
            this.groupBox1.Controls.Add(this.nudown_timeValue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "批量删除";
            // 
            // comb_timeUnit
            // 
            this.comb_timeUnit.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comb_timeUnit.FormattingEnabled = true;
            this.comb_timeUnit.Items.AddRange(new object[] {
            "分钟",
            "小时",
            "天",
            "月"});
            this.comb_timeUnit.Location = new System.Drawing.Point(118, 19);
            this.comb_timeUnit.Name = "comb_timeUnit";
            this.comb_timeUnit.Size = new System.Drawing.Size(53, 23);
            this.comb_timeUnit.TabIndex = 10;
            this.comb_timeUnit.Text = "分钟";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(177, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "以外所有数据";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "删除";
            // 
            // btn_ALLdel
            // 
            this.btn_ALLdel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ALLdel.ForeColor = System.Drawing.Color.Red;
            this.btn_ALLdel.Location = new System.Drawing.Point(287, 16);
            this.btn_ALLdel.Name = "btn_ALLdel";
            this.btn_ALLdel.Size = new System.Drawing.Size(91, 29);
            this.btn_ALLdel.TabIndex = 7;
            this.btn_ALLdel.Text = "批量删除";
            this.btn_ALLdel.UseVisualStyleBackColor = true;
            this.btn_ALLdel.Click += new System.EventHandler(this.btn_ALLdel_Click);
            // 
            // nudown_timeValue
            // 
            this.nudown_timeValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudown_timeValue.Location = new System.Drawing.Point(60, 17);
            this.nudown_timeValue.Name = "nudown_timeValue";
            this.nudown_timeValue.Size = new System.Drawing.Size(52, 26);
            this.nudown_timeValue.TabIndex = 6;
            // 
            // 批量删除数据库数据
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "批量删除数据库数据";
            this.Size = new System.Drawing.Size(392, 54);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudown_timeValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comb_timeUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudown_timeValue;
        public System.Windows.Forms.Button btn_ALLdel;
    }
}
