global using static LINQ_Study.ListGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_Study
{
    internal class Program
    {
        public static void PrintEnumerable(IEnumerable<object> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            #region implicit type
            //var x = 5;
            #endregion

            #region anonymous type
            //var person1 = new { id = 1, name = "ali", salary = 3000 };


            //Console.WriteLine(person1);
            //Console.WriteLine(person1.GetType());
            //#endregion

            //#region extension method
            //var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = list.Filter(x => x % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region LINQ
            ////fluent syntax
            //List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////   var result2 = list2.Where(x => x % 2 == 0); // differed execution  execute when we iterate over the result
            //var result2 = list2.Where(x => x % 2 == 0).ToList(); //immediate execution execute when we call ToList()
            ////Enumerable.Where(list2,x=>x %2==0);
            //// index where
            //var res = list2.Where((x, index) => x % 2 == 0 && index % 2 == 0);

            //list2.AddRange(new List<int> { 10, 11, 12 });
            //printlist(result2.ToList());

            ////query syntax
            //var result3 = from i in list2
            //              where i % 2 == 0
            //              select i;
            ////immediate execution
            ////var result3 = (from i in list2
            ////               where i%2 ==0
            ////               select i).ToList();
            //printlist(result3.ToList());

            // deferred execution 
            var answer = ProductList.Where(p => p.UnitsInStock == 0);
            answer = from p in ProductList
                     where p.UnitsInStock == 0
                     select p;


            // immediate execution
            var answer2 = ProductList.Where(p => p.UnitsInStock == 0).Select(p => new { id = p.ProductID, name = p.ProductName });
            answer2 = from p in ProductList
                      where p.UnitsInStock == 0
                      select new { id = p.ProductID, name = p.ProductName };
            #endregion



            #region task
            
            var data = ProductList;
            // PrintEnumerable(data);
            var data2 = CustomerList;
            //PrintEnumerable(data2);


            // Find all products that are out of stock
            var questoin1 = ProductList.Where(p => p.UnitsInStock == 0);
            // PrintEnumerable(questoin1);


            //Find all products that are in stock and cost more than 3.00 per unit.
            var question2 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            //PrintEnumerable(question2);

            //Returns digits whose name is shorter than their value.
            String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var question3 = Arr.Where((number, index) => number.Length < index);
            //PrintEnumerable(question3);

            //Get first Product out of Stock 
            var question4 = ProductList.First(p=>p.UnitsInStock==0);
            //Console.WriteLine(question4);

            //Return the first product whose Price > 1000, unless there is no match, in which case null is returned
            var question5 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(question5);

            //Retrieve the second number greater than 5 
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Array.Sort(Arr2);
            var question6 = Arr2.Where(x => x > 5).Skip(1).Take(1);
            //foreach(var number in question6)Console.WriteLine(number);

            //Find the unique Category names from Product List
            var question7 = ProductList.Select(p=> p.Category).Distinct();
            //PrintEnumerable(question7);

            //Produce a Sequence containing the unique first letter from both product and customer names.
            var Question8 = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CompanyName[0]));
            //foreach (var item in Question8)Console.Write(item+" ");

            //Create one sequence that contains the common first letter from both product and customer names.
            var Question9 = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CompanyName[0]));
            // foreach (var item in Question9) Console.Write(item + " ");

            //Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var Question10 = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CompanyName[0]));
            //foreach (var item in Question10) Console.Write(item + " ");

            //Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            var Question11 = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)).Concat(CustomerList.Select(c => c.CompanyName.Substring(c.CompanyName.Length - 3)));
            //foreach (var item in Question11) Console.Write(item + " ");

            //Uses Count to get the number of odd numbers in the array
            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Question12 = Arr3.Count(X => X % 2!=0);
            //Console.WriteLine(Question12);

            //Return a list of customers and how many orders each has group by customer 
            var Question13 = CustomerList.Select(c => new {CustomerId=c.CustomerID , HowManyOrders=c.Orders.Length });
            //foreach (var item in Question13) Console.WriteLine(item);

            //Return a list of categories and how many products each has
            var Question14 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, HowManyProducts = g.Count() });
            //foreach (var item in Question14) Console.WriteLine(item);

            //Get the total of the numbers in an array.
            int[] Arr4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Question15 = Arr4.Sum();
            //Console.WriteLine(Question15);

            //Get the total units in stock for each product category.
            var Question16 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
            //foreach (var item in Question16) Console.WriteLine(item);

            //Get the cheapest price among each category's products
            var Question17 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
            //foreach (var item in Question17) Console.WriteLine(item);

            //Get the most expensive price among each category's products.
            var Question18 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) });
            //foreach (var item in Question18) Console.WriteLine(item);

            //Get the products with the most expensive price in each category.
            var Question19 = ProductList.GroupBy(p => p.Category).Select(g =>  g.OrderByDescending(p => p.UnitPrice).First());
            //foreach (var item in Question19) Console.WriteLine(item);

            //Get the average price of each category's products.
            var Question20 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
            //foreach (var item in Question20) Console.WriteLine(item);

            //Sort a list of products by name
            string[] Arr5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var Question21 = Arr5.OrderBy(x => x);
            //foreach (var item in Question21) Console.WriteLine(item);


            #endregion


        }
    }
}
