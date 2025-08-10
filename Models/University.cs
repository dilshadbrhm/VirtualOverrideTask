using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTask.Models
{
    internal class University
    {
        private string _name;
        private Group[] _groups = new Group[0];

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
        public Group[] Groups
        {
            get { return _groups; }
            set
            {
                _groups = value;
            }
        }

        public void AddGroup(Group group)
        {
            Array.Resize(ref _groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }
        public void RemoveGroup(string name)
        {
            int j = 0;
            Group[] newGr = new Group[Groups.Length - 1];
            for (int i = 0; i < Groups.Length; i++)
            {
              
                if (Groups[i].Name != name)
                {
                    newGr[j] = Groups[i];
                    j++;
                }
            }
            Groups = newGr;
        }
        public void ShowGroups()
        {
            for (int i = 0;i < Groups.Length;i++)
            {
                Console.WriteLine($"{Groups[i].Name}");
            }
        }
        public void ShowAllStudents()
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                Groups[i].ShowStudents();
              
            }
        }



    }
}
