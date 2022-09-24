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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=DormOtomation;Integrated Security=True");


        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dormOtomationDataSet2.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_StdDepartmentTableAdapter2.Fill(this.dormOtomationDataSet2.Tbl_StdDepartment);
            // TODO: Bu kod satırı 'dormOtomationDataSet1.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_StdDepartmentTableAdapter1.Fill(this.dormOtomationDataSet1.Tbl_StdDepartment);
            // TODO: Bu kod satırı 'dormOtomationDataSet.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_StdDepartmentTableAdapter.Fill(this.dormOtomationDataSet.Tbl_StdDepartment);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("insert into Tbl_StdDepartment(DepartmentName) " +
                    "values('" + txtDepartmentName.Text + "')", Connection);
                command.ExecuteNonQuery();
                Connection.Close();

                MessageBox.Show("Department Name Added");

                // TODO: Bu kod satırı 'dormOtomationDataSet2.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter2.Fill(this.dormOtomationDataSet2.Tbl_StdDepartment);
                // TODO: Bu kod satırı 'dormOtomationDataSet1.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter1.Fill(this.dormOtomationDataSet1.Tbl_StdDepartment);
                // TODO: Bu kod satırı 'dormOtomationDataSet.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter.Fill(this.dormOtomationDataSet.Tbl_StdDepartment);
            }

            catch (Exception)
            {
                MessageBox.Show("Wrong Add");
            }

        }

        int Choosed;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, departmentName;

            Choosed = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[Choosed].Cells[0].Value.ToString();
            departmentName = dataGridView1.Rows[Choosed].Cells[1].Value.ToString();

            txtDepartmentName.Text = departmentName;    
            TxtDepartmentId.Text = id;  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("delete from Tbl_StdDepartment where DepartmentId=@p1",Connection);
                command.Parameters.AddWithValue("@p1", TxtDepartmentId.Text);
                command.ExecuteNonQuery();
                Connection.Close();

                MessageBox.Show("Department Name Deleted");

                // TODO: Bu kod satırı 'dormOtomationDataSet2.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter2.Fill(this.dormOtomationDataSet2.Tbl_StdDepartment);
                // TODO: Bu kod satırı 'dormOtomationDataSet1.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter1.Fill(this.dormOtomationDataSet1.Tbl_StdDepartment);
                // TODO: Bu kod satırı 'dormOtomationDataSet.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter.Fill(this.dormOtomationDataSet.Tbl_StdDepartment);
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong Delete");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            try
            {
                Connection.Open();

                SqlCommand command = new SqlCommand("update Tbl_StdDepartment set DepartmentName=@p2 where DepartmentId=@p1", Connection);

                command.Parameters.AddWithValue("@p1", TxtDepartmentId.Text);
                command.Parameters.AddWithValue("@p2", txtDepartmentName.Text);
                command.ExecuteNonQuery();
                Connection.Close();

                MessageBox.Show("Department Name Updated");

                // TODO: Bu kod satırı 'dormOtomationDataSet2.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter2.Fill(this.dormOtomationDataSet2.Tbl_StdDepartment);
                // TODO: Bu kod satırı 'dormOtomationDataSet1.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter1.Fill(this.dormOtomationDataSet1.Tbl_StdDepartment);
                // TODO: Bu kod satırı 'dormOtomationDataSet.Tbl_StdDepartment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
                this.tbl_StdDepartmentTableAdapter.Fill(this.dormOtomationDataSet.Tbl_StdDepartment);

            }
            catch (Exception)
            {

                MessageBox.Show("Wrong Update!!!");
            }
            
        }
    }
}
