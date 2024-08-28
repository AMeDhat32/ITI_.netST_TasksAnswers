using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public struct Employee
    {
        int ID;
        int SecurityLevel;
        decimal Salary;
        HiringDate HiringDate;
        Gender Gender;

        public Employee(int ID, int SecurityLevel, decimal Salary, HiringDate HiringDate, Gender Gender)
        {
            this.ID = ID;
            this.SecurityLevel = SecurityLevel;
            this.Salary = Salary;
            this.HiringDate = HiringDate;
            this.Gender = Gender;
        }
        public int GetID()
        {
            return ID;
        }
        public int GetSecurityLevel()
        {
            return SecurityLevel;
        }
        public decimal GetSalary()
        {
            return Salary;
        }
        public HiringDate GetHiringDate()
        {
            return HiringDate;
        }
        public Gender GetGender()
        {
            return Gender;
        }
        public int SetID(int ID)
        {
            return this.ID = ID;
        }
        public int SetSecurityLevel(int SecurityLevel)
        {
            return this.SecurityLevel = SecurityLevel;
        }
        public decimal SetSalary(decimal Salary)
        {
            return this.Salary = Salary;
        }
        public HiringDate SetHiringDate(HiringDate HiringDate)
        {
            return this.HiringDate = HiringDate;
        }
        public void SetGender(Gender Gender)
        {
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}, SecurityLevel: {SecurityLevel}, Salary: {Salary}, HiringDate: {HiringDate}, Gender: {Gender}";
        }
    }
}
