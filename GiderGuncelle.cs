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
    public partial class GiderGuncelle : Form
    {
        public GiderGuncelle()
        {
            InitializeComponent();
        }

        public string elektrik, su, gaz, internet, yemekler, isci, diger;

        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=DormOtomation;Integrated Security=True");


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand("update Tbl_DormPaymentsss set Electric=@b1,Water=@b2,gass=@b3,Internet=@b4,Foods=@b5,Employee=@b6,Other=@b7 where Electric=@b1", Connection);

            command.Parameters.AddWithValue("@b1",txtElektrik.Text);
            command.Parameters.AddWithValue("@b2", txtWater.Text);
            command.Parameters.AddWithValue("@b3", txtGass.Text);
            command.Parameters.AddWithValue("@b4", txtInternet.Text);
            command.Parameters.AddWithValue("@b5", txtFoods.Text);
            command.Parameters.AddWithValue("@b6", txtEmployee.Text);
            command.Parameters.AddWithValue("@b7", txtOther.Text);
           

            command.ExecuteNonQuery();

            Connection.Close();

            MessageBox.Show("Information Updated");
        }

        private void GiderGuncelle_Load(object sender, EventArgs e)
        {
            txtElektrik.Text= elektrik;
            txtWater.Text = su;
            txtGass.Text = gaz;
            txtInternet.Text = internet;
            txtFoods.Text = yemekler;
            txtEmployee.Text=isci;
            txtOther.Text = diger;

        }
    }
}
