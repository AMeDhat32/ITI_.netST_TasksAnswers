using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iti_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the first number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("choose the operation \n1)+\n2)-\n3)*\n4)/");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter the second number");
            double b = Convert.ToDouble(Console.ReadLine());

            
            switch (op)
            {
                case '+':                
                    Console.WriteLine("result : " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("result : " + (a - b));
                    break;
                case '*':
                    
                    Console.WriteLine("result : " + (a * b));
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("You can't divide by zero");
                    }else
                    {
                        Console.WriteLine("result : " + (a / b));
                    }
                    break;

            }
        }
    }
}
