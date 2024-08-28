using System.Globalization;

namespace Day7
{
    internal class Program
    {
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for employee data and 2 for using swap function:");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Employee employee;
                Console.WriteLine("Enter the employee ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the security level:");
                int securityLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the salary:");
                decimal salary = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Hiring day:");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hiring month:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hiring year:");
                int year = int.Parse(Console.ReadLine());
                
                
                Console.WriteLine("Enter the gender (Male/Female):");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

                employee = new Employee(id, securityLevel, salary, new HiringDate(day, month, year), gender);

                Console.WriteLine("Employee details:");
                Console.WriteLine(employee.ToString());


            }
            else if (choice == 2)
            {
                int num1, num2;
                Console.WriteLine("Enter two numbers:");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Before swap: num1 = " + num1 + ", num2 = " + num2);
                swap(ref num1, ref num2);
                Console.WriteLine("After swap: num1 = " + num1 + ", num2 = " + num2);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
