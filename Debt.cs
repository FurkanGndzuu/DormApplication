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
    public partial class Debt : Form
    {
        public Debt()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper=new SqlHelper();
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=DormOtomation;Integrated Security=True");


        private void Debt_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dormOtomationDataSet4.Tbl_StudentDebt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_StudentDebtTableAdapter.Fill(this.dormOtomationDataSet4.Tbl_StudentDebt);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Choosed;
            string name, surname, ıd, debt, paid;

            Choosed = dataGridView1.SelectedCells[0].RowIndex;
            ıd = dataGridView1.Rows[Choosed].Cells[0].Value.ToString();
            name = dataGridView1.Rows[Choosed].Cells[1].Value.ToString();
            surname = dataGridView1.Rows[Choosed].Cells[2].Value.ToString();
            debt = dataGridView1.Rows[Choosed].Cells[3].Value.ToString();

            TxtName.Text = name;
            txtSurname.Text= surname;
            txtId.Text = ıd;
            txtDebt.Text = debt;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int paid, debt,Guncel;
            paid=Convert.ToInt32(txtpaid.Text);
            debt=Convert.ToInt32(txtDebt.Text);

            Guncel = debt - paid;

            txtDebt.Text=Guncel.ToString(); 
            Connection.Open();

            SqlCommand command = new SqlCommand("update Tbl_StudentDebt set StdDebt=@p2 where StudentID=@p1", Connection);
            command.Parameters.AddWithValue("@p1", txtId.Text);
            command.Parameters.AddWithValue("@p2",Convert.ToInt32(Guncel));

            command.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Payment Completed");

            this.tbl_StudentDebtTableAdapter.Fill(this.dormOtomationDataSet4.Tbl_StudentDebt);

        }
    }
}
