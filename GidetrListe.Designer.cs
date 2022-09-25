namespace DormApplication
{
    partial class GidetrListe
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
            this.dormOtomationDataSet6 = new DormApplication.DormOtomationDataSet6();
            this.tblPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PaymentsTableAdapter = new DormApplication.DormOtomationDataSet6TableAdapters.Tbl_PaymentsTableAdapter();
            this.electricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınternetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormOtomationDataSet7 = new DormApplication.DormOtomationDataSet7();
            this.tblPaymentssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_PaymentssTableAdapter = new DormApplication.DormOtomationDataSet7TableAdapters.Tbl_PaymentssTableAdapter();
            this.dormOtomationDataSet8 = new DormApplication.DormOtomationDataSet8();
            this.tblDormPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DormPaymentsTableAdapter = new DormApplication.DormOtomationDataSet8TableAdapters.Tbl_DormPaymentsTableAdapter();
            this.dormOtomationDataSet9 = new DormApplication.DormOtomationDataSet9();
            this.tblDormPaymentsssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DormPaymentsssTableAdapter = new DormApplication.DormOtomationDataSet9TableAdapters.Tbl_DormPaymentsssTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormPaymentsssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.electricDataGridViewTextBoxColumn,
            this.waterDataGridViewTextBoxColumn,
            this.gassDataGridViewTextBoxColumn,
            this.ınternetDataGridViewTextBoxColumn,
            this.foodsDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDormPaymentsssBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 409);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dormOtomationDataSet6
            // 
            this.dormOtomationDataSet6.DataSetName = "DormOtomationDataSet6";
            this.dormOtomationDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPaymentsBindingSource
            // 
            this.tblPaymentsBindingSource.DataMember = "Tbl_Payments";
            this.tblPaymentsBindingSource.DataSource = this.dormOtomationDataSet6;
            // 
            // tbl_PaymentsTableAdapter
            // 
            this.tbl_PaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // electricDataGridViewTextBoxColumn
            // 
            this.electricDataGridViewTextBoxColumn.DataPropertyName = "Electric";
            this.electricDataGridViewTextBoxColumn.HeaderText = "Electric";
            this.electricDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.electricDataGridViewTextBoxColumn.Name = "electricDataGridViewTextBoxColumn";
            this.electricDataGridViewTextBoxColumn.Width = 125;
            // 
            // waterDataGridViewTextBoxColumn
            // 
            this.waterDataGridViewTextBoxColumn.DataPropertyName = "Water";
            this.waterDataGridViewTextBoxColumn.HeaderText = "Water";
            this.waterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waterDataGridViewTextBoxColumn.Name = "waterDataGridViewTextBoxColumn";
            this.waterDataGridViewTextBoxColumn.Width = 125;
            // 
            // gassDataGridViewTextBoxColumn
            // 
            this.gassDataGridViewTextBoxColumn.DataPropertyName = "gass";
            this.gassDataGridViewTextBoxColumn.HeaderText = "gass";
            this.gassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gassDataGridViewTextBoxColumn.Name = "gassDataGridViewTextBoxColumn";
            this.gassDataGridViewTextBoxColumn.Width = 125;
            // 
            // ınternetDataGridViewTextBoxColumn
            // 
            this.ınternetDataGridViewTextBoxColumn.DataPropertyName = "Internet";
            this.ınternetDataGridViewTextBoxColumn.HeaderText = "Internet";
            this.ınternetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ınternetDataGridViewTextBoxColumn.Name = "ınternetDataGridViewTextBoxColumn";
            this.ınternetDataGridViewTextBoxColumn.Width = 125;
            // 
            // foodsDataGridViewTextBoxColumn
            // 
            this.foodsDataGridViewTextBoxColumn.DataPropertyName = "Foods";
            this.foodsDataGridViewTextBoxColumn.HeaderText = "Foods";
            this.foodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodsDataGridViewTextBoxColumn.Name = "foodsDataGridViewTextBoxColumn";
            this.foodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.Width = 125;
            // 
            // dormOtomationDataSet7
            // 
            this.dormOtomationDataSet7.DataSetName = "DormOtomationDataSet7";
            this.dormOtomationDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPaymentssBindingSource
            // 
            this.tblPaymentssBindingSource.DataMember = "Tbl_Paymentss";
            this.tblPaymentssBindingSource.DataSource = this.dormOtomationDataSet7;
            // 
            // tbl_PaymentssTableAdapter
            // 
            this.tbl_PaymentssTableAdapter.ClearBeforeFill = true;
            // 
            // dormOtomationDataSet8
            // 
            this.dormOtomationDataSet8.DataSetName = "DormOtomationDataSet8";
            this.dormOtomationDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDormPaymentsBindingSource
            // 
            this.tblDormPaymentsBindingSource.DataMember = "Tbl_DormPayments";
            this.tblDormPaymentsBindingSource.DataSource = this.dormOtomationDataSet8;
            // 
            // tbl_DormPaymentsTableAdapter
            // 
            this.tbl_DormPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // dormOtomationDataSet9
            // 
            this.dormOtomationDataSet9.DataSetName = "DormOtomationDataSet9";
            this.dormOtomationDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDormPaymentsssBindingSource
            // 
            this.tblDormPaymentsssBindingSource.DataMember = "Tbl_DormPaymentsss";
            this.tblDormPaymentsssBindingSource.DataSource = this.dormOtomationDataSet9;
            // 
            // tbl_DormPaymentsssTableAdapter
            // 
            this.tbl_DormPaymentsssTableAdapter.ClearBeforeFill = true;
            // 
            // GidetrListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(931, 409);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GidetrListe";
            this.Text = "GidetrListe";
            this.Load += new System.EventHandler(this.GidetrListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormOtomationDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDormPaymentsssBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DormOtomationDataSet6 dormOtomationDataSet6;
        private System.Windows.Forms.BindingSource tblPaymentsBindingSource;
        private DormOtomationDataSet6TableAdapters.Tbl_PaymentsTableAdapter tbl_PaymentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınternetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private DormOtomationDataSet7 dormOtomationDataSet7;
        private System.Windows.Forms.BindingSource tblPaymentssBindingSource;
        private DormOtomationDataSet7TableAdapters.Tbl_PaymentssTableAdapter tbl_PaymentssTableAdapter;
        private DormOtomationDataSet8 dormOtomationDataSet8;
        private System.Windows.Forms.BindingSource tblDormPaymentsBindingSource;
        private DormOtomationDataSet8TableAdapters.Tbl_DormPaymentsTableAdapter tbl_DormPaymentsTableAdapter;
        private DormOtomationDataSet9 dormOtomationDataSet9;
        private System.Windows.Forms.BindingSource tblDormPaymentsssBindingSource;
        private DormOtomationDataSet9TableAdapters.Tbl_DormPaymentsssTableAdapter tbl_DormPaymentsssTableAdapter;
    }
}