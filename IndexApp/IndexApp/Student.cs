using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexApp
{
    public class Student
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{StudentId} {Name} {Marks.Average()}";  //Исправить
        }

    }

    public class Group
    {
        public int GroupId { get; set; }
        public string GroupNum { get; set; }
        private List<Student> Students { get; set; }
            = new List<Student>();

        public Student this[int id]
        {
            get
            {
                var st = Students.FirstOrDefault(s => s.StudentId == id);
                if (st == null)
                    throw new IndexOutOfRangeException($"Нет {id}"); 
                return st;
            }
            set
            {
                var st = Students.FirstOrDefault(
                          s => s.StudentId == value.StudentId);
                if (st != null)
                    Students[Students.IndexOf(st)] = value;
                else
                    Students.Add(value);
            }


        }

        public Student this[string name]
        {
            get
            {
                return null;
            }
            set
            {
                throw new NotImplementedException();
                
            }


        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Группа - {GroupNum}:");

            Students.ForEach(s => sb.AppendLine(s.ToString()));

            return sb.ToString();

        }



    }





    }
