namespace DormApplication
{
    partial class Debt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dormOtomationDataSet4 = new DormApplication.DormOtomationDataSet4();
            this.tblStudentDebtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StudentDebtTableAdapter = new DormApplication.DormOtomationDataSet4TableAdapters.Tbl_StudentDebtTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDebtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentDebtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(216, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(223, 34);
            this.txtId.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(216, 82);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(223, 34);
            this.TxtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(216, 186);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(223, 34);
            this.txtpaid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Paid :";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(216, 133);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(223, 34);
            this.txtSurname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "SurName :";
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(216, 241);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(223, 34);
            this.txtDebt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Remaining Debt :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Get Paid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.stdFirstNameDataGridViewTextBoxColumn,
            this.stdLastNameDataGridViewTextBoxColumn,
            this.stdDebtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentDebtBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(463, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 317);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dormOtomationDataSet4
            // 
            this.dormOtomationDataSet4.DataSetName = "DormOtomationDataSet4";
            this.dormOtomationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentDebtBindingSource
            // 
            this.tblStudentDebtBindingSource.DataMember = "Tbl_StudentDebt";
            this.tblStudentDebtBindingSource.DataSource = this.dormOtomationDataSet4;
            // 
            // tbl_StudentDebtTableAdapter
            // 
            this.tbl_StudentDebtTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdFirstNameDataGridViewTextBoxColumn
            // 
            this.stdFirstNameDataGridViewTextBoxColumn.DataPropertyName = "StdFirstName";
            this.stdFirstNameDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.stdFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdFirstNameDataGridViewTextBoxColumn.Name = "stdFirstNameDataGridViewTextBoxColumn";
            this.stdFirstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdLastNameDataGridViewTextBoxColumn
            // 
            this.stdLastNameDataGridViewTextBoxColumn.DataPropertyName = "StdLastName";
            this.stdLastNameDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.stdLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdLastNameDataGridViewTextBoxColumn.Name = "stdLastNameDataGridViewTextBoxColumn";
            this.stdLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // stdDebtDataGridViewTextBoxColumn
            // 
            this.stdDebtDataGridViewTextBoxColumn.DataPropertyName = "StdDebt";
            this.stdDebtDataGridViewTextBoxColumn.HeaderText = "DEBT";
            this.stdDebtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdDebtDataGridViewTextBoxColumn.Name = "stdDebtDataGridViewTextBoxColumn";
            this.stdDebtDataGridViewTextBoxColumn.Width = 125;
            // 
            // Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1033, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Debt";
            this.Text = "Debt";
            this.Load += new System.EventHandler(this.Debt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentDebtBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DormOtomationDataSet4 dormOtomationDataSet4;
        private System.Windows.Forms.BindingSource tblStudentDebtBindingSource;
        private DormOtomationDataSet4TableAdapters.Tbl_StudentDebtTableAdapter tbl_StudentDebtTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDebtDataGridViewTextBoxColumn;
    }
}