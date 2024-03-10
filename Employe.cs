using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LB6
{
    public  class Employee
    {
        public string PIP { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public string Responsib { get; set; }
        public decimal Salary {  get; set; }

        public static Employee operator + (Employee left, decimal right)
        {
            return new Employee {  Salary = left.Salary+ right};
        }

        public static Employee operator -(Employee left, decimal right)
        {
            return new Employee { Salary = left.Salary - right };
        }

        public static bool operator != (Employee left, Employee right)
        {
            return left.Salary != right.Salary;
        }

        public static bool operator ==(Employee left, Employee right)
        {
            return left.Salary == right.Salary;
        }

        public static bool operator >(Employee left, Employee right)
        {
            return left.Salary > right.Salary;
        }

        public static bool operator <(Employee left, Employee right)
        {
            return left.Salary < right.Salary;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Employee)
            {
                Employee emp = (Employee)obj;
                return this.Salary == emp.Salary;
            }
            return false;
        }

        


    }

}
