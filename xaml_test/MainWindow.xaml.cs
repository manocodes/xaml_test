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
using System.Collections.ObjectModel;

namespace xaml_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn.Click += btn_click;

            ObservableCollection<Employee> empData = Employee.GetEmployees();
            dataGrid.ItemsSource = empData;

            listView.ItemsSource = empData;
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hellp world");
        }


    }
}
