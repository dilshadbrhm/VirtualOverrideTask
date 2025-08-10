using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTask.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;
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
                if (value.Length > 3)
                {
                    _surname = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }

}
