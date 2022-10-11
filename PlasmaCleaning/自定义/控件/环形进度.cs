using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PlasmaCleaning.自定义.控件
{
    public partial class 环形进度 : UserControl
    {
        public 环形进度()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//缓冲区绘制，减少闪烁
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        //最大值
        private float maxValue = 100;
        public float MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; this.Invalidate(); }
        }
        //实际值
        private float actureValue = 60;
        public float ActureValue
        {
            get { return actureValue; }
            set { actureValue = value; this.Invalidate(); }
        }
        //文字显示值
        private float PercentVal = 0;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //获取画布
            Graphics graphics = e.Graphics;
            //消除锯齿
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //文字显示效果
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            //插补模式
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //图片呈现质量
            graphics.CompositingQuality = CompositingQuality.HighQuality;

            //绘制底圆
            SolidBrush brush1 = new SolidBrush(Color.FromArgb(93, 107, 153));
            Rectangle rectangle1 = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            graphics.FillEllipse(brush1, rectangle1);

            //绘制扇形
            Rectangle rectangle2 = new Rectangle(1, 1, this.Width - 2, this.Height - 2);
            LinearGradientBrush brush2 = new LinearGradientBrush(rectangle2, Color.Blue, Color.Red, 150.0f, true);
            this.PercentVal = (ActureValue / MaxValue) * 100;
            graphics.FillPie(brush2, rectangle2, -90, (ActureValue / MaxValue) * 360f);

            //绘制上圆
            SolidBrush solidBrushElipse = new SolidBrush(this.BackColor);
            Rectangle rectangle3 = new Rectangle(15, 15, this.Width - 30, this.Height - 30);
            graphics.FillEllipse(solidBrushElipse, rectangle3);

            //绘制文字
            Font font = new Font("宋体", 14);
            PointF point = new PointF(((float)this.Width) / 2.0f - 27, ((float)this.Height) / 2.0f - 10);
            graphics.DrawString(this.PercentVal.ToString("0.0") + "%", font, Brushes.Coral, point);
        }
    }
}
