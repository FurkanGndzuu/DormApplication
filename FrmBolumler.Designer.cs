namespace DormApplication
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDepartmentId = new System.Windows.Forms.TextBox();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.dormOtomationDataSet = new DormApplication.DormOtomationDataSet();
            this.tblStdDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StdDepartmentTableAdapter = new DormApplication.DormOtomationDataSetTableAdapters.Tbl_StdDepartmentTableAdapter();
            this.dormOtomationDataSet1 = new DormApplication.DormOtomationDataSet1();
            this.tblStdDepartmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StdDepartmentTableAdapter1 = new DormApplication.DormOtomationDataSet1TableAdapters.Tbl_StdDepartmentTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dormOtomationDataSet2 = new DormApplication.DormOtomationDataSet2();
            this.tblStdDepartmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StdDepartmentTableAdapter2 = new DormApplication.DormOtomationDataSet2TableAdapters.Tbl_StdDepartmentTableAdapter();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStdDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStdDepartmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStdDepartmentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(610, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Department Add");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(676, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Department Update");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(743, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Department Delete");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department Name :";
            // 
            // TxtDepartmentId
            // 
            this.TxtDepartmentId.Location = new System.Drawing.Point(265, 57);
            this.TxtDepartmentId.Name = "TxtDepartmentId";
            this.TxtDepartmentId.Size = new System.Drawing.Size(251, 34);
            this.TxtDepartmentId.TabIndex = 5;
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(265, 129);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(251, 34);
            this.txtDepartmentName.TabIndex = 6;
            // 
            // dormOtomationDataSet
            // 
            this.dormOtomationDataSet.DataSetName = "DormOtomationDataSet";
            this.dormOtomationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStdDepartmentBindingSource
            // 
            this.tblStdDepartmentBindingSource.DataMember = "Tbl_StdDepartment";
            this.tblStdDepartmentBindingSource.DataSource = this.dormOtomationDataSet;
            // 
            // tbl_StdDepartmentTableAdapter
            // 
            this.tbl_StdDepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // dormOtomationDataSet1
            // 
            this.dormOtomationDataSet1.DataSetName = "DormOtomationDataSet1";
            this.dormOtomationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStdDepartmentBindingSource1
            // 
            this.tblStdDepartmentBindingSource1.DataMember = "Tbl_StdDepartment";
            this.tblStdDepartmentBindingSource1.DataSource = this.dormOtomationDataSet1;
            // 
            // tbl_StdDepartmentTableAdapter1
            // 
            this.tbl_StdDepartmentTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIDDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStdDepartmentBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 314);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dormOtomationDataSet2
            // 
            this.dormOtomationDataSet2.DataSetName = "DormOtomationDataSet2";
            this.dormOtomationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStdDepartmentBindingSource2
            // 
            this.tblStdDepartmentBindingSource2.DataMember = "Tbl_StdDepartment";
            this.tblStdDepartmentBindingSource2.DataSource = this.dormOtomationDataSet2;
            // 
            // tbl_StdDepartmentTableAdapter2
            // 
            this.tbl_StdDepartmentTableAdapter2.ClearBeforeFill = true;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIDDataGridViewTextBoxColumn.Width = 186;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(851, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.TxtDepartmentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "FrmBolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStdDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStdDepartmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStdDepartmentBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDepartmentId;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private DormOtomationDataSet dormOtomationDataSet;
        private System.Windows.Forms.BindingSource tblStdDepartmentBindingSource;
        private DormOtomationDataSetTableAdapters.Tbl_StdDepartmentTableAdapter tbl_StdDepartmentTableAdapter;
        private DormOtomationDataSet1 dormOtomationDataSet1;
        private System.Windows.Forms.BindingSource tblStdDepartmentBindingSource1;
        private DormOtomationDataSet1TableAdapters.Tbl_StdDepartmentTableAdapter tbl_StdDepartmentTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DormOtomationDataSet2 dormOtomationDataSet2;
        private System.Windows.Forms.BindingSource tblStdDepartmentBindingSource2;
        private DormOtomationDataSet2TableAdapters.Tbl_StdDepartmentTableAdapter tbl_StdDepartmentTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}