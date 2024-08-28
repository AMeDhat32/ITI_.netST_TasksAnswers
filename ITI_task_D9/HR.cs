using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class HR : Employee
    {
        public HR(int id, int securityLevel, decimal salary, HiringDate hiring,Gender gender) : base(id, securityLevel, salary,hiring,gender) { }

        // method for HR
        public void hire()
        {
            Console.WriteLine("Hiring...");
        }
    }
}
