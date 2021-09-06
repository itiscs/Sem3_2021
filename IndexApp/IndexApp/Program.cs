using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gr = new Group() { GroupId = 1, GroupNum = "11-011" };
            gr[101] = new Student()
            { GroupId = 1, Name = "Иванов", StudentId = 101 };
            gr[102] = new Student()
            {
                GroupId = 1,
                Name = "Петров",
                StudentId = 102,
                Marks = { 5, 4, 5 }
            };
            gr[103] = new Student()
            { GroupId = 1, Name = "Максимов", StudentId = 103 };
            gr[104] = new Student()
            { GroupId = 1, Name = "Сидоров", StudentId = 104 };



            Console.WriteLine(gr[103]);

          
            gr[103].Marks.Add(5);

            gr[103].Marks.Add(5);

            gr[103].Marks.Add(2);

            Console.WriteLine(gr[103]);


        }
    }
}
