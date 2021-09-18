using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace N2D22.Controls
{
    public class ExtendedSpinner : Control
    {
        public ExtendedSpinner()
        {
            SetStyle(ControlStyles.UserPaint
                | ControlStyles.ResizeRedraw
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);

            Ticker = new Timer()
            {
                Interval = 100 / _speed
            };

            Ticker.Tick += Ticker_Tick;
            Size = new Size(64, 64);
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            if (_angle >= 360)
                _angle = 0;

            _angle += _speed;

            Refresh();
        }

        private readonly Timer Ticker;
        private int _angle = 270;

        private bool _trail = false;

        private int _speed = 2;
        private int _thickness = 2;
        private int _backThick = 2;
        private bool _isSpinning = false;

        private bool _gradient = false;
        private Color _colorOne = Color.Cyan;
        private Color _colorTwo = Color.Indigo;

        private Color _bkcolor = Color.FromArgb(24, 24, 25);
        private Color _color = Color.Cyan;
        private int _value = 10;

        [Category("Extended Options")]
        public bool Trail { get => _trail; set { _trail = value; Invalidate(); } }

        [Category("Extended Options")]
        public Color ObjectColor { get => _color; set { _color = value; Invalidate(); } }

        [Category("Extended Options")]
        public Color BackObjectColor { get => _bkcolor; set { _bkcolor = value; Invalidate(); } }

        [Category("Extended Options")]
        public int Speed { get => _speed; set { if (_speed > 0 && _speed <= 100) _speed = value; Ticker.Interval = 100 / value; Invalidate(); } }

        [Category("Extended Options")]
        public int Thickness { get => _thickness; set { _thickness = value; Invalidate(); } }

        [Category("Extended Options")]
        public int BackThickness { get => _backThick; set { _backThick = value; Invalidate(); } }

        [Category("Extended Options")]
        public bool Animated { get => _isSpinning; set { _isSpinning = value; Ticker.Enabled = value; Invalidate(); } }

        [Category("Extended Options")]
        public int Value { get => _value; set { if (value >= 0 && value <= 100) _value = value; Invalidate(); } }

        [Category("Extended Options")]
        public bool Gradient { get => _gradient; set { _gradient = value; Invalidate(); } }

        [Category("Extended Options")]
        public Color ColorOne { get => _colorOne; set { _colorOne = value; Invalidate(); } }

        [Category("Extended Options")]
        public Color ColorTwo { get => _colorTwo; set { _colorTwo = value; Invalidate(); } }

        private BufferedGraphics gBuf;

        protected override void OnPaint(PaintEventArgs e)
        {
            BufferedGraphicsContext bufferedGraphicsContext = BufferedGraphicsManager.Current;
            bufferedGraphicsContext.MaximumBuffer = new Size(Width + 1, Height + 1);

            gBuf = bufferedGraphicsContext.Allocate(CreateGraphics(), new Rectangle(0, 0, 1, 1));
            gBuf = bufferedGraphicsContext.Allocate(CreateGraphics(), ClientRectangle);

            gBuf.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            gBuf.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            gBuf.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            gBuf.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gBuf.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (BackgroundImage == null)
                gBuf.Graphics.Clear(BackColor);
            else
                gBuf.Graphics.DrawImage(BackgroundImage, 0, 0);

            Rectangle rect = new Rectangle(_thickness / 2 + 1, _thickness / 2 + 1, Width - _thickness - 2, Height - _thickness - 2);

            if (_backThick > 0)
                gBuf.Graphics.DrawArc(new Pen(_bkcolor, _backThick), rect, 0f, 360f);

            if (_gradient)
                gBuf.Graphics.DrawArc(new Pen(new LinearGradientBrush(DisplayRectangle, _colorOne, _colorTwo, 180f), _thickness), rect, _angle, _value * 3.6f);
            else
            {
                if (_trail)
                {
                    float constant = 0.0140625f;

                    for (int i = 0; i < 255; i++)
                        gBuf.Graphics.DrawArc(new Pen(Color.FromArgb(i, _color), _thickness), rect, _angle + (_value * (constant * i)), _value * constant);
                }
                else
                    gBuf.Graphics.DrawArc(new Pen(_color, _thickness), rect, _angle, _value * 3.6f);
            }

            gBuf.Render(e.Graphics);

            base.OnPaint(e);
        }
    }
}