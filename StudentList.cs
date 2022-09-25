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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dormOtomationDataSet5.Tbl_DormRegistry2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DormRegistry2TableAdapter.Fill(this.dormOtomationDataSet5.Tbl_DormRegistry2);

        }
        int Choosed;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Choosed = dataGridView2.SelectedCells[0].RowIndex;

            StudentEdit Edit = new StudentEdit();
           
            Edit.id = dataGridView2.Rows[Choosed].Cells[0].Value.ToString();
            Edit.name = dataGridView2.Rows[Choosed].Cells[1].Value.ToString();
            Edit.surname = dataGridView2.Rows[Choosed].Cells[2].Value.ToString();
            Edit.tc = dataGridView2.Rows[Choosed].Cells[3].Value.ToString();
            Edit.stdPhone = dataGridView2.Rows[Choosed].Cells[4].Value.ToString();
            Edit.birthDate = dataGridView2.Rows[Choosed].Cells[5].Value.ToString();
            Edit.department = dataGridView2.Rows[Choosed].Cells[6].Value.ToString();
            Edit.mail = dataGridView2.Rows[Choosed].Cells[7].Value.ToString();
            Edit.roomNo = dataGridView2.Rows[Choosed].Cells[8].Value.ToString();
            Edit.prtName = dataGridView2.Rows[Choosed].Cells[9].Value.ToString();
            Edit.prtPhone = dataGridView2.Rows[Choosed].Cells[10].Value.ToString();
            Edit.adress = dataGridView2.Rows[Choosed].Cells[11].Value.ToString();



            Edit.Show();

            this.tbl_DormRegistry2TableAdapter.Fill(this.dormOtomationDataSet5.Tbl_DormRegistry2);

        }
    }
}
