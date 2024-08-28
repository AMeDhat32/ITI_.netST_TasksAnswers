namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the {i + 1} employee's details :");
                employees[i] = implementEmployee();
            }

            // Display the employees
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
            // choose between developer or HR
            Console.WriteLine("Choose between Developer or HR:");
            string choice = Console.ReadLine();
            if (choice == "Developer")
            {
              Developer Dev = (Developer)implementEmployee();
                Console.WriteLine(Dev);
                Dev.develop();

            }
            else if (choice == "HR")
            {
                HR hR = (HR)implementEmployee();
                Console.WriteLine(hR);
                hR.hire();
            }
        }

        static Employee implementEmployee()
        {
            Employee employee = new Employee();

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

            return employee;
        }
    }
}
