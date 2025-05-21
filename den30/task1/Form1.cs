using System.Windows.Forms;
namespace zadanie1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int seconds = 0;
        private const int clockRadius = 100;
        private Point center;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; 
            this.ClientSize = new Size(300, 300);
            this.Text = "Анимация секундной стрелки";

            center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds = (seconds + 1) % 60; 
            this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawEllipse(Pens.Black, center.X - clockRadius, center.Y - clockRadius,
                          clockRadius * 2, clockRadius * 2);

            double angle = (seconds - 15) * 6 * Math.PI / 180; 
            int x = center.X + (int)(clockRadius * 0.9 * Math.Cos(angle));
            int y = center.Y + (int)(clockRadius * 0.9 * Math.Sin(angle));

            g.DrawLine(Pens.Red, center, new Point(x, y));

            Font font = new Font("Arial", 10);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            for (int i = 1; i <= 12; i++)
            {
                double hourAngle = (i * 30 - 90) * Math.PI / 180;
                int numX = center.X + (int)(clockRadius * 0.8 * Math.Cos(hourAngle));
                int numY = center.Y + (int)(clockRadius * 0.8 * Math.Sin(hourAngle));
                g.DrawString(i.ToString(), font, Brushes.Black, numX, numY, format);
            }
        }
    }
}
