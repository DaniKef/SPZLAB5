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
    public partial class ChangeGroup : Form
    {
        public StudentsList studentList = new StudentsList();
        public BindingSource binding = new BindingSource();
        private string oldGroup;
        public ChangeGroup(StudentsList studentListA, BindingSource bindingA)
        {
            InitializeComponent();
            studentList = studentListA;
            binding = bindingA;
            binding.DataSource = studentList.Students;
            dataGridView2.DataSource = binding;
            dataGridView2.Columns["Name"].Visible = false;
            dataGridView2.Columns["Surname"].Visible = false;
            dataGridView2.Columns["Patronymic"].Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e) // Добавить студента
        {
            if(!string.IsNullOrEmpty(AddGroupTbx.Text) && !studentList.IsHaveThisGroup(AddGroupTbx.Text))
            {
                studentList.AddStudent(new Student(AddGroupTbx.Text));
                binding.ResetBindings(true);
            }
        }

        private void OKBtn_Click(object sender, EventArgs e) // Выйти
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e) // Удалить всех с такой группы
        {
            studentList.DeleteThisGroup(dataGridView2.SelectedCells[0].Value.ToString());
            binding.ResetBindings(true);
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e) // Изменить эту группу
        {
            studentList.ChangeThisGroup(oldGroup, dataGridView2.SelectedCells[0].Value.ToString());
            binding.ResetBindings(true);
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)// Для получения значений
        {
            oldGroup = dataGridView2.SelectedCells[0].Value.ToString();
        }
    }
}
