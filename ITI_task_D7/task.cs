using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskD6
{
    internal class Program
    {
        static void task1()
        {
            // Mutable: Data types that can be changed after creation.
            //Mutable: List, Dictionary, Array (of non-primitive types)

            //Immutable: Data types that remain unchanged after creation.
            //Immutable: String, Int32, Double, other primitive data types, Tuple (depending on implementation)
        }
        static void task2()
        {
            //jagged array
            //Jagged array: Array of arrays in C#, with variable-sized inner arrays
            int[][] scores = new int[2][]
            {
                new int[] { 90, 85, 77 }, 
                new int[] { 88, 92 } 
            };

        }
        //Task 3
        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int FindMin(int[] arr)
        {
            int min = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static int FindSum(int[] arr)
        {
            int sum = 0; 
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int Task4()
        {
            int sum = 0;
            while (true)
            {
                int num = 0;
                Console.WriteLine("Enter number");
                num = int.Parse(Console.ReadLine());
                if (num == 0 || num >= 100) break;
                sum+= num;
            }
            return sum;
        }

        static void task5()
        {
            Console.WriteLine("Enter String");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            
            for(int i = 0, j = words.Length - 1; j >=words.Length/2; i ++, j--)
            {
                string temp = words[j];
                words[j] = words[i];
                words[i] = temp;
            }
           Console.WriteLine(string.Join(" ", words));
        }
        static void task6()
        {
            int rows, cols;

            
            Console.Write("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());

           
            int[][] arr = new int[rows][];

            
            for (int i = 0; i < rows; i++)
            {
                arr[i] = new int[cols];
              
                for (int j = 0; j < cols; j++)
                {
                   
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int j = 0; j < cols; j++)
            {
                double sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += arr[i][j];
                }
                double average = sum / rows;
                Console.WriteLine($"Average of column {j + 1}: {average:F2}"); // Format average with 2 decimal places
            }
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }*/


            task6();
           
        }
    }
}