using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	public class Employees
	{
		public string FirstName { get; set; }


		public string LastName { get; set; }

		public string Time { get; set; }
		


		public Employees(string firstname,string lastname,string time )
		{
			FirstName = firstname;
			LastName = lastname;
			Time = time;


		}
		public override string ToString()
		{
			return string.Format($"{LastName},{FirstName},{Time}");
		}







	}
}
