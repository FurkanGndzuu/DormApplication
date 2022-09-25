namespace DormApplication
{
    partial class StudentList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dormOtomationDataSet5 = new DormApplication.DormOtomationDataSet5();
            this.tblDormRegistry2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DormRegistry2TableAdapter = new DormApplication.DormOtomationDataSet5TableAdapters.Tbl_DormRegistry2TableAdapter();
            this.stdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdRoomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdParrentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdParrentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormRegistry2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdIdDataGridViewTextBoxColumn,
            this.stdFirstNameDataGridViewTextBoxColumn,
            this.stdLastNameDataGridViewTextBoxColumn,
            this.stdTcDataGridViewTextBoxColumn,
            this.stdPhoneDataGridViewTextBoxColumn,
            this.stdBirthDateDataGridViewTextBoxColumn,
            this.stdDepartmentDataGridViewTextBoxColumn,
            this.stdMailDataGridViewTextBoxColumn,
            this.stdRoomNoDataGridViewTextBoxColumn,
            this.stdParrentNameDataGridViewTextBoxColumn,
            this.stdParrentPhoneDataGridViewTextBoxColumn,
            this.stdAdressDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblDormRegistry2BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1554, 450);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dormOtomationDataSet5
            // 
            this.dormOtomationDataSet5.DataSetName = "DormOtomationDataSet5";
            this.dormOtomationDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDormRegistry2BindingSource
            // 
            this.tblDormRegistry2BindingSource.DataMember = "Tbl_DormRegistry2";
            this.tblDormRegistry2BindingSource.DataSource = this.dormOtomationDataSet5;
            // 
            // tbl_DormRegistry2TableAdapter
            // 
            this.tbl_DormRegistry2TableAdapter.ClearBeforeFill = true;
            // 
            // stdIdDataGridViewTextBoxColumn
            // 
            this.stdIdDataGridViewTextBoxColumn.DataPropertyName = "StdId";
            this.stdIdDataGridViewTextBoxColumn.HeaderText = "StdId";
            this.stdIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdIdDataGridViewTextBoxColumn.Name = "stdIdDataGridViewTextBoxColumn";
            this.stdIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stdIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdFirstNameDataGridViewTextBoxColumn
            // 
            this.stdFirstNameDataGridViewTextBoxColumn.DataPropertyName = "StdFirstName";
            this.stdFirstNameDataGridViewTextBoxColumn.HeaderText = "StdFirstName";
            this.stdFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdFirstNameDataGridViewTextBoxColumn.Name = "stdFirstNameDataGridViewTextBoxColumn";
            this.stdFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdLastNameDataGridViewTextBoxColumn
            // 
            this.stdLastNameDataGridViewTextBoxColumn.DataPropertyName = "StdLastName";
            this.stdLastNameDataGridViewTextBoxColumn.HeaderText = "StdLastName";
            this.stdLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdLastNameDataGridViewTextBoxColumn.Name = "stdLastNameDataGridViewTextBoxColumn";
            this.stdLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdTcDataGridViewTextBoxColumn
            // 
            this.stdTcDataGridViewTextBoxColumn.DataPropertyName = "StdTc";
            this.stdTcDataGridViewTextBoxColumn.HeaderText = "StdTc";
            this.stdTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdTcDataGridViewTextBoxColumn.Name = "stdTcDataGridViewTextBoxColumn";
            this.stdTcDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdPhoneDataGridViewTextBoxColumn
            // 
            this.stdPhoneDataGridViewTextBoxColumn.DataPropertyName = "StdPhone";
            this.stdPhoneDataGridViewTextBoxColumn.HeaderText = "StdPhone";
            this.stdPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdPhoneDataGridViewTextBoxColumn.Name = "stdPhoneDataGridViewTextBoxColumn";
            this.stdPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdBirthDateDataGridViewTextBoxColumn
            // 
            this.stdBirthDateDataGridViewTextBoxColumn.DataPropertyName = "StdBirthDate";
            this.stdBirthDateDataGridViewTextBoxColumn.HeaderText = "StdBirthDate";
            this.stdBirthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdBirthDateDataGridViewTextBoxColumn.Name = "stdBirthDateDataGridViewTextBoxColumn";
            this.stdBirthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdDepartmentDataGridViewTextBoxColumn
            // 
            this.stdDepartmentDataGridViewTextBoxColumn.DataPropertyName = "StdDepartment";
            this.stdDepartmentDataGridViewTextBoxColumn.HeaderText = "StdDepartment";
            this.stdDepartmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdDepartmentDataGridViewTextBoxColumn.Name = "stdDepartmentDataGridViewTextBoxColumn";
            this.stdDepartmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdMailDataGridViewTextBoxColumn
            // 
            this.stdMailDataGridViewTextBoxColumn.DataPropertyName = "StdMail";
            this.stdMailDataGridViewTextBoxColumn.HeaderText = "StdMail";
            this.stdMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdMailDataGridViewTextBoxColumn.Name = "stdMailDataGridViewTextBoxColumn";
            this.stdMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdRoomNoDataGridViewTextBoxColumn
            // 
            this.stdRoomNoDataGridViewTextBoxColumn.DataPropertyName = "StdRoomNo";
            this.stdRoomNoDataGridViewTextBoxColumn.HeaderText = "StdRoomNo";
            this.stdRoomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdRoomNoDataGridViewTextBoxColumn.Name = "stdRoomNoDataGridViewTextBoxColumn";
            this.stdRoomNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdParrentNameDataGridViewTextBoxColumn
            // 
            this.stdParrentNameDataGridViewTextBoxColumn.DataPropertyName = "StdParrentName";
            this.stdParrentNameDataGridViewTextBoxColumn.HeaderText = "StdParrentName";
            this.stdParrentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdParrentNameDataGridViewTextBoxColumn.Name = "stdParrentNameDataGridViewTextBoxColumn";
            this.stdParrentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdParrentPhoneDataGridViewTextBoxColumn
            // 
            this.stdParrentPhoneDataGridViewTextBoxColumn.DataPropertyName = "StdParrentPhone";
            this.stdParrentPhoneDataGridViewTextBoxColumn.HeaderText = "StdParrentPhone";
            this.stdParrentPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdParrentPhoneDataGridViewTextBoxColumn.Name = "stdParrentPhoneDataGridViewTextBoxColumn";
            this.stdParrentPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdAdressDataGridViewTextBoxColumn
            // 
            this.stdAdressDataGridViewTextBoxColumn.DataPropertyName = "StdAdress";
            this.stdAdressDataGridViewTextBoxColumn.HeaderText = "StdAdress";
            this.stdAdressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdAdressDataGridViewTextBoxColumn.Name = "stdAdressDataGridViewTextBoxColumn";
            this.stdAdressDataGridViewTextBoxColumn.Width = 125;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentList";
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormRegistry2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DormOtomationDataSet5 dormOtomationDataSet5;
        private System.Windows.Forms.BindingSource tblDormRegistry2BindingSource;
        private DormOtomationDataSet5TableAdapters.Tbl_DormRegistry2TableAdapter tbl_DormRegistry2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdRoomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdParrentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdParrentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdAdressDataGridViewTextBoxColumn;
    }
}