using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SPZLAB5.Classes;
using System.IO;
using Newtonsoft.Json.Serialization; // json
using Newtonsoft.Json;


namespace SPZLAB5
{
    public partial class Form1 : Form
    {
        public StudentsList studentList = new StudentsList();
        private BindingSource binding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            binding.DataSource = studentList.Students; // привязка списка
            dataGridView1.DataSource = binding;
        }

        private void AddStudentBtn_Click(object sender, EventArgs e) //добавить студента
        {
            var addStudentForm = new AddStudentForm();
            addStudentForm.StartPosition = FormStartPosition.CenterParent;
            if(addStudentForm.ShowDialog() == DialogResult.OK)
            {
                if (!studentList.IsStudentInGroup(addStudentForm.student.Name, addStudentForm.student.Surname, addStudentForm.student.Patronymic))
                {
                    studentList.AddStudent(addStudentForm.student);
                    binding.ResetBindings(true);
                }
            }
        }

        private void ChangeGroupBtn_Click(object sender, EventArgs e)//изменить группу
        {
            var changeGroupForm = new ChangeGroup(studentList, binding);
            changeGroupForm.StartPosition = FormStartPosition.CenterParent;
            changeGroupForm.ShowDialog();
        }

        private void ChangeStudentBtn_Click(object sender, EventArgs e)//изменит ьстудента
        {
            var changeStudentForm = new ChangeStudent(studentList, binding);
            changeStudentForm.StartPosition = FormStartPosition.CenterParent;
            changeStudentForm.ShowDialog();
        }

        private void SortBySurnameBtn_Click(object sender, EventArgs e) //сортировать по фамилии
        {
            studentList.SortBySurname();
            binding.DataSource = studentList.Students;
            dataGridView1.DataSource = binding;
        }

        private void button1_Click(object sender, EventArgs e) // сортировать по группе
        {
            studentList.SortByGroup();
            binding.DataSource = studentList.Students;
            dataGridView1.DataSource = binding;
        }

        private void ShowAllBtn_Click(object sender, EventArgs e) // показать всех
        {
            binding.DataSource = studentList.Students;
            dataGridView1.DataSource = binding;
        }

        private void ShowThisGroupBtn_Click(object sender, EventArgs e) // показать студентов этой группы
        {
            var somelist = (from t in studentList.Students
                           where t.Group == WhatGroupTbx.Text
                           select t).ToList();
            binding.DataSource = somelist;
            dataGridView1.DataSource = binding;
        }

        private void SaveToJSONBtn_Click(object sender, EventArgs e) // сериализация json
        {
            File.Delete("StudentList.json");
            string text = JsonConvert.SerializeObject(studentList.Students);
            using (StreamWriter sw = new StreamWriter("StudentList.json", true, Encoding.Default))
            {
                sw.Write(text);
            }
        }

        private void GetFromJSONBtn_Click(object sender, EventArgs e) // десериализация json
        {
            string text;
            using (StreamReader sr = new StreamReader("StudentList.json"))
            {
                text = sr.ReadToEnd();
            }
            studentList.Students = JsonConvert.DeserializeObject<List<Student>>(text);
            binding.DataSource = studentList.Students;
            dataGridView1.DataSource = binding;
        }
    }
}
