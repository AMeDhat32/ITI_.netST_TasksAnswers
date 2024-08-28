using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Employee
    { 
        // fields
        int id; 
        int securityLevel; 
        decimal salary; 
        HiringDate hiringDate; 
        Gender gender; 

        // constructor


       
        public Employee()
        {

        }
        public Employee(int id, int securityLevel, decimal salary, HiringDate hiringDate, Gender gender)
        {
            this.id = id;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hiringDate = hiringDate;
            this.gender = gender;
        }

        // auto properties
        public int Id { get; set; }
        public int SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        public Gender Gender { get; set; }

        // override ToString method
        public override string ToString()
        {
            return $"Id: {Id}, SecurityLevel: {SecurityLevel}, Salary: {Salary}, HiringDate: {HiringDate}, Gender: {Gender}";
        }
    }
}
