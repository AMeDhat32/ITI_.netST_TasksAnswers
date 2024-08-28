using System.Collections.Generic;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GenericList
            GenericList<int> list = new GenericList<int>(5);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Display();
            Console.WriteLine(list.get(3));
            // string list
            GenericList<string> list2 = new GenericList<string>(5);
            list2.Add("a");
            list2.Add("b");
            list2.Add("c");
            Console.WriteLine(list2.get(2));
            #endregion

            #region GenericCollection
            // add remove
            List<int> list3 = new List<int> {10,20,30,40,50};
            list3.Add(60);
            list3.Remove(20);
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region NonGenericCollection
            // add diff type
            ArrayList list4 = new ArrayList();
            list4.Add(10);
            list4.Add("a");
            list4.Add(10.5);
            foreach (var item in list4)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region genericmethod
             static void Print<T>(T item)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
