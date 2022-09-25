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

namespace DormApplication
{
    public partial class StudentEdit : Form
    {
        public StudentEdit()
        {
            InitializeComponent();
        }
        public string id, name, surname, mail, tc, stdPhone, adress, prtPhone, prtName, roomNo, birthDate, department;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("delete from Tbl_DormRegistry2 where StdId=@b1", Connection);

                command.Parameters.AddWithValue("@b1", txtId.Text);

                command.ExecuteNonQuery();

                Connection.Close();

                MessageBox.Show("Information Deleted");
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong");
            }
        }

        SqlConnection Connection =new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=DormOtomation;Integrated Security=True");

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("update Tbl_DormRegistry2 set StdFirstName=@p1, StdLastName=@p2,StdTC=@p3,StdPhone=@p4,StdBirthDate=@p5,StdDepartment=@p6,StdMail=@p7,StdRoomNo=@p8,StdParrentName=@p9,StdParrentPhone=@p10,StdAdress=@p11 where StdId=@p12", Connection);
                command.Parameters.AddWithValue("@p12", txtId.Text);
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

                MessageBox.Show("Information Updated");

            }
            catch (Exception)
            {

                MessageBox.Show("Wrong");
            }
            
        }

        private void StudentEdit_Load(object sender, EventArgs e)
        {
            txtId.Text = id;
            txtStudentName.Text = name; 
            txtStudentSurname.Text = surname;
            txtMail.Text= mail;
            txtParrentName.Text=prtName;
            mskBirthDate.Text= birthDate;
            mskParrentPhone.Text= prtPhone; 
            mskStudentPhone.Text=stdPhone;
            mskStudentTc.Text = tc;
            rchAdress.Text = adress;
            cmbRoomNo.Text = roomNo;
            cmbDepartment.Text = department;

            Connection.Open();

            SqlCommand command = new SqlCommand("select DepartmentName from Tbl_StdDepartment",Connection);
            SqlDataReader reader=command.ExecuteReader();

            while (reader.Read())
            {
                cmbDepartment.Items.Add(reader[0].ToString());
            }

           Connection.Close();


            Connection.Open();

            SqlCommand command2 = new SqlCommand("Select RoomNo from Tbl_Rooms where RoomCapasity>RoomActive", Connection);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                cmbRoomNo.Items.Add(reader2[0].ToString()); 
            }

            Connection.Close();
        }
    }
}
