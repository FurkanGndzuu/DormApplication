using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormApplication
{
    public partial class GidetrListe : Form
    {
        public GidetrListe()
        {
            InitializeComponent();
        }

        private void GidetrListe_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dormOtomationDataSet9.Tbl_DormPaymentsss' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DormPaymentsssTableAdapter.Fill(this.dormOtomationDataSet9.Tbl_DormPaymentsss);
            // TODO: Bu kod satırı 'dormOtomationDataSet8.Tbl_DormPayments' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_DormPaymentsTableAdapter.Fill(this.dormOtomationDataSet8.Tbl_DormPayments);
            // TODO: Bu kod satırı 'dormOtomationDataSet7.Tbl_Paymentss' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_PaymentssTableAdapter.Fill(this.dormOtomationDataSet7.Tbl_Paymentss);
            // TODO: Bu kod satırı 'dormOtomationDataSet6.Tbl_Payments' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_PaymentsTableAdapter.Fill(this.dormOtomationDataSet6.Tbl_Payments);

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            GiderGuncelle guncelle = new GiderGuncelle();
            guncelle.elektrik = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            guncelle.su = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            guncelle.gaz = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            guncelle.internet = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            guncelle.yemekler = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            guncelle.isci = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            guncelle.diger = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            guncelle.Show();
           
        }
    }
}
