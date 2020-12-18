using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public  class FullTimeEmployees : Employee
	{

		public FullTimeEmployees(string firstname, string lastname, decimal hourlypay, double hourworked) : base(firstname, lastname)
		{
			Salary = Salary;
		}

		public decimal Salary { get; set; }
		//override Method
		public override decimal CalculateMonthlyPay()
		{
			return Convert.ToDecimal(Salary / 12);//calculate the employee salary
		}
		//Type of Employee seleted 
		public override string ToString()
		{
			return base.ToString() + "-Full Time";
		}



	}
	






}
