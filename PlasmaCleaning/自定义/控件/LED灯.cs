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
    public partial class LED灯 : 自定义控件
    {
        public LED灯()
        {
            InitializeComponent();
            #region 【1】设置双缓冲属性
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//缓冲区绘制，减少闪烁
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            //  this.isFlashChanged += new isFlashChangedEventHanlder(isFlashCHANGED);
            #endregion
        }
        #region 三个字段
        private Graphics g;
        private Pen p;
        private SolidBrush sb;
        private Timer timer = new Timer();
        private int intColorIndex = 0;
        //private delegate void isFlashChangedEventHanlder();//定义委托
        //private event isFlashChangedEventHanlder isFlashChanged;//定义事件
        #endregion
        #region 添加设置Graphics方法
        private void SetGraphics(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//平滑处理：抗锯齿呈现
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//平滑处理：高质量
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
        }
        #endregion
        #region 根据实际使用创建属性
        private Color ledColor = Color.Green;
        [Category("自定义控件属性")]
        [Description("LED指示灯演示")]
        public Color LEDColor
        {
            get { return ledColor; }
            set
            {
                ledColor = value;
                this.Invalidate();
            }
        }
        private bool isBorder = true;
        [Category("自定义控件属性")]
        [Description("是否有边框")]
        public bool IsBorder
        {
            get { return isBorder; }
            set
            {
                isBorder = value;
                this.Invalidate();
            }
        }
        private int borderWidth = 5;
        [Category("自定义控件属性")]
        [Description("圆环的宽度")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                this.Invalidate();
            }
        }
        private Color borderColor;
        [Category("自定义控件属性")]
        [Description("圆环颜色")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        private int gapWidth;
        [Category("自定义控件属性")]
        [Description("间隙宽度")]
        public int GapWidth
        {
            get { return gapWidth; }
            set
            {
                gapWidth = value;
                this.Invalidate();
            }
        }
        private bool isHighLight = true;
        [Category("自定义控件属性")]
        [Description("是否高亮")]
        public bool IsHighLight
        {
            get { return isHighLight; }
            set
            {
                isHighLight = value;
                this.Invalidate();
            }
        }
        private Color centerColor = Color.White;
        [Category("自定义控件属性")]
        [Description("渐变中心的颜色")]
        public Color CenterColor
        {
            get { return centerColor; }
            set
            {
                centerColor = value;
                this.Invalidate();
            }
        }
        private Color ledTrueColor = Color.Green;
        [Category("自定义控件属性")]
        [Description("True的时候LED指示灯颜色")]
        public Color LedTrueColor
        {
            get { return ledTrueColor; }
            set
            {
                ledTrueColor = value;
                this.Invalidate();
            }
        }
        private Color ledFalseColor = Color.Red;
        [Category("自定义控件属性")]
        [Description("False的时候LED指示灯颜色")]
        public Color LedFalseColor
        {
            get { return ledFalseColor; }
            set
            {
                ledFalseColor = value;
                this.Invalidate();
            }
        }
        private bool ledStatus = true;
        [Category("自定义控件属性")]
        [Description("当前状态")]
        public bool LedStatus
        {
            get { return ledStatus; }
            set
            {
                ledStatus = value;
                this.Invalidate();
            }
        }
        private bool isFlash = true;
        [Category("自定义控件属性")]
        [Description("是否闪烁")]
        public bool IsFlash
        {
            get { return isFlash; }
            set
            {
                if (IsFlash != value)
                {
                    isFlash = value;
                    isFlashCHANGED();
                }

                this.Invalidate();
            }
        }
        private int flashInterval = 500;
        [Category("自定义控件属性")]
        [Description("闪烁频率")]
        public int FlashInterval
        {
            get { return flashInterval; }
            set
            {
                flashInterval = value;
                timer.Interval = flashInterval;
                this.Invalidate();
            }
        }
        private Color[] lampColor = new Color[] { };
        [Category("自定义控件属性")]
        [Description("闪烁灯的几种颜色，当需要闪烁时，至少需要2个及以上颜色，不需要闪烁则至少需要1个颜色")]
        public Color[] LampColor
        {
            get { return lampColor; }
            set
            {
                if (value == null || value.Length <= 0) return;
                lampColor = value;
                this.Invalidate();
            }
        }
        [Category("自定义控件属性")]
        [Description("填写PLC地址，当读取为true时，灯为绿色，当位false时，灯为灰色")]
        public string Address { get => address; set => address = value; }

        private string address;
        #endregion
        #region 创建重绘事件
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;//获取画布
            SetGraphics(g);//设置画布
            #region 画圆1
            int LEDWidth = Math.Min(this.Width, this.Height);
            Color color = ledStatus ? ledTrueColor : ledFalseColor;
            if (isFlash)
            {
                lampColor = new Color[] { color, Color.Yellow };
                color = lampColor[intColorIndex];
            }
            sb = new SolidBrush(color);
            RectangleF rec = new RectangleF(1, 1, LEDWidth - 2, LEDWidth - 2);
            g.FillEllipse(sb, rec);//画一个圆，第一个参数是填充颜色，第二个参数是矩形边框
            #endregion
            #region  画圆2
            if (isBorder)
            {

                p = new Pen(borderColor, borderWidth);//使用背景色
                float x = 1 + gapWidth + borderWidth * 0.5f;
                RectangleF rec1 = new RectangleF(x, x, LEDWidth - 2 * x, LEDWidth - 2 * x);
                g.DrawEllipse(p, rec1);//画圆环
            }
            #endregion
            #region 渐变绘制是否高亮
            if (isHighLight)
            {

                GraphicsPath gp = new GraphicsPath();//设置路径
                float x = isBorder ? 1 + gapWidth + borderWidth : 1;
                RectangleF rec1 = new RectangleF(x, x, LEDWidth - 2 * x, LEDWidth - 2 * x);
                gp.AddEllipse(rec1);//把矩形添加到路径上
                PathGradientBrush pgb = new PathGradientBrush(gp);//把路径传入            
                pgb.SurroundColors = new Color[] { color };
                pgb.CenterColor = this.centerColor;

                g.FillPath(pgb, gp);
            }
            #endregion
        }
        #endregion
        #region 计时器事件闪烁
        private void Timer_Tick(object sender, EventArgs e)
        {
            intColorIndex++;
            if (intColorIndex >= lampColor.Length)
            {
                intColorIndex = 0;
            }
            this.Invalidate();
        }
        #endregion
        private void isFlashCHANGED()
        {
            if (IsFlash)
            {
                timer.Enabled = true;
            }
            else
            {
                timer.Enabled = false;
            }
        }
        public override void UpdateState()
        {
            LedStatus = (bool)Tool.PLCCommunicate.Instance.ReadSingleData(Address, false, false);
            //if ((bool)Tool.PLCCommunicate.Instance.ReadSingleData(Address, false, false))
            //    ledColor = Color.Green;
            //else
            //    ledColor = Color.Gray;

        }
    }
}
