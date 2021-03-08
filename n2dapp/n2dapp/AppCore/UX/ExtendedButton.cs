using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace N2D.AppCore.UX
{
    public class ExtendedButton : Control
    {
        public ExtendedButton()
        {
            SetStyle(ControlStyles.ResizeRedraw
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.OptimizedDoubleBuffer, true);

            this.Size = new Size(100, 35);
            this.BackColor = Color.Transparent;

            UpdateColors();
        }

        private void UpdateColors()
        {
            activeBackground = _background;
            activeBorder = _border;
            activeText = _text;
        }

        private bool _useGradient = false;
        private bool _isRound = true;
        private int _radius = 15;
        private int _borderThickness = 1;

        private Color activeBackground;
        private Color activeBorder;
        private Color activeText;

        private Color _gbackOne = Color.DodgerBlue;
        private Color _gbackTwo = Color.DarkViolet;
        private Color _gbackOneHover = Color.Cyan;
        private Color _gbackTwoHover = Color.Magenta;
        private Color _gbackOneClick = Color.MediumSpringGreen;
        private Color _gbackTwoClick = Color.HotPink;
        private int _angle = 0;

        private Color _background = Color.DodgerBlue;
        private Color _border = Color.DodgerBlue;
        private Color _text = Color.White;

        private Color _backgroundHover = Color.DeepSkyBlue;
        private Color _borderHover = Color.DeepSkyBlue;
        private Color _textHover = Color.White;

        private Color _backgroundClick = Color.DeepSkyBlue;
        private Color _borderClick = Color.DeepSkyBlue;
        private Color _textClick = Color.White;

        private Image _picture = null;
        private Point _imgOffset = new Point(0, 0);
        private Point _txtOffset = new Point(0, 0);
        private bool _smooth = true;

        [Category("Other Extended Options")]
        public bool Gradient { get => _useGradient; set { _useGradient = value; UpdateColors(); Invalidate(); } }
        [Category("Other Extended Options")]
        public Color ColorOne { get => _gbackOne; set { _gbackOne = value; UpdateColors(); Invalidate(); } }
        [Category("Other Extended Options")]
        public Color ColorTwo { get => _gbackTwo; set { _gbackTwo = value; UpdateColors(); Invalidate(); } }
        public Color ColorOneClick { get => _gbackOneClick; set { _gbackOneClick = value; UpdateColors(); Invalidate(); } }
        [Category("Other Extended Options")]
        public Color ColorTwoClick { get => _gbackTwoClick; set { _gbackTwoClick = value; UpdateColors(); Invalidate(); } }
        public Color ColorOneHover { get => _gbackOneHover; set { _gbackOneHover = value; UpdateColors(); Invalidate(); } }
        [Category("Other Extended Options")]
        public Color ColorTwoHover { get => _gbackTwoHover; set { _gbackTwoHover = value; UpdateColors(); Invalidate(); } }
        [Category("Other Extended Options")]
        public int Angle { get => _angle; set { _angle = value; Invalidate(); } }
        [Category("Extended Options")]
        public bool RoundEdges { get => _isRound; set { _isRound = value; Invalidate(); } }
        [Category("Extended Options")]
        public bool SmoothText { get => _smooth; set { _smooth = value; Invalidate(); } }
        [Category("Extended Options")]
        public int Radius { get => _radius; set { if (value > 1) _radius = value; Invalidate(); } }
        [Category("Extended Options")]
        public int Border { get => _borderThickness; set { if (value >= 0) _borderThickness = value; Invalidate(); } }
        [Category("Extended Options")]
        public Color Background { get => _background; set { _background = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color BorderColor { get => _border; set { _border = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color TextColor { get => _text; set { _text = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color BackgroundOnHover { get => _backgroundHover; set { _backgroundHover = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color BorderColorOnHover { get => _borderHover; set { _borderHover = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color TextColorOnHover { get => _textHover; set { _textHover = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color BackgroundOnClick { get => _backgroundClick; set { _backgroundClick = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color BorderColorOnClick { get => _borderClick; set { _borderClick = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Color TextColorOnClick { get => _textClick; set { _textClick = value; UpdateColors(); Invalidate(); } }
        [Category("Extended Options")]
        public Image Picture { get => _picture; set { _picture = value; Invalidate(); } }
        [Category("Extended Options")]
        public Point PictureOffset { get => _imgOffset; set { _imgOffset = value; Invalidate(); } }
        [Category("Extended Options")]
        public Point TextOffset { get => _txtOffset; set { _txtOffset = value; Invalidate(); } }

        private void Draw(Graphics g, Brush br, int i)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddArc(Width - i * 2 - 2, 0, i * 2, i * 2, 270f, 90f);
                graphicsPath.AddArc(Width - i * 2 - 2, Height - i * 2, i * 2, i * 2 - 2, 0f, 90f);
                graphicsPath.AddArc(0, Height - i * 2 - 2, i * 2 - 2, i * 2, 90f, 90f);
                graphicsPath.AddArc(0, 0, i * 2, i * 2, 180f, 90f);
                graphicsPath.CloseFigure();

                g.FillPath(br, graphicsPath);
            }
        }
        private void Draw(Graphics g, Color col, int i, int a)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddArc(Width - i * 2 - 2, 0, i * 2, i * 2, 270f, 90f);
                graphicsPath.AddArc(Width - i * 2 - 2, Height - i * 2, i * 2, i * 2 - 2, 0f, 90f);
                graphicsPath.AddArc(0, Height - i * 2 - 2, i * 2 - 2, i * 2, 90f, 90f);
                graphicsPath.AddArc(0, 0, i * 2, i * 2, 180f, 90f);
                graphicsPath.CloseFigure();

                g.DrawPath(new Pen(col, a), graphicsPath);
            }
        }

        private bool mouseDown = false;
        private bool mouseOver = false;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            activeBackground = _backgroundClick;
            activeBorder = _borderClick;
            activeText = _textClick;

            mouseDown = true;

            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (ClientRectangle.Contains(PointToClient(e.Location)))
            {
                activeBackground = _backgroundHover;
                activeBorder = _borderHover;
                activeText = _textHover;
            }
            else
            {
                activeBackground = _background;
                activeBorder = _border;
                activeText = _text;
            }

            mouseDown = false;

            Invalidate();
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            activeBackground = _backgroundHover;
            activeBorder = _borderHover;
            activeText = _textHover;

            mouseOver = true;

            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            activeBackground = _background;
            activeBorder = _border;
            activeText = _text;

            mouseOver = false;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_isRound)
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            else
                e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;

            if (_smooth)
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            if (_isRound && _radius > 1 && _borderThickness is 0 && !_useGradient)
                Draw(e.Graphics, new SolidBrush(activeBackground), _radius);
            else if (_isRound && _radius > 1 && _borderThickness is 0 && _useGradient)
            {
                if (!mouseDown && !mouseOver)
                    Draw(e.Graphics, new LinearGradientBrush(DisplayRectangle, _gbackOne, _gbackTwo, _angle), _radius);
                else if (mouseDown)
                    Draw(e.Graphics, new LinearGradientBrush(DisplayRectangle, _gbackOneClick, _gbackTwoClick, _angle), _radius);
                else if (mouseOver)
                    Draw(e.Graphics, new LinearGradientBrush(DisplayRectangle, _gbackOneHover, _gbackTwoHover, _angle), _radius);
            }
            else if (!_isRound && _borderThickness is 0 && !_useGradient)
                e.Graphics.FillRectangle(new SolidBrush(activeBackground), DisplayRectangle);
            else if (!_isRound && _borderThickness is 0 && _useGradient)
            {
                if (!mouseDown && !mouseOver)
                    e.Graphics.FillRectangle(new LinearGradientBrush(DisplayRectangle, _gbackOne, _gbackTwo, _angle), DisplayRectangle);
                else if (mouseDown)
                    e.Graphics.FillRectangle(new LinearGradientBrush(DisplayRectangle, _gbackOneClick, _gbackTwoClick, _angle), DisplayRectangle);
                else if (mouseOver)
                    e.Graphics.FillRectangle(new LinearGradientBrush(DisplayRectangle, _gbackOneHover, _gbackTwoHover, _angle), DisplayRectangle);
            }
            else if (_isRound && _radius > 1 && _borderThickness != 0 && !_useGradient)
            {
                Draw(e.Graphics, new SolidBrush(activeBackground), _radius);
                Draw(e.Graphics, activeBorder, _radius, _borderThickness);
            }
            else if (_isRound && _radius > 1 && _borderThickness != 0 && _useGradient)
            {
                if (!mouseDown && !mouseOver)
                    Draw(e.Graphics, new LinearGradientBrush(DisplayRectangle, _gbackOne, _gbackTwo, _angle), _radius);
                else if (mouseDown)
                    Draw(e.Graphics, new LinearGradientBrush(DisplayRectangle, _gbackOneClick, _gbackTwoClick, _angle), _radius);
                else if (mouseOver)
                    Draw(e.Graphics, new LinearGradientBrush(DisplayRectangle, _gbackOneHover, _gbackTwoHover, _angle), _radius);

                Draw(e.Graphics, activeBorder, _radius, _borderThickness);
            }
            else if (!_isRound && _borderThickness != 0 && !_useGradient)
            {
                e.Graphics.FillRectangle(new SolidBrush(activeBackground), DisplayRectangle);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(activeBorder), _borderThickness), DisplayRectangle);
            }
            else if (!_isRound && _borderThickness != 0 && _useGradient)
            {
                if (!mouseDown && !mouseOver)
                    e.Graphics.FillRectangle(new LinearGradientBrush(DisplayRectangle, _gbackOne, _gbackTwo, _angle), DisplayRectangle);
                else if (mouseDown)
                    e.Graphics.FillRectangle(new LinearGradientBrush(DisplayRectangle, _gbackOneClick, _gbackTwoClick, _angle), DisplayRectangle);
                else if (mouseOver)
                    e.Graphics.FillRectangle(new LinearGradientBrush(DisplayRectangle, _gbackOneHover, _gbackTwoHover, _angle), DisplayRectangle);

                e.Graphics.DrawRectangle(new Pen(new SolidBrush(activeBorder), _borderThickness), DisplayRectangle);
            }

            if (_picture != null)
            {
                try
                {
                    e.Graphics.DrawImage(_picture, Width / 2 - (_picture.Size.Width / 2) + _imgOffset.X, Height / 2 - (_picture.Size.Height / 2) + _imgOffset.Y);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }

            var stringSize = e.Graphics.MeasureString(Text, Font);

            e.Graphics.DrawString(Text, Font, new SolidBrush(activeText), new RectangleF(new PointF((Width - stringSize.Width) / 2 + _txtOffset.X, (Height - stringSize.Height) / 2 + _txtOffset.Y), Size));
        }
    }
}
