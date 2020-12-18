using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	public abstract  class  Employee
	{
		
		public string FirstName { get; set; }


		public string LastName { get; set; }

		public abstract decimal CalculateMonthlyPay();




		public Employee(string firstname, string lastname)
		{
			FirstName = firstname;
			LastName = lastname;


		}




		public override string ToString()
		{
			return string.Format($"{LastName},{FirstName}");
		}







	}

	
}
