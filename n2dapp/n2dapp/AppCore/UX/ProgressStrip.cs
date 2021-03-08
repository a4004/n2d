using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System;

namespace N2D.AppCore.UX
{
    partial class ProgressStrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnimationSeq = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AnimationSeq
            // 
            this.AnimationSeq.Enabled = true;
            this.AnimationSeq.Interval = 10;
            this.AnimationSeq.Tick += new System.EventHandler(this.AnimationSeq_Tick);
            // 
            // ProgressStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProgressStrip";
            this.Size = new System.Drawing.Size(500, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer AnimationSeq;
    }
    public partial class ProgressStrip : UserControl
    {
        /// <summary>
        /// ProgressStrip Constructor
        /// </summary>
        public ProgressStrip()
        {
            InitializeComponent();                                      // Call InitializeComponent.

            this.DoubleBuffered = true;                                 // Prevent flickering w/ double buffering.
            this.SetStyle(ControlStyles.UserPaint                       // Apply required ControlStyles.
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.ResizeRedraw
                | ControlStyles.ContainerControl
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.SupportsTransparentBackColor, true);
        }

        /// <summary>
        /// RegularMode Properties
        /// </summary>
        internal class RegularMode
        {
            public static bool Glow = true;
            public static int Value = 0;
            public static int Speed = 3;
            public static int Position = -300;
        }
        /// <summary>
        /// Marquee Properties
        /// </summary>
        internal class Marquee
        {
            public static int Size = 25;
            public static int Speed = 5;
            public static int Position = -300;
        }

        /// <summary>
        /// Defines the background color of the control
        /// </summary>
        public override Color BackColor { get; set; } = Color.FromArgb(44, 46, 54);
        /// <summary>
        /// Defines the value (foreground) color of the control
        /// </summary>
        public override Color ForeColor { get; set; } = Color.FromArgb(30, 235, 200);
        /// <summary>
        /// Defines the highlight (glow) color of the control
        /// </summary>
        public Color GlowColor { get; set; } = Color.PaleTurquoise;

        /// <summary>
        /// Defines the control modes
        /// </summary>
        public enum ControlMode : int
        {
            Regular = 0,
            Marquee = 1
        }

        /// <summary>
        /// Defines the active control mode
        /// </summary>
        public ControlMode Mode { get; set; } = ControlMode.Regular;

        /// <summary>
        /// Determines whether the control has glow enabled
        /// </summary>
        public bool GlowEnabled
        {
            get
            {
                return RegularMode.Glow;    // return the value of the internal glow boolean.    
            }
        }

        /// <summary>
        /// Determines the value of the control
        /// </summary>
        public int Value
        {
            get
            {
                return RegularMode.Value;       // return the value of the internal value integer.
            }
            set
            {
                if (value > 100 || value < 0)   // if the value is outside the range.
                {
                    Debug.WriteLine(            // log the event for debugging purposes.
                        $"[mrvodka.UI] Cannot set value of ProgressStrip because {value} is outside the range. (0-100)");
                    return;                     // return and do not apply.
                }
                else
                    RegularMode.Value = value;  // set the internal value integer to the new value.

                this.Refresh();                 // refresh the control.
            }
        }

        /// <summary>
        /// Determines the glow animation speed
        /// </summary>
        public int RegularSpeed
        {
            get
            {
                return RegularMode.Speed;       // return the value of internal speed.
            }
            set
            {
                RegularMode.Speed = value;      // set the value of internal speed to the new value.
            }
        }

        /// <summary>
        /// Determines the marquee animation speed
        /// </summary>
        public int MarqueeSpeed
        {
            get
            {
                return Marquee.Speed;       // return the value of internal speed.
            }
            set
            {
                Marquee.Speed = value;      // set the value of internal speed to the new value.
            }
        }

        /// <summary>
        /// Determines the marquee bar size
        /// </summary>
        public int MarqueeSize
        {
            get
            {
                return Marquee.Size;       // return the value of size.
            }
            set
            {
                Marquee.Size = value;      // set the value of size.
            }
        }

        /// <summary>
        /// Toggles glow on the control
        /// </summary>
        /// <param name="mode">Determines whether the control should glow.</param>
        public void ToggleGlow(bool mode = true)
        {
            RegularMode.Glow = mode;    // toggle glow.
            this.Refresh();             // redraw control (to update.)
        }

        /// <summary>
        /// Rounds a number to the nearest integer
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns>A rounded integer value.</returns>
        private int Round(double value)
        {
            return (int)Math.Round(value, 0);
        }

