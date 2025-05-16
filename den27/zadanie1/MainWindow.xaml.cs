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
using Microsoft.Win32;
using zadanie1.Models;
using zadanie1.Share;
using System.IO;

namespace zadanie1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string currentFilePath;
        private XmlDocumentWorker xmlWorker = new XmlDocumentWorker();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            // Указываем полный путь к файлу
            currentFilePath = @"D:\\коды\\practic\\den27\\zadanie1\\Files\\products.xml"; // Замените на реальный путь

            if (File.Exists(currentFilePath))
            {
                btnAdd.IsEnabled = true;
                DisplayProducts();
            }
            else
            {
                MessageBox.Show("Файл не найден по указанному пути!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DisplayProducts()
        {
            try
            {
                if (string.IsNullOrEmpty(currentFilePath) || !File.Exists(currentFilePath))
                {
                    MessageBox.Show("Файл не выбран или не существует!");
                    return;
                }

                var products = xmlWorker.LoadProducts(currentFilePath);

                if (products == null || products.Count == 0)
                {
                    txtDisplay.Text = "Файл не содержит товаров или имеет неверный формат";
                    return;
                }

                StringBuilder sb = new StringBuilder();
                foreach (var product in products)
                {
                    sb.AppendLine($"Название: {product.Name}");
                    sb.AppendLine($"Срок годности: {product.ExpiryDate}");
                    sb.AppendLine($"Цена: {product.Price} руб.");
                    sb.AppendLine(new string('-', 30));
                }
                txtDisplay.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки XML: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDate.Text) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Введите корректные данные!");
                return;
            }

            var newProduct = new Product
            {
                Name = txtName.Text,
                ExpiryDate = txtDate.Text,
                Price = price
            };

            xmlWorker.AddProduct(currentFilePath, newProduct);
            DisplayProducts();

            // Очистка полей
            txtName.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
        }
    }
}
