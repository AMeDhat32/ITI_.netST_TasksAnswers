using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Developer : Employee
    {
        public Developer(int id, int securityLevel, decimal salary, HiringDate hiring,Gender gender) : base(id, securityLevel, salary,hiring,gender) { }

        // method for developer
        public void develop()
        {
            Console.WriteLine("Developing...");
        }
        
    }
}