        /// <summary>
        /// Draws ProgressStrip glow effect using GDI
        /// </summary>
        /// <param name="g">Graphics Object</param>
        private void DrawGlowEffect(Graphics g)
        {
            Rectangle rect = new                                        // create new rectangle.
                Rectangle(RegularMode.Position, 0, 90, this.Height);
            LinearGradientBrush brush = new                             // create new brush (for drawing.)
                LinearGradientBrush(rect, Color.White, Color.White,
                LinearGradientMode.Horizontal);
            ColorBlend blend = new ColorBlend(4);                       // create a color blend for the glow effect.

            blend.Colors = new Color[] { Color.Transparent, GlowColor,  // populate with array of colors.
                GlowColor, Color.Transparent };
            blend.Positions = new float[] { 0.0F, 0.5F, 0.6F, 1.0F };   // add positions.

            brush.InterpolationColors = blend;                          // set the colors of the brush to the blend.

            Rectangle clip = new Rectangle(0, 0,                        // create clip.
                this.Width, this.Height)
            {
                Width = Round(RegularMode.Value / 100.0f * this.Width)  // set width.
            };

            g.SetClip(clip);                                            // set the clip in GDI.
            g.FillRectangle(brush, rect);                               // draw glow effect.
            g.ResetClip();                                              // clear clip from buffer.
        }
        /// <summary>
        /// Draws ProgressStrip background using GDI
        /// </summary>
        /// <param name="g">Graphics Object</param>
        private void DrawBackground(Graphics g)
        {
            g.FillRectangle(new SolidBrush(BackColor),  // fill background with color.
                this.ClientRectangle);
        }
        /// <summary>
        /// Draws ProgressStrip value bar using GDI
        /// </summary>
        /// <param name="g">Graphics Object</param>
        private void DrawValue(Graphics g)
        {
            Rectangle rect = new             // create new rectangle object.
                Rectangle(0, 0, this.Width, this.Height);

            rect.Width = Round(              // set width of rectangle according to value (percentage.)
                RegularMode.Value / 100.0f * this.Width);

            g.FillRectangle(new              // fill the rect with the color of the value bar.
                SolidBrush(ForeColor), rect);
        }
        /// <summary>
        /// Draws ProgressStrip marquee bar using GDI.
        /// </summary>
        /// <param name="g">Graphics Object</param>
        private void DrawSegmentedValue(Graphics g)
        {
            Rectangle rect = new                                        // create new rectangle.
                Rectangle(Marquee.Position, 0, Marquee.Size, this.Height);

            Rectangle clip = new Rectangle(Marquee.Position, 0,         // create clip.
                this.Width, this.Height)
            {
                Width = Marquee.Size                                    // set clip width.
            };

            g.SetClip(clip);                                            // set the clip in GDI.
            g.FillRectangle(new SolidBrush(ForeColor), rect);           // draw value.
            g.ResetClip();                                              // clear clip from buffer.
        }

        /// <summary>
        /// Paint Method Override
        /// </summary>
        /// <param name="e">Paint Object</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);                            // allow default paint methods to complete.

            e.Graphics.InterpolationMode =              // set interplotation mode.
                InterpolationMode.HighQualityBicubic;

            DrawBackground(e.Graphics);                 // draw the background of the contro.

            if (Mode is ControlMode.Marquee)             // if marquee mode.
            {
                DrawSegmentedValue(e.Graphics);         // draw marquee bar.
                return;                                 // return (prevent latter execution.)
            }
            else if (Mode is ControlMode.Regular)        // if regular mode.
            {
                DrawValue(e.Graphics);                  // draw the value bar.

                if (RegularMode.Glow)                   // if glow is enabled.
                    DrawGlowEffect(e.Graphics);         // draw glow effect.

                return;                                 // return (prevent latter execution.)
            }
        }
        /// <summary>
        /// Animation 'Loop' (runs every 10ms)
        /// </summary>
        /// <param name="sender">Sender Object</param>
        /// <param name="e">Argument Object</param>
        private void AnimationSeq_Tick(object sender, EventArgs e)
        {
            if (Mode is ControlMode.Marquee)         // if marquee mode.
            {
                Marquee.Position += Marquee.Speed;  // add speed to marquee position.

                if (Marquee.Position                // if bar is beyond visible range.
                    > this.Width + Marquee.Size * 2)
                    Marquee.Position =              // reset position.
                        (0 - Marquee.Size);
            }
            else if (Mode is ControlMode.Regular)    // otherwise if regular.
            {
                if (RegularMode.Glow)                // if glow is enabled.
                {
                    RegularMode.Position +=         // add speed to the current glow position.
                        RegularMode.Speed;

                    if (RegularMode.Position         // if glow is beyond visible range (to the right.)
                        > this.Width)
                    {
                        RegularMode.Position =     // reset to beyond visible range (on the left for delay.)
                            (0 - 100);
                    }
                }
            }

            this.Refresh();                         // refresh the control.
        }
    }
}
