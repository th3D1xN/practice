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

namespace zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int buttonCount = 1;
        public MainWindow()
        {
            InitializeComponent();
            CreateNewButton();
        }
        private void CreateNewButton()
        {
            Button btn = new Button
            {
                Content = $"Кнопка {buttonCount++}",
                Width = 100,
                Height = 40,
                Margin = new Thickness(5)
            };

            btn.MouseEnter += Btn_MouseEnter;
            btn.Click += Btn_Click;

            buttonPanel.Children.Add(btn);
        }

        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            CreateNewButton();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                buttonPanel.Children.Remove(btn);
            }
        }
    }
}
