using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTask.Models
{
    internal class Manager :Employee
    {
        private decimal _bonus;

        public decimal Bonus
        {
            get
            {
                return _bonus;
            }
            set
            {
                if (value > 0)
                {
                    _bonus = value;
                }
            }
        }
        public override void CalculateSalary()
        {
            decimal baseSalary = SalaryPerHour * Hours;
            decimal totalSalary = baseSalary + (baseSalary * Bonus / 100);
            Console.WriteLine($"{totalSalary}");
        }
    }
}
