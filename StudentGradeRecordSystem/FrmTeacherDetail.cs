using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeRecordSystem
{
    public partial class FrmTeacherDetail : Form
    {
        public FrmTeacherDetail()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source =LAPTOP-C0RFFTSQ;initial catalog= DbNoteRegistration;integrated security=true");
    
        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            bring();
        }
        public void bring()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From tblLesson",connection);
            DataSet ds = new DataSet();
            connection.Open();
            da.Fill(ds, "tblLesson");
            dgwStudent.DataSource = ds.Tables["tblLesson"];
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblLesson (StudentNummer,StudentName,StudentSurname) values (@P1,@P2,@P3)",connection);
            command.Parameters.AddWithValue("@P1",MskNummer.Text);
            command.Parameters.AddWithValue("@P2", TbxName.Text);
            command.Parameters.AddWithValue("@P3", TbxSurname.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("The student has been added to the system!");
            bring();

        }

        private void dgwStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dgwStudent.SelectedCells[0].RowIndex;

            MskNummer.Text = dgwStudent.Rows[chosen].Cells[1].Value.ToString();
            TbxName.Text = dgwStudent.Rows[chosen].Cells[2].Value.ToString();
            TbxSurname.Text = dgwStudent.Rows[chosen].Cells[3].Value.ToString();
            TxtExam1.Text = dgwStudent.Rows[chosen].Cells[4].Value.ToString();
            TxtExam2.Text = dgwStudent.Rows[chosen].Cells[5].Value.ToString();
            TxtExam3.Text = dgwStudent.Rows[chosen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, s1, s2, s3;
            string status;
            s1 = Convert.ToDouble(TxtExam1.Text);
            s2 = Convert.ToDouble(TxtExam2.Text);
            s3 = Convert.ToDouble(TxtExam3.Text);

            average = (s1 + s2 + s3) / 3;

            LblAverage.Text = average.ToString();

            if (average>=50)
            {
                status = "True";
            }
            else
            {
                status = "False";
            }

            connection.Open();
            SqlCommand command = new SqlCommand("update tblLesson set StudentExam1 = @P1,StudentExam2 = @P2,StudentExam3 = @P3, Average=@P4,Status=@P5 Where StudentNummer=@P6",connection);
            command.Parameters.AddWithValue("@P1",TxtExam1.Text);
            command.Parameters.AddWithValue("@P2", TxtExam2.Text);
            command.Parameters.AddWithValue("@P3", TxtExam3.Text);
            command.Parameters.AddWithValue("@P4", decimal.Parse(TxtExam1.Text));
            command.Parameters.AddWithValue("@P5", status);
            command.Parameters.AddWithValue("@P6", MskNummer.Text);
            connection.Close();
            MessageBox.Show("Student information is updated!");
            bring();
        }
    }
}
