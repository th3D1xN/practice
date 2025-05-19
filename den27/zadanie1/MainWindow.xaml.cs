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
    public partial class MainWindow : Window
    {
        private string currentFilePath;
        private XmlDocumentWorker xmlWorker = new XmlDocumentWorker();

        public MainWindow()
        {
            InitializeComponent();
            rbTextBlock.Checked += DisplayType_Checked;
            rbTreeView.Checked += DisplayType_Checked;
            rbListBox.Checked += DisplayType_Checked;
        }

        private void DisplayType_Checked(object sender, RoutedEventArgs e)
        {
            if (!IsLoaded) return;

            txtDisplay.Visibility = rbTextBlock.IsChecked == true ? Visibility.Visible : Visibility.Collapsed;
            treeViewDisplay.Visibility = rbTreeView.IsChecked == true ? Visibility.Visible : Visibility.Collapsed;
            listBoxDisplay.Visibility = rbListBox.IsChecked == true ? Visibility.Visible : Visibility.Collapsed;

            if (!string.IsNullOrEmpty(currentFilePath))
            {
                DisplayProducts();
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            currentFilePath = @"D:\\коды\\practic\\den27\\zadanie1\\Files\\products.xml";

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

                if (rbTextBlock.IsChecked == true)
                {
                    DisplayInTextBlock(products);
                }
                else if (rbTreeView.IsChecked == true)
                {
                    DisplayInTreeView(products);
                }
                else if (rbListBox.IsChecked == true)
                {
                    DisplayInListBox(products);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки XML: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DisplayInTextBlock(List<Product> products)
        {
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

        private void DisplayInTreeView(List<Product> products)
        {
            treeViewDisplay.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Товары";
            root.IsExpanded = true;

            foreach (var product in products)
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = product.Name;

                TreeViewItem expiryItem = new TreeViewItem();
                expiryItem.Header = $"Срок годности: {product.ExpiryDate}";
                item.Items.Add(expiryItem);

                TreeViewItem priceItem = new TreeViewItem();
                priceItem.Header = $"Цена: {product.Price} руб.";
                item.Items.Add(priceItem);

                root.Items.Add(item);
            }

            treeViewDisplay.Items.Add(root);
        }

        private void DisplayInListBox(List<Product> products)
        {
            listBoxDisplay.Items.Clear();
            foreach (var product in products)
            {
                listBoxDisplay.Items.Add($"Название: {product.Name}");
                listBoxDisplay.Items.Add($"Срок годности: {product.ExpiryDate}");
                listBoxDisplay.Items.Add($"Цена: {product.Price} руб.");
                listBoxDisplay.Items.Add(new string('-', 30));
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

            txtName.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
        }
    }
}