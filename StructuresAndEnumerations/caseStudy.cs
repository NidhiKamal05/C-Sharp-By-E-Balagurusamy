using System;
using System.Collections.Generic;
using System.Text;
namespace StructureExample
{
	public struct  Employee
	{
		private string emp_details;
		
		public string Write
		{
			get { return emp_details; }
			set { emp_details = value; }
		}
		public string Read()
		{
			return Console.ReadLine();
		}
	}
	public struct EmployeeDetails
	{
		Employee name;
		Employee address;
		Employee telephone;
		Employee dept;
		Employee sal;
		public Employee Name
		{
			get { return name; }
			set { name = value; }
		}
		public Employee Address
		{
			get { return address; }
			set { address = value; }
		}
		public Employee Telephone
		{
			get { return telephone; }
			set { telephone = value; }
		}
		public Employee Department
		{
			get { return dept; }
			set { dept = value; }
		}
		public Employee Salary
		{
			get { return sal; }
			set { sal = value; }
		}
		public void ShowAllDetails()
		{
			Employee emp = new Employee();
			Console.WriteLine("Employee Details Registration System.");
			Console.WriteLine("-------------------------------------");
			Console.Write("Enter the Name of the Employee: ");
			name.Write = emp.Read();
			Console.Write("Enter the Address of the Employee: ");
			address.Write = emp.Read();
			Console.Write("Enter the telephone of the Employee: ");
			telephone.Write = emp.Read();
			Console.Write("Enter the Department of the Employee: ");
			dept.Write = emp.Read();
			Console.Write("Enter the Salary of the Employee: ");
			sal.Write = emp.Read();
		}
	}
	class ShowEmployeeDetails
	{
		static void Main(string[] args)
		{
			string input = "";
			EmployeeDetails emp1 = new EmployeeDetails();
			emp1.ShowAllDetails();
			Console.WriteLine();
			Console.WriteLine("Showing Employee Details");
			Console.WriteLine("------------------------");
			Console.WriteLine("Name: {0}", emp1.Name.Write);
			Console.WriteLine("Address: {0}", emp1.Address.Write);
			Console.WriteLine("Telephone: {0}", emp1.Telephone.Write);
			Console.WriteLine("Department: {0}", emp1.Department.Write);
			Console.WriteLine("Salary: {0}", emp1.Salary.Write);
			Console.WriteLine("------------------------");
			Console.WriteLine("Press y to save the record....");
			input = Console.ReadLine();
			if(input == "y")
			{
				Console.WriteLine("Record Saved.");
			}
			else
			{
				Console.WriteLine("Record not saved.") ;
			}
		}
	}
}