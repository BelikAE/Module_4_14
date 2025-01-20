using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Module_4_14
{
    

    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Яблоко",
                ProductPrice = 260,
                ProductImage = "Data\\Apple.jpg",
                Category = ProductCategory.Food
            });
            products.Add(new Product()
            {
                ProductName = "Манго",
                ProductPrice = 420,
                ProductImage = "Data\\Mango.jpg",
                Category = ProductCategory.Food
            });
            products.Add(new Product()
            {
                ProductName = "Апельсин",
                ProductPrice = 360,
                ProductImage = "Data\\Orange.jpg",
                Category = ProductCategory.Food
            });
            products.Add(new Product()
            {
                ProductName = "Утюг",
                ProductPrice = 5600,
                ProductImage = "Data\\Iron.jpg",
                Category = ProductCategory.HouseholdAppliances
            });
            products.Add(new Product()
            {
                ProductName = "Ноутбук",
                ProductPrice = 86000,
                ProductImage = "Data\\Laptop.jpg",
                Category = ProductCategory.HouseholdAppliances
            });
            products.Add(new Product()
            {
                ProductName = "Робот-пылесос",
                ProductPrice = 46000,
                ProductImage = "Data\\Robot.jpg",
                Category = ProductCategory.HouseholdAppliances
            });
            listBox.ItemsSource = products;
        }
    }
}
