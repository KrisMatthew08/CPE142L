using LabExercise5.Models;
using LabExercise5.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExercise5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            Student student = new Student();
            student.id = 0;
            student.first_name = textFirstName.Text;
            student.last_name = textLastName.Text;
            student.address = textAddress.Text;
            student.phone = textPhone.Text;

            var repo = new StudentRepositories();
            repo.createStudent(student);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
