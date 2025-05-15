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
            buttonCalculate.Click += ButtonCalculate_Click;
        }
        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            listBoxResults.Items.Clear();
            canvasGraph.Children.Clear(); // Очистка предыдущего графика

            if (double.TryParse(textBoxXStart.Text, out double xStart) &&
                double.TryParse(textBoxXEnd.Text, out double xEnd) &&
                double.TryParse(textBoxStep.Text, out double h))
            {
                if (h <= 0 || xEnd < xStart)
                {
                    MessageBox.Show("Проверьте значения: шаг должен быть > 0, X конец > X нач.", "Ошибка");
                    return;
                }

                double maxX = xEnd;
                double maxY = Math.Sqrt(Math.Max(0, xEnd));
                double width = canvasGraph.ActualWidth;
                double height = canvasGraph.ActualHeight;

                Polyline graphLine = new Polyline
                {
                    Stroke = Brushes.Blue,
                    StrokeThickness = 2
                };

                for (double x = xStart; x <= xEnd; x += h)
                {
                    if (x >= 0)
                    {
                        double y = Math.Sqrt(x);
                        listBoxResults.Items.Add($"x = {x:F2}\ty = {y:F4}");

                        // Преобразуем координаты для Canvas
                        double px = (x - xStart) / (maxX - xStart) * width;
                        double py = height - (y / maxY * height);
                        graphLine.Points.Add(new Point(px, py));
                    }
                    else
                    {
                        listBoxResults.Items.Add($"x = {x:F2}\ty = ОШИБКА (отрицательный x)");
                    }
                }

                canvasGraph.Children.Add(graphLine);
            }
            else
            {
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка");
            }
        }
    }
}
