using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTask.Models
{
    internal class Employee : Person
    {
        private string _compant;
        private decimal _salaryPerHour;
        private int _hours;
        private int _experience;

        public string Compant
        {
            get { return _compant; }
            set
            {
                value = value.Trim();
                if (value.Length >= 0)
                {
                    _compant = value;
                }
            }
        }
        public decimal SalaryPerHour
        {
            get
            {
                return _salaryPerHour;
            }
            set
            {
                if (value > 0)
                {
                    _salaryPerHour = value;
                }
            }
        }
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value > 0)
                {
                    _hours = value;
                }
            }
        }
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value > 0)
                {
                    _experience = value;
                }
            }
        }
        public  virtual void CalculateSalary()
        {
            decimal totalSalary = Hours * SalaryPerHour;
            Console.WriteLine($"{totalSalary}");
            
        }



    }
}
