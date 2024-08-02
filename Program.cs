using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction to program
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Input from employees
            Console.WriteLine("Person 1, what is your hourly rate?");
            int person1HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week do you work?");
            int person1HoursPerWeek = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Person 2, what is your hourly rate?");
            int person2HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many hours per week do you work?");
            int person2HoursPerWeek = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 1:");
            int person1WeeklySalary = (person1HourlyRate * person1HoursPerWeek);
            int person1AnnualSalary = (person1WeeklySalary * 52);
            Console.WriteLine(person1AnnualSalary);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2:");
            int person2WeeklySalary = (person2HourlyRate * person2HoursPerWeek);
            int person2AnnualSalary = (person2WeeklySalary * 52);
            Console.WriteLine(person2AnnualSalary);
            Console.ReadLine();

            //A greater than, less than, or equal too statement
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = person1AnnualSalary > person2AnnualSalary;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
