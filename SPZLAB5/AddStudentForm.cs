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
    public partial class AddStudentForm : Form
    {
        public Student student { get; set; }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTbx.Text) && !string.IsNullOrEmpty(SurnameTbx.Text) &&
                !string.IsNullOrEmpty(PatronymicTbx.Text) && !string.IsNullOrEmpty(GroupTbx.Text))
                student = new Student(NameTbx.Text, SurnameTbx.Text, PatronymicTbx.Text, GroupTbx.Text);
            else
                throw new Exception();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
