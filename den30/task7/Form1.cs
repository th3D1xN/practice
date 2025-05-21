using System;
using System.Drawing;
using System.Windows.Forms;

namespace task7
{
    public partial class Form1 : Form
    {
        private readonly int amplitude = 100;  // ��������� ���������
        private readonly int period = 200;     // ������ ���������
        private readonly int circleRadius = 20; // ������ ����������
        private int xPosition = 0;            // ������� ������� �� X
        private readonly System.Windows.Forms.Timer animationTimer; // ���� ��������� ������������ ����

        public Form1()
        {
            InitializeComponent();

            // ��������� �����
            this.Text = "�������� �� ���������";
            this.ClientSize = new Size(800, 400);
            this.DoubleBuffered = true;

            // ��������� �������
            animationTimer = new System.Windows.Forms.Timer
            {
                Interval = 20 // 20 �� (50 ������ � �������)
            };
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

            this.Paint += Form1_Paint;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            xPosition += 2; // �������� ��������

            // ���� ���� ����� �� ������� �����, �������� �������
            if (xPosition > this.ClientSize.Width + circleRadius)
            {
                xPosition = -circleRadius;
            }

            this.Invalidate(); // �������������� �����
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // ������� ���
            g.Clear(Color.White);

            // ������ ��� ���������
            DrawAxes(g);

            // ������ ���������
            DrawSinusoid(g);

            // ������ ���������� ����
            DrawMovingCircle(g);
        }

        private void DrawAxes(Graphics g)
        {
            int centerY = this.ClientSize.Height / 2;

            // ��� X
            g.DrawLine(Pens.Black, 0, centerY, this.ClientSize.Width, centerY);

            // ��� Y
            g.DrawLine(Pens.Black, 50, 0, 50, this.ClientSize.Height);

            // ������� ����
            g.DrawString("X", this.Font, Brushes.Black, this.ClientSize.Width - 20, centerY - 20);
            g.DrawString("Y", this.Font, Brushes.Black, 30, 10);
        }

        private void DrawSinusoid(Graphics g)
        {
            int centerY = this.ClientSize.Height / 2;
            Pen sinusoidPen = new Pen(Color.Blue, 2);

            Point prevPoint = new Point(0, centerY - (int)(amplitude * Math.Sin(0)));

            for (int x = 1; x < this.ClientSize.Width; x++)
            {
                double angle = 2 * Math.PI * x / period;
                int y = centerY - (int)(amplitude * Math.Sin(angle));

                Point currentPoint = new Point(x, y);
                g.DrawLine(sinusoidPen, prevPoint, currentPoint);

                prevPoint = currentPoint;
            }
        }

        private void DrawMovingCircle(Graphics g)
        {
            int centerY = this.ClientSize.Height / 2;
            double angle = 2 * Math.PI * xPosition / period;
            int y = centerY - (int)(amplitude * Math.Sin(angle));

            // ������ ����������
            g.FillEllipse(Brushes.Red, xPosition - circleRadius, y - circleRadius,
                         circleRadius * 2, circleRadius * 2);

            // ������ ����� �� ��� X �� ������ �����
            g.DrawLine(Pens.Green, xPosition, centerY, xPosition, y);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            animationTimer.Stop(); // ������������� ������ ��� �������� �����
        }
    }
}