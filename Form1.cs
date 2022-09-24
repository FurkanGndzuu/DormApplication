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
using System.Data.Sql;

namespace DormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=DormOtomation;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

            Connection.Open();

            SqlCommand command = new SqlCommand(@"Select DepartmentName from Tbl_StdDepartment", Connection);
            SqlDataReader reader =command.ExecuteReader();

            while (reader.Read())
            {
                cmbDepartment.Items.Add(reader[0].ToString());
            }

            Connection.Close();



            Connection.Open();

            SqlCommand command1 = new SqlCommand("select RoomNo from Tbl_Rooms where RoomActive<RoomCapasity",Connection);
            SqlDataReader reader2 =command1.ExecuteReader();

            while (reader2.Read())
            {
                cmbRoomNo.Items.Add(reader2[0].ToString());
            }
            Connection.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("insert into " +
                    "Tbl_DormRegistry2 (StdFirstName,StdLastName,StdTC,StdPhone,StdBirthDate,StdDepartment," +
                    "StdMail,StdRoomNo,StdParrentName,StdParrentPhone,StdAdress) " +
                    "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", Connection);

                command.Parameters.AddWithValue("@p1", txtStudentName.Text);
                command.Parameters.AddWithValue("@p2", txtStudentSurname.Text);
                command.Parameters.AddWithValue("@p3", mskStudentTc.Text);
                command.Parameters.AddWithValue("@p4", mskStudentPhone.Text);
                command.Parameters.AddWithValue("@p5", mskBirthDate.Text);
                command.Parameters.AddWithValue("@p6", cmbDepartment.Text);
                command.Parameters.AddWithValue("@p7", txtMail.Text);
                command.Parameters.AddWithValue("@p8", cmbRoomNo.Text);
                command.Parameters.AddWithValue("@p9", txtParrentName.Text);
                command.Parameters.AddWithValue("@p10", mskParrentPhone.Text);
                command.Parameters.AddWithValue("@p11", rchAdress.Text);

                command.ExecuteNonQuery();

                Connection.Close();

                

                MessageBox.Show("Student information Added");
            }
            catch (Exception)
            {
                MessageBox.Show("Registration Failed to Complete");
            }
        }
    }
}
//Data Source = DESKTOP - LDMU7VJ\SQLEXPRESS; Initial Catalog = DormOtomation; Integrated Security = True
