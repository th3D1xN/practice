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

namespace zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Приложение Hello Name";
            buttonRun.Click += ButtonRun_Click;
            buttonAbout.Click += ButtonAbout_Click;
            buttonClose.Click += ButtonClose_Click;
        }

        private void ButtonRun_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string input = string.Empty;
            if (string.IsNullOrEmpty(textBoxEnterName.Text)
                || string.IsNullOrWhiteSpace(textBoxEnterName.Text))
            {
                input = "World";
            }
            else
            {
                input = textBoxEnterName.Text;
            }
            textBlockHello.Text = $"{hello} {input}";
        }

        private void ButtonAbout_Click(object sender, RoutedEventArgs e)
        {
            string info = $"О программе {this.Title}";
            AboutApp aboutApp = new AboutApp(info);
            aboutApp.ShowDialog();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
