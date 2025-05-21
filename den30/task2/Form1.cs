using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private string scrollingText = "Бла-бла-бла бле-бле-бле блю-блю-блю лин-ган-гули-гули-гули ";
        private int textPosition = 0;
        private Font textFont = new Font("Arial", 20, FontStyle.Bold);
        private Brush textBrush = Brushes.Blue;
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            InitializeTimer();
        }
        private void InitializeForm()
        {
            this.Text = "Бегущая строка";
            this.ClientSize = new Size(800, 100);
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Click += Form_Click;
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 30
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            textPosition -= 2;
            if (textPosition < -TextRenderer.MeasureText(scrollingText, textFont).Width)
                textPosition = this.ClientSize.Width;

            this.Invalidate();
        }

        private void Form_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawString(
                scrollingText,
                textFont,
                textBrush,
                textPosition,
                (this.ClientSize.Height - textFont.Height) / 2);
        }
    }
}
