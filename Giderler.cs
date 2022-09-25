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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=DormOtomation;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlCommand command =new SqlCommand("insert into Tbl_DormPaymentsss (Electric,Water,gass,Internet,Foods,Employee,Other) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", Connection);

            command.Parameters.AddWithValue("@p1", txtElektrik.Text);
            command.Parameters.AddWithValue("@p2", txtWater.Text);
            command.Parameters.AddWithValue("@p3", txtGass.Text);
            command.Parameters.AddWithValue("@p4", txtInternet.Text);
            command.Parameters.AddWithValue("@p5", txtFoods.Text);
            command.Parameters.AddWithValue("@p6", txtEmployee.Text);
            command.Parameters.AddWithValue("@p7", txtOther.Text);

            command.ExecuteNonQuery();
            Connection.Close();

            MessageBox.Show("Information Added");

        }
    }
}
