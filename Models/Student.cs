using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTask.Models
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                value = value.Trim();
                if (value.Length > 2)
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                value = value.Trim();
                if (value.Length > 2)
                {
                    _surname = value;
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 16)
                {
                    _age = value;
                }
            }
        }
       
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname}  {Age}");
        }
    }
}

