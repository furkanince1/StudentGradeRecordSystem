using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentGradeRecordSystem
{
    public partial class frmStudentDetail : Form
    {
        public frmStudentDetail()
        {
            InitializeComponent();
        }
        public string nummer;

        SqlConnection connection = new SqlConnection(@"Data Source =LAPTOP-C0RFFTSQ;initial catalog= DbNoteRegistration;integrated security=true");

        private void frmStudentDetail_Load(object sender, EventArgs e)
        {
            lblStudentNummer.Text = nummer;
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From tblLesson where StudentNummer=@p1", connection);
            command.Parameters.AddWithValue("@p1", nummer);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblNameSurname.Text = reader[2].ToString() + " " + reader[3].ToString();
                lblExam1.Text = reader[4].ToString();
                lblExam2.Text = reader[5].ToString();
                lblExam3.Text = reader[6].ToString();
                lblAverage.Text = reader[7].ToString();
                lblStatus.Text = reader[7].ToString();
            }
        }
    }
}
