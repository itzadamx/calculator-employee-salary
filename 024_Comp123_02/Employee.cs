using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Comp123_02
{
    class Employee
    { 
        private int employeeUserId;
        private string firstName;
        private string lastName;
        private double baseSalary = 3000;
        private double grossSales;
        private double comissionRate = 0.3;

        public int EmployeeUserId { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double BaseSalary { get; set; }
        public double GrossSales { get; set; }

        public double ComissionRate { get; set; }

        public Employee()
        {
            employeeUserId = EmployeeUserId;
            firstName = FirstName;
            lastName = LastName;
            baseSalary = BaseSalary;
            grossSales = GrossSales;
            comissionRate = ComissionRate;
        }
        //constructor
        public Employee(int employeeUserId, string firstName, double baseSalary)
        {
            employeeUserId = EmployeeUserId;
            firstName = FirstName;
            baseSalary = BaseSalary;
        }
        public double Earnings()
        {
            double commission = ComissionRate * GrossSales + BaseSalary;
            return commission;
        }

    }
}
