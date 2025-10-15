using OOP.Models;

namespace OOP
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //String s1 = new String("yousif");
            //int x = 10;
            #region EmployeeFirst
            //Employee emp = new Employee();
            // emp.Id = 1;
            // emp.Fname = "Yousif";
            // emp.Lname = "Ebrahim";
            // emp.Wage = 3;
            // emp.loggedHours = 10;

            // Console.WriteLine(emp);

            // Employee emp1 = new Employee();
            // emp1.Id = 2;
            // emp1.Fname = "Ahmed";
            // emp1.Lname = "Al Shanfary";
            // emp1.Wage = 10;
            // emp1.loggedHours = 50; 
            #endregion

            //استنادا علي القواهد البرمجية ان يمكن  انشاء ارراي من اي داتا طايب
            Employee[] emp = new Employee[3];

            for (int i = 0; i < emp.Length; i++)
            {
                emp[i] = new Employee();
                Console.WriteLine($"Please enter emp {i} First Name :");
                emp[i].Fname = Console.ReadLine();

                Console.WriteLine($"Please enter emp {i} Last Name :");
                emp[i].Lname = Console.ReadLine();

                Console.WriteLine($"Please enter emp{i} Wage (Rate per hour) :");
                emp[i].Wage = Decimal.Parse(Console.ReadLine());

                Console.WriteLine($"Please enter emp{i} Logged Hours (Working Hours) :");
                emp[i].loggedHours = double.Parse(Console.ReadLine());

            }

            foreach (Employee item in emp)
            {
                decimal NetSalary = (item.Wage * (decimal)item.loggedHours) - (item.Wage * (decimal)(item.loggedHours * Employee.TAX));
                Console.WriteLine($" Employee {item.Fname} : Net Salary is {NetSalary}"); 
            }







        }
    }
}
