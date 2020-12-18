using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public  class PartTimeEmployees :Employee
	{
		public PartTimeEmployees(string firstname, string lastname, decimal hourlypay, double hourworked):base(firstname,lastname)
			{
			HourlyRate = hourlypay;
			HoursWorked = hourworked;
		}


		public  decimal  HourlyRate { get;set; }

		public  double HoursWorked { get; set; }
		//override Method 
		public override decimal CalculateMonthlyPay()
		{
			return Convert.ToDecimal(HourlyRate )*Convert.ToDecimal( HoursWorked);//employee hour rate and work
		}
		//Type of Employee seleted 
		public override string ToString()
		{
			return base.ToString() + "-Part Time";
		}




	}
}
