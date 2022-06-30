using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Comp123_02
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            // Group 024 members: Adam Daabaz- Ignacio Agustin Zuluaga -Sohyeon Song

            // Loop checkers for both Gross sales and commission rates.
            bool validGrossSale = false;
            bool validCommissionRate = false;

            // Intro for the user
            Console.WriteLine("---------* Employee Information *--------");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");

            // First object
            Employee employee1 = new Employee(301159644, "Ignacio", 4000);
            
            //Second object
            Employee employee2 = new Employee();
            Console.Write("Please insert your First Name:");
            employee2.FirstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please insert your Last name:");
            employee2.LastName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please insert your base salary:");
            employee2.BaseSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // checking the input for Gross sales and Commission rate.
            while (!validGrossSale)
            {
                try
                {
                    Console.Write("Please insert your gross sales:");
                    employee2.GrossSales = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (employee2.GrossSales <= 0)
                    {
                        throw new Exception(" ***INPUT-ERROR*** 'Gross sales cannot be negative or 0' ");
                    }
                    else
                    {
                        validGrossSale = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (!validCommissionRate)
            {
                try
                {
                    Console.Write("Please insert your commission rate:");
                    employee2.ComissionRate = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (employee2.ComissionRate <= 0)
                    {
                        Console.WriteLine();
                        throw new Exception(" ***INPUT-ERROR*** 'Commission rate cannot be negative or 0' ");
                    }
                    else if (employee2.ComissionRate < 0.2 || employee2.ComissionRate > 1)
                    {
                        Console.WriteLine();
                        throw new Exception(" ***INPUT-ERROR*** 'Commission rate should be in between 0.2 - 1' ");
                    }
                    else
                    {
                        validCommissionRate = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($" Hello Mr/Mrs {employee2.LastName}, your final Employee Earnings:{employee2.Earnings():C}");
            Console.ReadKey();
        }
    }
}

 
