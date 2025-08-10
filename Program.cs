using OverrideTask.Models;

namespace OverrideTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University uni = new University
            {
                Name = "Code"
            };

            Group group1 = new Group
            {
                Name = "P111",
                GroupLimit = 3
            };

            Group group2 = new Group
            {
                Name = "P222",
                GroupLimit = 2
            };

         Student st1 = new Student { Name = "Ali", Surname = "Aliyev", Age = 20 };
            Student st2 = new Student { Name = "Veli", Surname = "Veliyev", Age = 21 };
            Student st3 = new Student { Name = "Dilshad", Surname = "ibrahimli", Age = 21 };

            group1.Add(st1);
            group1.Add(st2);
            group1.Add(st3);

            Student st4 = new Student { Name = "test", Surname = "testov", Age = 22 };
            group2.Add(st4);
            uni.AddGroup(group1);
            uni.AddGroup(group2);
            uni.ShowGroups();
            uni.ShowAllStudents();
            group1.Remove("test");
            group1.ShowStudents();
            uni.RemoveGroup("P222");
            uni.ShowGroups();

        }
    }
}
