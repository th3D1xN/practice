using System;
using System.Drawing;
using System.Windows.Forms;

namespace zadanie4
{
    public partial class Form1 : Form
    {
        Bitmap sky, plane;
        Graphics g;
        int dx = 5;
        Rectangle rct;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            // Настройка окна
            this.ClientSize = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Летящий самолёт";
            this.BackColor = Color.LightBlue;

            // Загрузка или создание изображений
            try
            {
                sky = new Bitmap("sky.bmp");
                plane = new Bitmap("plane.bmp");
                plane.MakeTransparent(plane.GetPixel(0, 0));
                this.BackgroundImage = new Bitmap(sky, this.ClientSize);
            }
            catch
            {
                CreateTestImages();
            }

            g = Graphics.FromImage(this.BackgroundImage);

            // Начальное положение самолёта
            rct = new Rectangle(
                x: -100,
                y: rnd.Next(50, this.ClientSize.Height - 100),
                width: plane?.Width ?? 100,  // Если plane null, используем 100
                height: plane?.Height ?? 50
            );

            timer2.Interval = 20;
            timer2.Tick += Timer_Tick;
            timer2.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновление фона
            g.DrawImage(this.BackgroundImage, 0, 0);

            // Движение самолёта
            rct.X += dx;

            if (rct.X > this.ClientSize.Width)
            {
                rct.X = -rct.Width;
                rct.Y = rnd.Next(50, this.ClientSize.Height - 100);
                dx = 3 + rnd.Next(7);
            }

            g.DrawImage(plane, rct);
            this.Invalidate();
        }

        private void CreateTestImages()
        {
            // Создаём небо
            sky = new Bitmap(800, 600);
            using (var gSky = Graphics.FromImage(sky))
            {
                gSky.Clear(Color.SkyBlue);

                // Рисуем облака
                for (int i = 0; i < 10; i++)
                {
                    gSky.FillEllipse(Brushes.White,
                        rnd.Next(sky.Width),
                        rnd.Next(sky.Height),
                        100, 50);
                }
            }

            // Создаём самолёт
            plane = new Bitmap(100, 50);
            using (var gPlane = Graphics.FromImage(plane))
            {
                gPlane.Clear(Color.Magenta);

                // Корпус (прямоугольник)
                gPlane.FillRectangle(Brushes.Gray, 10, 20, 70, 15);

                // Крылья (треугольник через FillPolygon)
                gPlane.FillPolygon(Brushes.DarkGray, new Point[] {
                    new Point(30, 20),
                    new Point(60, 20),
                    new Point(80, 5)
                });

                // Хвост (треугольник через FillPolygon)
                gPlane.FillPolygon(Brushes.Gray, new Point[] {
                    new Point(70, 20),
                    new Point(90, 20),
                    new Point(80, 35)
                });
            }
            plane.MakeTransparent(Color.Magenta);

            this.BackgroundImage = sky;
        }
    }
}