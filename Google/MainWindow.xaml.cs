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

namespace Google
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mains.WindowState = System.Windows.WindowState.Maximized;

            google.Navigate("https://www.google.kz/webhp?hl=ru&sa=X&ved=0ahUKEwinovWr4ZjiAhViposKHeh8AOgQPAgH");

        }

        private void AddItems(object sender, MouseButtonEventArgs e)
        {
            var items = Control.Items;

            WebBrowser web = new WebBrowser();
            web.Navigate("https://www.google.kz/webhp?hl=ru&sa=X&ved=0ahUKEwinovWr4ZjiAhViposKHeh8AOgQPAgH");

            items.RemoveAt(items.Count - 1);

            items.Add(new TabItem
            {
                Header = new TextBlock { Text = "GoogleSearch" },
                Content = web
            });

            TabItem item = new TabItem
            {
                Header = new TextBlock { Text = "+" }
            };
            item.PreviewMouseLeftButtonDown += AddItems;
            items.Add(item);

            Control.SelectedIndex = items.Count - 2;
        }
    }
}
