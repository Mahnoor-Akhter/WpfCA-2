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

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
		decimal salary;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{

		     //string [] names= {"jane","joe","jones","jess"};
			Employee e1 = new PartTimeEmployees("Jane", "Jones", Convert.ToDecimal(9.50), 10);
			Employee e2 = new  FullTimeEmployees("Joe", "Murphy", Convert.ToDecimal(10.50), 10);
			Employee e3 = new FullTimeEmployees("John", "Smith", Convert.ToDecimal(11.50), 10);
			Employee e4 = new PartTimeEmployees("Jess", "Walsh", Convert.ToDecimal(12.50), 10);

			employees.Add(e1);
			employees.Add(e2);
			employees.Add(e3);
			employees.Add(e4);

			lbxName.ItemsSource = employees;



		}

		private void tbxfirstname_GotFocus(object sender, RoutedEventArgs e)
		{
			tbxfirstname.Clear();
		}

		private void btxaddname_Click(object sender, RoutedEventArgs e)
		{
			//read details from screen
			string firstName = tbxfirstname.Text;
			string lastName = tbxlastname.Text;
			decimal hourlyrate = Convert.ToDecimal (tbxhrinput.Text);
			double hoursworked = Convert.ToDouble(tbxHWinput1.Text);
			//create employees object



			//add to  obervable collection

			//check which radio button is selected 


			//if radiobutton full time then create full time employee
			if (rbfulltime.IsChecked == true)
			{
				//create a full time employee
				Employee e1 = new FullTimeEmployees(firstName, lastName, hourlyrate, hoursworked);


			}
			//else if pt rb then create part time employee
			else if (rbparttime.IsChecked == true)
		   {
				Employee e1 = new PartTimeEmployees(firstName, lastName, hourlyrate, hoursworked);
			    salary = e1.CalculateMonthlyPay();
				employees.Add(e1);
			}







			
			//add to observalbe collection
			



			//refresh display manually


			//lbxNames.ItemsSource = null;
			//lbxNames.ItemsSource = names;

		}



		private void tbxlastname_GotFocus(object sender, RoutedEventArgs e)
		{
			tbxlastname.Clear();
		}

		
	}
}
