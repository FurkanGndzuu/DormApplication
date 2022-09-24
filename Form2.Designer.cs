namespace DormApplication
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaprtmentUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dormOtomationDataSet3 = new DormApplication.DormOtomationDataSet3();
            this.tblDormRegistry2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DormRegistry2TableAdapter = new DormApplication.DormOtomationDataSet3TableAdapters.Tbl_DormRegistry2TableAdapter();
            this.stdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdRoomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormRegistry2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.staticticsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentAddToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.studentToolStripMenuItem1});
            this.studentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // studentAddToolStripMenuItem
            // 
            this.studentAddToolStripMenuItem.Name = "studentAddToolStripMenuItem";
            this.studentAddToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.studentAddToolStripMenuItem.Text = "Student Add";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.studentToolStripMenuItem.Text = "Student List";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(224, 32);
            this.studentToolStripMenuItem1.Text = "Student Edit";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentAddToolStripMenuItem,
            this.deaprtmentUpdateToolStripMenuItem});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(150, 32);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // departmentAddToolStripMenuItem
            // 
            this.departmentAddToolStripMenuItem.Name = "departmentAddToolStripMenuItem";
            this.departmentAddToolStripMenuItem.Size = new System.Drawing.Size(287, 32);
            this.departmentAddToolStripMenuItem.Text = "Department Add";
            // 
            // deaprtmentUpdateToolStripMenuItem
            // 
            this.deaprtmentUpdateToolStripMenuItem.Name = "deaprtmentUpdateToolStripMenuItem";
            this.deaprtmentUpdateToolStripMenuItem.Size = new System.Drawing.Size(287, 32);
            this.deaprtmentUpdateToolStripMenuItem.Text = "Deaprtment Update";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getPaidToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(118, 32);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // getPaidToolStripMenuItem
            // 
            this.getPaidToolStripMenuItem.Name = "getPaidToolStripMenuItem";
            this.getPaidToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.getPaidToolStripMenuItem.Text = "Get Paid";
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenseToolStripMenuItem,
            this.expenseListToolStripMenuItem});
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.addExpenseToolStripMenuItem.Text = "Add Expense";
            // 
            // expenseListToolStripMenuItem
            // 
            this.expenseListToolStripMenuItem.Name = "expenseListToolStripMenuItem";
            this.expenseListToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.expenseListToolStripMenuItem.Text = "Expense List";
            // 
            // staticticsToolStripMenuItem
            // 
            this.staticticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.expenseStatisticsToolStripMenuItem});
            this.staticticsToolStripMenuItem.Name = "staticticsToolStripMenuItem";
            this.staticticsToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.staticticsToolStripMenuItem.Text = "Statistics";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.eToolStripMenuItem.Text = "Income Statistics";
            // 
            // expenseStatisticsToolStripMenuItem
            // 
            this.expenseStatisticsToolStripMenuItem.Name = "expenseStatisticsToolStripMenuItem";
            this.expenseStatisticsToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.expenseStatisticsToolStripMenuItem.Text = "Expense Statistics";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordProcessToolStripMenuItem,
            this.editEmployeeToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // passwordProcessToolStripMenuItem
            // 
            this.passwordProcessToolStripMenuItem.Name = "passwordProcessToolStripMenuItem";
            this.passwordProcessToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.passwordProcessToolStripMenuItem.Text = "Password Process";
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
            this.editEmployeeToolStripMenuItem.Text = "Edit Employee";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdIdDataGridViewTextBoxColumn,
            this.stdFirstNameDataGridViewTextBoxColumn,
            this.stdLastNameDataGridViewTextBoxColumn,
            this.stdRoomNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDormRegistry2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 357);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(596, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(651, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // dormOtomationDataSet3
            // 
            this.dormOtomationDataSet3.DataSetName = "DormOtomationDataSet3";
            this.dormOtomationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDormRegistry2BindingSource
            // 
            this.tblDormRegistry2BindingSource.DataMember = "Tbl_DormRegistry2";
            this.tblDormRegistry2BindingSource.DataSource = this.dormOtomationDataSet3;
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
            // stdRoomNoDataGridViewTextBoxColumn
            // 
            this.stdRoomNoDataGridViewTextBoxColumn.DataPropertyName = "StdRoomNo";
            this.stdRoomNoDataGridViewTextBoxColumn.HeaderText = "StdRoomNo";
            this.stdRoomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdRoomNoDataGridViewTextBoxColumn.Name = "stdRoomNoDataGridViewTextBoxColumn";
            this.stdRoomNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormRegistry2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaprtmentUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DormOtomationDataSet3 dormOtomationDataSet3;
        private System.Windows.Forms.BindingSource tblDormRegistry2BindingSource;
        private DormOtomationDataSet3TableAdapters.Tbl_DormRegistry2TableAdapter tbl_DormRegistry2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdRoomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}