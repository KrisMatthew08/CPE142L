using LabExercise5.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LabExercise5
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();

            ReadStudents();
        }

        public void ReadStudents()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Student ID");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone");

            var repo = new StudentRepositories();
            var students = repo.ReadStudents();

            foreach (var student in students)
            {
                var row = dataTable.NewRow();

                row["Student ID"] = student.id;
                row["First Name"] = student.first_name;
                row["Last Name"] = student.last_name;
                row["Address"] = student.address;
                row["Phone"] = student.phone;

                dataTable.Rows.Add(row);
            }
            this.dgvStudent.DataSource = dataTable;

        }


        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.Cancel) return;

            ReadStudents();
        }
    }
}
