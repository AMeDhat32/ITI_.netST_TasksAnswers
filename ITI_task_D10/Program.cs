namespace Day10
{
    internal class Program
    {
        static int compare(int a, int b)
        {
            return b>a ? 1 : -1;
        }

        static int sum(int n)
        {
            if (n == 0) return 0;

            return n + sum(n - 1);
        }

        static void Main(string[] args)
        {

           //#region  Sort an array in descending order
           // int size;
           // Console.WriteLine("Enter the size of the array");
           // size = Convert.ToInt32(Console.ReadLine());
           // int[] arr = new int[size];
           // Console.WriteLine("Enter the elements of the array");
           // for (int i = 0; i < size; i++)
           // {
           //     arr[i] = Convert.ToInt32(Console.ReadLine());
           // }
           // Array.Sort(arr, compare);
           // Console.WriteLine("The sorted array is:");
           // for (int i = 0; i < size; i++)
           // {
           //     Console.Write(arr[i]+" ");
           // }
           // Console.WriteLine();
           // #endregion

            //#region Recursive summation
            // Console.WriteLine("Enter the number");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(sum(n));
            //#endregion

            //#region 3Dpoint
            //_3Dpoint p = new _3Dpoint(10,10,10);
            //Console.WriteLine(p.ToString());
            //string point = (string)p;
            //Console.WriteLine(point);
            //#endregion

            #region Clock
            Clock C1 = new Clock(3600);
            Console.WriteLine(C1.ToString());
            Clock C2 = new Clock(7800);
            Console.WriteLine(C2.ToString());
            Clock C3 = new Clock(666);
            Console.WriteLine(C3.ToString());
            #endregion
        }
    }
    }
