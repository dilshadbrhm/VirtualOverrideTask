using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTask.Models
{
    internal class Group
    {
        private string _name;
        private int _groupLimit;
        Student[] _students = new Student[0];

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
        public Student[] Students
        {
            get { return _students; }
            set
            {
                _students = value;
            }
        }
        public int GroupLimit
        {
            get
            {
                return _groupLimit;
            }
            set
            {
                if (value > 0)
                {
                    _groupLimit = value;
                }
            }
        }
       
        
        public void Add(Student Student)
        {
            if (Students.Length <= GroupLimit)
            {
                Array.Resize(ref _students, Students.Length + 1);
                Students[Students.Length - 1] = Student;
            }
            
        }
        public void Remove(string name)
        {
            int j = 0;
            Student[] newSt = new Student[Students.Length-1];
            for (int i = 0; i < Students.Length; i++)
            {
                
                if (Students[i].Name != name)
                {
                    newSt[j] = Students[i];
                    j++;
                }
            }
            Students = newSt;
        }
        public bool StudentExits(string name)
        {
            

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name)
                {
                    return true;
                    
                }
                
            }
            return false;
        }

        public void ShowStudents()
        {
            if (Students.Length > 0)
            {
                for (int i = 0; i < Students.Length; i++)
                {
                    Students[i].PrintInfo();
                }
            }
           
        }

    }
}
