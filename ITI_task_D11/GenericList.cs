using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class GenericList<T>
    {
        T[] items;
        int point;
        public GenericList(int cap)
        {
            items = new T[cap];
            point = 0;
        }
        public void Add(T item)
        {
            items[point] = item;
            point++;
        }
        public T get(int index)
        {
            if(index < 0 || index >= items.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return items[index];
        } 

        public void Display()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
