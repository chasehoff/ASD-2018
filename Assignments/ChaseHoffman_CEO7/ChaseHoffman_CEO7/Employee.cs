using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaseHoffman_CEO7
{
    abstract class Employee
    {
        protected string Name { get; set; }
        protected string Address { get; set; }
        public Employee(string n, string a)
        {
            Name = n;
            Address = a;
        }
    }
    class Application
    {
        public void AddEmployee()
        {
            PartTime Carl = new PartTime("Carl", "WinterPark Florida 32792", 10.50m, 20m);
            FullTime Rick = new FullTime("Rick", "Ocoee Florida 23424", 13.50m, 40m);
            Manager Chase = new Manager("Chase", "2153 Crystal Cove", 45000m, 1000m);

            List<Employee> employeeRoster = new List<Employee>();
            employeeRoster.Add(Carl);
            employeeRoster.Add(Rick);
            employeeRoster.Add(Chase);

            int ur = Validation.ValidateInt($"What type of employee would you like to make?\r\n" +
                $"[1] - PartTime\r\n" +
                $"[2] - FullTime\r\n" +
                $"[3] - Manager");

            while (ur != 1 && ur != 2 && ur != 3 && ur != 4)
            {
                ur = Validation.ValidateInt("Please enter a valid answer...");
            }

            if (ur == 1)
            {
                string ename = Validation.ValidateString("Please enter the name of the employee...");
                string eaddress = Validation.ValidateString("Please enter the address of the employee...");
                decimal epph = Validation.ValidateDecimal("Please enter the pay per hour for this employee...");
                decimal ehpw = Validation.ValidateDecimal("Please enter the hours per week the employee works...");

                PartTime newPartTime = new PartTime(ename, eaddress, epph, ehpw);
                Console.WriteLine($"You have added a new PartTime employee, {ename}!");
                employeeRoster.Add(newPartTime);

            }
            else if (ur == 2)
            {
                string ename = Validation.ValidateString("Please enter the name of the employee...");
                string eaddress = Validation.ValidateString("Please enter the address of the employee...");
                decimal epph = Validation.ValidateDecimal("Please enter the pay per hour for this employee...");
                decimal ehpw = Validation.ValidateDecimal("Please enter the hours per week the employee works...");

                FullTime newFullTime = new FullTime(ename, eaddress, epph, ehpw);
                Console.WriteLine($"You have added the new employee {ename}!");
                employeeRoster.Add(newFullTime);
            }
            else if (ur == 3)
            {
                string ename = Validation.ValidateString("Please enter the name of the employee...");
                string eaddress = Validation.ValidateString("Please enter the address of the employee...");
                decimal salary = Validation.ValidateDecimal("Please enter the salary for this employee...");
                decimal bonus = Validation.ValidateDecimal("Please enter the bonus employee...");

                Manager newManager = new Manager(ename, eaddress, bonus, salary);
                Console.WriteLine($"You have added the new employee {ename}!");
                employeeRoster.Add(newManager);
            }
            else if (ur == 4)
            {
                string ename = Validation.ValidateString("Please enter the name of the employee...");
                string eaddress = Validation.ValidateString("Please enter the address of the employee...");
                decimal salary = Validation.ValidateDecimal("Please enter the salary for this employee...");
                decimal bonus = Validation.ValidateDecimal("Please enter the bonus employee...");

                Salaried newSalaried = new Salaried(ename, eaddress, salary);
                Console.WriteLine($"You have added the new employee {ename}!");
                employeeRoster.Add(newSalaried);
            }
            for (int i = 0; i<employeeRoster.Count; i++)
            {
                Console.WriteLine(employeeRoster[i]);
                Console.ReadKey();
            }
        }
    }
}
