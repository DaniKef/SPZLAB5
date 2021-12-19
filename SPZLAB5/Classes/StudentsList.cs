using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB5.Classes
{
    public class StudentsList
    {
        public List<Student> Students { get; set; }
        public StudentsList()
        {
            Students = new List<Student>();
        }
        public void AddStudent(Student student)//Добавить студента
        {
            Students.Add(student);
        }
        public bool IsStudentInGroup(string name, string surname, string patronymic)//Проверить есть ли студентв группе
        {
            var count = 0;
            if (Students.Count!=0)
            {
                count = (from t in Students
                             where (name == t.Name && surname == t.Surname && patronymic == t.Patronymic)
                             select t).Count();
            }
            if (count == 0)
                return false;
            else 
                return true;
        }
        public bool IsHaveThisGroup(string group1)//Есть ли такая группа
        {
            var count = (from t in Students where t.Group == group1 select t).Count();
            if (count == 0)
                return false;
            else return true;
        }
        public void DeleteThisGroup(string group1)//Удалить эту группу
        {
            Students.RemoveAll(x => x.Group == group1);
        }
        public void ChangeThisGroup(string group1, string newGroup) //изменить эту группу
        {
            foreach(var item in Students)
            {
                if (item.Group == group1)
                    item.Group = newGroup;
            }
        }
        public void SortBySurname()//сортировать по фамилии
        {
            Students = (Students.OrderBy(n => n.Surname)).ToList();
        }
        public void SortByGroup() //сортировать по шруппе
        {
            Students = Students.OrderBy(g => g.Group).ToList();
        }
    }
}
