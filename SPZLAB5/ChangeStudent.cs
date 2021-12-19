using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZLAB5.Classes;


namespace SPZLAB5
{
    public partial class ChangeStudent : Form
    {
        public StudentsList studentList = new StudentsList();
        public BindingSource binding = new BindingSource();
        public ChangeStudent(StudentsList studentListA, BindingSource bindingA)
        {
            InitializeComponent();
            studentList = studentListA;
            binding = bindingA;
            binding.DataSource = studentList.Students;
            dataGridView1.DataSource = binding;
        }

        private void AddStudentBtn_Click(object sender, EventArgs e) // добавить студента
        {
            if(!string.IsNullOrEmpty(AddNameTbx.Text) && !string.IsNullOrEmpty(AddSurnameTbx.Text)
                && !string.IsNullOrEmpty(AddPatroTbx.Text) && !studentList.IsStudentInGroup(AddNameTbx.Text, AddSurnameTbx.Text, AddPatroTbx.Text))
            {
                studentList.AddStudent(new Student(AddNameTbx.Text, AddSurnameTbx.Text, AddPatroTbx.Text, "-"));
                binding.ResetBindings(true);
            }
        }

        private void OKBtn_Click(object sender, EventArgs e) // выйти
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
