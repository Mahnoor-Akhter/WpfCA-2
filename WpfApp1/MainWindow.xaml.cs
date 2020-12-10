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
		ObservableCollection<Employees> Employees = new ObservableCollection<Employees>();


		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{

			//string [] names= {"jane","joe","jones","jess"};
			Employees e1 = new Employees("Jane", "Jones", "Part Time");
			Employees e2 = new Employees("Joe", "Murphy", "Full Time");
			Employees e3 = new Employees("John", "Smith", "Part Time");
			Employees e4 = new Employees("Jess", "Walsh", "Full Time");

			Employees.Add(e1);
			Employees.Add(e2);
			Employees.Add(e3);
			Employees.Add(e4);

			lbxName.ItemsSource = Employees;



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
			string time = rbfulltime.Name;

			//create employees object
			Employees employees = new Employees(firstName, lastName, time);
			//add to observalbe collection
			Employees.Add(employees);



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
