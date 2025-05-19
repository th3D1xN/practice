using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zadanie3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawShapes();   
        }
        private void DrawShapes()
        {
            // Очищаем canvas перед рисованием
            mainCanvas.Children.Clear();

            // 1. Оригинальные 5 фигур
            DrawOriginalShapes();

            // 2. Три концентрических круга
            DrawConcentricCircles(900, 200, 180, 3);

            // 3. 5 вертикальных прямоугольников с диагональным смещением
            DrawVerticalRectangles(850, 700, 50, 150, 5);

            // 4. Шахматное поле
            DrawChessBoard(100, 700, 200, 8);
        }

        private void DrawOriginalShapes()
        {
            // 1. Треугольник (синий контур)
            var triangle = new Polygon
            {
                Points = new PointCollection { new Point(100, 100), new Point(250, 250), new Point(0, 250) },
                Stroke = Brushes.Blue,
                StrokeThickness = 3,
                Fill = Brushes.Transparent
            };
            mainCanvas.Children.Add(triangle);

            // 2. Эллипс (зеленый контур)
            var ellipse = new Ellipse
            {
                Width = 250,
                Height = 150,
                Stroke = Brushes.Green,
                StrokeThickness = 3,
                Fill = Brushes.Transparent
            };
            Canvas.SetLeft(ellipse, 350);
            Canvas.SetTop(ellipse, 100);
            mainCanvas.Children.Add(ellipse);

            // 3. Закрашенный круг (красный)
            var circle = new Ellipse
            {
                Width = 200,
                Height = 200,
                Fill = Brushes.Red
            };
            Canvas.SetLeft(circle, 100);
            Canvas.SetTop(circle, 400);
            mainCanvas.Children.Add(circle);

            // 4. Закрашенный прямоугольник (оранжевый)
            var rectangle = new Rectangle
            {
                Width = 220,
                Height = 150,
                Fill = Brushes.Orange
            };
            Canvas.SetLeft(rectangle, 450);
            Canvas.SetTop(rectangle, 400);
            mainCanvas.Children.Add(rectangle);

            // 5. Сектор (фиолетовый)
            var path = new Path
            {
                Fill = Brushes.Purple,
                Data = Geometry.Parse("M 350,650 A 125,125 0 0 1 475,775 L 475,650 Z")
            };
            mainCanvas.Children.Add(path);
        }

        private void DrawConcentricCircles(double centerX, double centerY, double outerRadius, int count)
        {
            Color[] colors = { Colors.Red, Colors.Blue, Colors.Green };

            for (int i = 0; i < count; i++)
            {
                double radius = outerRadius - (i * (outerRadius / count));
                var circle = new Ellipse
                {
                    Width = radius * 2,
                    Height = radius * 2,
                    Stroke = new SolidColorBrush(colors[i % colors.Length]),
                    StrokeThickness = 3,
                    Fill = Brushes.Transparent
                };
                Canvas.SetLeft(circle, centerX - radius);
                Canvas.SetTop(circle, centerY - radius);
                mainCanvas.Children.Add(circle);
            }
        }

        private void DrawVerticalRectangles(double startX, double startY, double width, double height, int count)
        {
            for (int i = 0; i < count; i++)
            {
                double x = startX + (i * width / 2);
                double y = startY + (i * height / 4);

                var rect = new Rectangle
                {
                    Width = width,
                    Height = height,
                    Fill = i % 2 == 0 ? Brushes.DarkBlue : Brushes.LightBlue,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1
                };
                Canvas.SetLeft(rect, x);
                Canvas.SetTop(rect, y);
                mainCanvas.Children.Add(rect);
            }
        }

        private void DrawChessBoard(double startX, double startY, double size, int cells)
        {
            double cellSize = size / cells;

            for (int row = 0; row < cells; row++)
            {
                for (int col = 0; col < cells; col++)
                {
                    var rect = new Rectangle
                    {
                        Width = cellSize,
                        Height = cellSize,
                        Fill = (row + col) % 2 == 0 ? Brushes.Black : Brushes.White,
                        Stroke = Brushes.Gray,
                        StrokeThickness = 0.5
                    };
                    Canvas.SetLeft(rect, startX + col * cellSize);
                    Canvas.SetTop(rect, startY + row * cellSize);
                    mainCanvas.Children.Add(rect);
                }
            }
        }
    }
}
