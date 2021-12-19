using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB5.Classes
{
    public class Student // Класс студента
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Group { get; set; }
        private bool isInGroup { get; set; }
        public Student(string name, string surname, string patronymic, string group) // Конструктор
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Group = group;
            isInGroup = true;
        }
        public Student(string group)
        {
            Name = "-";
            Surname = "-";
            Patronymic = "-";
            Group = group;
            isInGroup = true;
        }
        public Student()
        { }
    }
}
