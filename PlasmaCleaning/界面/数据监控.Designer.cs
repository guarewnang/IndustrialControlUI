namespace PlasmaCleaning.界面
{
    partial class 数据监控
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
            this.dgv_getAllProductInfo = new System.Windows.Forms.DataGridView();
            this.ctr_deleteProductInfo = new PlasmaCleaning.自定义.控件.批量删除数据库数据();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_licensePlateNumber = new System.Windows.Forms.TextBox();
            this.btn_findProductInfoByLPN = new System.Windows.Forms.Button();
            this.btn_getAllProductInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_getAllProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_getAllProductInfo
            // 
            this.dgv_getAllProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_getAllProductInfo.Location = new System.Drawing.Point(404, 38);
            this.dgv_getAllProductInfo.Name = "dgv_getAllProductInfo";
            this.dgv_getAllProductInfo.RowTemplate.Height = 23;
            this.dgv_getAllProductInfo.Size = new System.Drawing.Size(689, 466);
            this.dgv_getAllProductInfo.TabIndex = 14;
            // 
            // ctr_deleteProductInfo
            // 
            this.ctr_deleteProductInfo.Location = new System.Drawing.Point(404, 541);
            this.ctr_deleteProductInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ctr_deleteProductInfo.Name = "ctr_deleteProductInfo";
            this.ctr_deleteProductInfo.Size = new System.Drawing.Size(598, 77);
            this.ctr_deleteProductInfo.SQLBLL = PlasmaCleaning.自定义.控件.批量删除数据库数据.MYBLL.ProductInfoBLL;
            this.ctr_deleteProductInfo.Str_TbName = "ModelProductInfoes";
            this.ctr_deleteProductInfo.Str_TimeName = "ProductInfoSamplingTime";
            this.ctr_deleteProductInfo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "车牌号：";
            // 
            // tbox_licensePlateNumber
            // 
            this.tbox_licensePlateNumber.Location = new System.Drawing.Point(195, 49);
            this.tbox_licensePlateNumber.Name = "tbox_licensePlateNumber";
            this.tbox_licensePlateNumber.Size = new System.Drawing.Size(156, 26);
            this.tbox_licensePlateNumber.TabIndex = 19;
            // 
            // btn_findProductInfoByLPN
            // 
            this.btn_findProductInfoByLPN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_findProductInfoByLPN.Location = new System.Drawing.Point(195, 110);
            this.btn_findProductInfoByLPN.Name = "btn_findProductInfoByLPN";
            this.btn_findProductInfoByLPN.Size = new System.Drawing.Size(156, 42);
            this.btn_findProductInfoByLPN.TabIndex = 20;
            this.btn_findProductInfoByLPN.Text = "根据车牌号查询";
            this.btn_findProductInfoByLPN.UseVisualStyleBackColor = true;
            this.btn_findProductInfoByLPN.Click += new System.EventHandler(this.btn_findProductInfoByLPN_Click);
            // 
            // btn_getAllProductInfo
            // 
            this.btn_getAllProductInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getAllProductInfo.Location = new System.Drawing.Point(195, 172);
            this.btn_getAllProductInfo.Name = "btn_getAllProductInfo";
            this.btn_getAllProductInfo.Size = new System.Drawing.Size(156, 42);
            this.btn_getAllProductInfo.TabIndex = 21;
            this.btn_getAllProductInfo.Text = "查看所有产品信息";
            this.btn_getAllProductInfo.UseVisualStyleBackColor = true;
            this.btn_getAllProductInfo.Click += new System.EventHandler(this.btn_getAllProductInfo_Click);
            // 
            // 数据监控
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 673);
            this.Controls.Add(this.btn_getAllProductInfo);
            this.Controls.Add(this.btn_findProductInfoByLPN);
            this.Controls.Add(this.tbox_licensePlateNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctr_deleteProductInfo);
            this.Controls.Add(this.dgv_getAllProductInfo);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "数据监控";
            this.Text = "数据监控";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_getAllProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_getAllProductInfo;
        private 自定义.控件.批量删除数据库数据 ctr_deleteProductInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_licensePlateNumber;
        private System.Windows.Forms.Button btn_findProductInfoByLPN;
        private System.Windows.Forms.Button btn_getAllProductInfo;
    }
}