using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;


namespace DivControlComponent
{
    public class CxFlatRoundButton : Control
    {
        #region 变量
        bool enterFlag = false;
        bool clickFlag = false;
        #endregion

        #region 属性

        private ButtonType _buttonType = ButtonType.Primary;
        public ButtonType ButtonType
        {
            get { return _buttonType; }
            set
            {
                _buttonType = value;
                Invalidate();
            }
        }

        private Color _textColor = Color.White;
        public Color TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                Invalidate();
            }
        }
        #endregion

        #region 事件
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            enterFlag = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            enterFlag = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            clickFlag = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            clickFlag = false;
            Invalidate();
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(Parent.BackColor);

            var backPath = new GraphicsPath();
            backPath.AddArc(new RectangleF(0.5f, 0.5f, Height - 1, Height - 1), 90, 180);
            backPath.AddArc(new RectangleF(Width - Height + 0.5f, 0.5f, Height - 1, Height - 1), 270, 180);
            backPath.CloseAllFigures();

            if (_buttonType == ButtonType.Default)
            {
                graphics.DrawPath(new Pen(clickFlag ? ThemeColors.PrimaryColor : ThemeColors.OneLevelBorder, 1), backPath);
                graphics.FillPath(new SolidBrush(enterFlag ? Color.FromArgb(25, ThemeColors.PrimaryColor) : Color.White), backPath);
                graphics.DrawString(Text, Font, new SolidBrush(enterFlag ? ThemeColors.PrimaryColor : ThemeColors.MainText), new RectangleF(Height / 2, 0, Width - Height, Height), StringAlign.Center);
            }
            else
            {
                var backColor = ThemeColors.PrimaryColor;
                switch (_buttonType)
                {
                    case ButtonType.Primary:
                        backColor = ThemeColors.PrimaryColor;
                        break;
                    case ButtonType.Success:
                        backColor = ThemeColors.Success;
                        break;
                    case ButtonType.Info:
                        backColor = ThemeColors.Info;
                        break;
                    case ButtonType.Waring:
                        backColor = ThemeColors.Warning;
                        break;
                    case ButtonType.Danger:
                        backColor = ThemeColors.Danger;
                        break;
                    default:
                        break;
                }
                var brush = new SolidBrush(enterFlag ? (clickFlag ? backColor : Color.FromArgb(225, backColor)) : backColor);
                graphics.FillPath(brush, backPath);
                graphics.DrawString(Text, Font, new SolidBrush(Color.White), new RectangleF(Height / 2, 0, Width - Height, Height), StringAlign.Center);
            }
        }


        public CxFlatRoundButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12);
        }
    }
}