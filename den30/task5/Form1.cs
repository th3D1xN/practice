using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace task5
{
    public partial class Form1 : Form
    {
        private int groundLevel;
        private const int rocketWidth = 40;
        private int rocketHeight = 80;
        private int rocketX;
        private int rocketY;
        private bool isLaunching = false;
        private readonly Brush rocketBrush = Brushes.Silver;
        private readonly Brush flameBrush = Brushes.OrangeRed;
        private readonly Brush buttonBrush = Brushes.Red;
        private readonly Pen buttonBorderPen = new Pen(Color.DarkRed, 3);

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Ракетный запуск";
            this.ClientSize = new Size(600, 500);
            this.DoubleBuffered = true;

            groundLevel = this.ClientSize.Height - 50;
            rocketX = this.ClientSize.Width / 2 - rocketWidth / 2;
            rocketY = groundLevel - rocketHeight;

            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисуем фон
            g.Clear(Color.DarkBlue);

            // Рисуем землю
            g.FillRectangle(Brushes.DarkGreen, 0, groundLevel, this.ClientSize.Width, this.ClientSize.Height - groundLevel);

            // Рисуем звезды
            DrawStars(g);

            // Рисуем ракету
            if (!isLaunching)
            {
                DrawRocket(g, rocketX, rocketY);
            }
            else
            {
                DrawRocketWithFlame(g, rocketX, rocketY);
            }

            // Рисуем кнопку запуска
            DrawLaunchButton(g);
        }

        private void DrawRocket(Graphics g, int x, int y)
        {
            // Корпус ракеты
            g.FillRectangle(rocketBrush, x, y, rocketWidth, rocketHeight);

            // Нос ракеты
            Point[] nose = new Point[]
            {
                new Point(x, y),
                new Point(x + rocketWidth / 2, y - 20),
                new Point(x + rocketWidth, y)
            };
            g.FillPolygon(rocketBrush, nose);

            // Окно
            g.FillEllipse(Brushes.Cyan, x + rocketWidth / 2 - 10, y + 20, 20, 20);

            // Стабилизаторы
            g.FillRectangle(rocketBrush, x - 10, y + rocketHeight - 20, 10, 20);
            g.FillRectangle(rocketBrush, x + rocketWidth, y + rocketHeight - 20, 10, 20);
        }

        private void DrawRocketWithFlame(Graphics g, int x, int y)
        {
            DrawRocket(g, x, y);

            // Огонь из двигателя
            Point[] flame = new Point[]
            {
                new Point(x + 5, y + rocketHeight),
                new Point(x + rocketWidth/2, y + rocketHeight + 30),
                new Point(x + rocketWidth - 5, y + rocketHeight)
            };
            g.FillPolygon(flameBrush, flame);
        }

        private void DrawStars(Graphics g)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int x = rand.Next(0, this.ClientSize.Width);
                int y = rand.Next(0, groundLevel);
                g.FillEllipse(Brushes.White, x, y, 2, 2);
            }
        }

        private void DrawLaunchButton(Graphics g)
        {
            int buttonSize = 60;
            int buttonX = this.ClientSize.Width - buttonSize - 20;
            int buttonY = this.ClientSize.Height - buttonSize - 20;

            g.FillEllipse(buttonBrush, buttonX, buttonY, buttonSize, buttonSize);
            g.DrawEllipse(buttonBorderPen, buttonX, buttonY, buttonSize, buttonSize);
            g.DrawString("СТАРТ", new Font("Arial", 8, FontStyle.Bold), Brushes.White,
                        buttonX + buttonSize / 2 - 20, buttonY + buttonSize / 2 - 10);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int buttonSize = 60;
            int buttonX = this.ClientSize.Width - buttonSize - 20;
            int buttonY = this.ClientSize.Height - buttonSize - 20;

            if (e.X >= buttonX && e.X <= buttonX + buttonSize &&
                e.Y >= buttonY && e.Y <= buttonY + buttonSize && !isLaunching)
            {
                LaunchRocket();
            }
        }

        private async void LaunchRocket()
        {
            isLaunching = true;

            // Анимация взлета
            for (int i = 0; i < 100; i++)
            {
                rocketY -= 5;

                // Уменьшаем размер пламени при наборе высоты
                if (i > 50)
                {
                    rocketHeight = Math.Max(40, 80 - (i - 50));
                }

                this.Invalidate();
                await Task.Delay(50);
            }

            // Завершение анимации
            MessageBox.Show("Ракета успешно вышла на орбиту!", "Запуск завершен");
            isLaunching = false;
            rocketY = groundLevel - 80;
            rocketHeight = 80;
            this.Invalidate();
        }
    }
}