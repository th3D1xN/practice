using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private double t = 0;
        private const double a = 50;
        private const double dt = 0.01;
        private PointF currentPosition;
        private readonly Pen trajectoryPen = new Pen(Color.Blue, 2);
        private readonly Pen pointPen = new Pen(Color.Red, 4);
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
            this.Text = "Движение по декартову листу";

            // Настройка таймера
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            t += dt;
            if (t > 2 * Math.PI) t = 0;

            // Параметрические уравнения декартова листа
            double denominator = 1 + Math.Pow(t, 3);
            double x = 3 * a * t / denominator;
            double y = 3 * a * Math.Pow(t, 2) / denominator;

            // Преобразование координат для отображения
            currentPosition = new PointF(
                (float)(this.ClientSize.Width / 2 + x),
                (float)(this.ClientSize.Height / 2 - y) // Инвертируем y для правильной ориентации
            );

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Рисуем оси координат
            DrawAxes(g);

            // Рисуем траекторию (декартов лист)
            DrawTrajectory(g);

            // Рисуем текущую позицию точки
            g.DrawEllipse(pointPen, currentPosition.X - 3, currentPosition.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Red, currentPosition.X - 3, currentPosition.Y - 3, 6, 6);
        }

        private void DrawAxes(Graphics g)
        {
            Pen axisPen = new Pen(Color.Black, 1);
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            // Ось X
            g.DrawLine(axisPen, 0, centerY, this.ClientSize.Width, centerY);
            // Ось Y
            g.DrawLine(axisPen, centerX, 0, centerX, this.ClientSize.Height);

            // Стрелки осей
            g.DrawLine(axisPen, this.ClientSize.Width - 10, centerY - 5, this.ClientSize.Width, centerY);
            g.DrawLine(axisPen, this.ClientSize.Width - 10, centerY + 5, this.ClientSize.Width, centerY);
            g.DrawLine(axisPen, centerX - 5, 10, centerX, 0);
            g.DrawLine(axisPen, centerX + 5, 10, centerX, 0);
        }

        private void DrawTrajectory(Graphics g)
        {
            // Рисуем декартов лист по точкам
            for (double theta = -Math.PI; theta <= Math.PI; theta += 0.01)
            {
                double denominator = 1 + Math.Pow(theta, 3);
                if (Math.Abs(denominator) < 0.0001) continue;

                double x1 = 3 * a * theta / denominator;
                double y1 = 3 * a * Math.Pow(theta, 2) / denominator;

                double x2 = 3 * a * (theta + 0.01) / (1 + Math.Pow(theta + 0.01, 3));
                double y2 = 3 * a * Math.Pow(theta + 0.01, 2) / (1 + Math.Pow(theta + 0.01, 3));

                g.DrawLine(trajectoryPen,
                    (float)(this.ClientSize.Width / 2 + x1),
                    (float)(this.ClientSize.Height / 2 - y1),
                    (float)(this.ClientSize.Width / 2 + x2),
                    (float)(this.ClientSize.Height / 2 - y2));
            }
        }
    }
}
