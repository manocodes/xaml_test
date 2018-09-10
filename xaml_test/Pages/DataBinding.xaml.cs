using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Web;
using Newtonsoft.Json.Serialization;

namespace xaml_test
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	/// 

	public partial class DataBinding : Window
    {

		Dictionary<string, int> dict = new Dictionary<string, int>();
		public class empCount
		{
			public string Name;
			public int eCount;
		}

		public ObservableCollection<empCount> empCounts = new ObservableCollection<empCount>();

		public DataBinding()
		{
			InitializeComponent();
			Employee emp = getEmployee();
			names.Text = emp.Name;

			updateEmpCount(emp);

		}

		private void updateEmpCount(Employee emp)
		{
			bool found = false;
			for (int icount = 0; icount < empCounts.Count; icount++)
			{
				if (emp.Name == empCounts[icount].Name)
				{
					empCounts[icount].eCount = empCounts[icount].eCount + 1;


					found = true;
				}
			}

			if (found == false)
			{
				empCount test = new empCount();
				test.Name = emp.Name;
				test.eCount = 1;

				empCounts.Add(test);
			}

			empCountsUI.DataContext = empCounts;

			var jsonstring = Newtonsoft.Json.JsonConvert.SerializeObject(empCounts);

			MessageBox.Show(jsonstring);

		}

		public void onClick(object sender, RoutedEventArgs e)
		{
			Employee emp = getEmployee();
			names.Text = names.Text + ", " + emp.Name;


			updateEmpCount(emp);

		}

		private Employee getEmployee()
		{
			Employee emp = Employee.GetEmployee();
			DataContext = emp;			
			return emp;
		}
	}
}




