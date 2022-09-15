using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14sep
{
    public class Employee
    {
        int empid;
        string empname;
        int basic_salary;
        int allowances;
        int total_salary;
        int net_paid_salary;

        public Employee()
        {
            empid = 3;
            empname = "Abhay";
            basic_salary = 50000;
            allowances = 5000;
        }

        public Employee(int empid, string empname, int basic_salary, int allowances)
        {
            this.empid = empid;
            this.empname = empname;
            this.basic_salary = basic_salary;
            this.allowances = allowances;
        }

        public void CalculateSalary()
        {
            total_salary = basic_salary + allowances;
            net_paid_salary = total_salary - allowances;
        }

        public void Print()
        {
            Console.WriteLine($" Employee {empname} with id {empid} has net paid salary of {net_paid_salary}"); 
        }

    }
}
