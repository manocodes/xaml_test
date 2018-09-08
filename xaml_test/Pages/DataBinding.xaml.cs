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
using System.Windows.Shapes;

namespace xaml_test
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	/// 

	public partial class DataBinding : Window
    {

		Dictionary<string, int> dict = new Dictionary<string, int>();

		public DataBinding()
		{
			InitializeComponent();
			Employee emp = getEmployee();
			names.Text = emp.Name;
		}

		public void onClick(object sender, RoutedEventArgs e)
		{
			Employee emp = getEmployee();
			names.Text = names.Text + ", " + emp.Name;
		}

		private Employee getEmployee()
		{
			Employee emp = Employee.GetEmployee();
			DataContext = emp;			
			return emp;
		}
	}
}
