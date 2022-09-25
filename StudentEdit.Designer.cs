namespace DormApplication
{
    partial class StudentEdit
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
            this.label12 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.mskParrentPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.mskStudentPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskStudentTc = new System.Windows.Forms.MaskedTextBox();
            this.rchAdress = new System.Windows.Forms.RichTextBox();
            this.txtParrentName = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 644);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 27);
            this.label12.TabIndex = 47;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnUpdate.Location = new System.Drawing.Point(370, 707);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(216, 71);
            this.BtnUpdate.TabIndex = 46;
            this.BtnUpdate.Text = "Student Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(273, 417);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(316, 35);
            this.cmbRoomNo.TabIndex = 45;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(271, 314);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(316, 35);
            this.cmbDepartment.TabIndex = 44;
            // 
            // mskParrentPhone
            // 
            this.mskParrentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskParrentPhone.Location = new System.Drawing.Point(273, 528);
            this.mskParrentPhone.Mask = "(999) 000-0000";
            this.mskParrentPhone.Name = "mskParrentPhone";
            this.mskParrentPhone.Size = new System.Drawing.Size(315, 34);
            this.mskParrentPhone.TabIndex = 43;
            // 
            // mskBirthDate
            // 
            this.mskBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskBirthDate.Location = new System.Drawing.Point(271, 263);
            this.mskBirthDate.Mask = "00/00/0000";
            this.mskBirthDate.Name = "mskBirthDate";
            this.mskBirthDate.Size = new System.Drawing.Size(315, 34);
            this.mskBirthDate.TabIndex = 42;
            this.mskBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskStudentPhone
            // 
            this.mskStudentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskStudentPhone.Location = new System.Drawing.Point(272, 212);
            this.mskStudentPhone.Mask = "(999) 000-0000";
            this.mskStudentPhone.Name = "mskStudentPhone";
            this.mskStudentPhone.Size = new System.Drawing.Size(315, 34);
            this.mskStudentPhone.TabIndex = 41;
            // 
            // mskStudentTc
            // 
            this.mskStudentTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskStudentTc.Location = new System.Drawing.Point(272, 167);
            this.mskStudentTc.Mask = "00000000000";
            this.mskStudentTc.Name = "mskStudentTc";
            this.mskStudentTc.Size = new System.Drawing.Size(316, 34);
            this.mskStudentTc.TabIndex = 40;
            // 
            // rchAdress
            // 
            this.rchAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rchAdress.Location = new System.Drawing.Point(272, 580);
            this.rchAdress.Name = "rchAdress";
            this.rchAdress.Size = new System.Drawing.Size(315, 104);
            this.rchAdress.TabIndex = 39;
            this.rchAdress.Text = "";
            // 
            // txtParrentName
            // 
            this.txtParrentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtParrentName.Location = new System.Drawing.Point(272, 474);
            this.txtParrentName.Name = "txtParrentName";
            this.txtParrentName.Size = new System.Drawing.Size(316, 34);
            this.txtParrentName.TabIndex = 38;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMail.Location = new System.Drawing.Point(272, 370);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(316, 34);
            this.txtMail.TabIndex = 37;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStudentSurname.Location = new System.Drawing.Point(272, 124);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(316, 34);
            this.txtStudentSurname.TabIndex = 36;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStudentName.Location = new System.Drawing.Point(271, 75);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(316, 34);
            this.txtStudentName.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 27);
            this.label11.TabIndex = 34;
            this.label11.Text = "Parrent Phone :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 27);
            this.label10.TabIndex = 33;
            this.label10.Text = "Parrent Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 583);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 27);
            this.label9.TabIndex = 32;
            this.label9.Text = "Adress :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 27);
            this.label8.TabIndex = 31;
            this.label8.Text = "Student Department :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 27);
            this.label7.TabIndex = 30;
            this.label7.Text = "Student Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 27);
            this.label6.TabIndex = 29;
            this.label6.Text = "Student Room No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Student BirthDate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "Student Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "Student T.C :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Student Surname : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Student Name :";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Location = new System.Drawing.Point(273, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(316, 34);
            this.txtId.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(113, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 27);
            this.label13.TabIndex = 48;
            this.label13.Text = "Student ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDelete.Location = new System.Drawing.Point(118, 707);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 71);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Student Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // StudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 790);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.cmbRoomNo);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.mskParrentPhone);
            this.Controls.Add(this.mskBirthDate);
            this.Controls.Add(this.mskStudentPhone);
            this.Controls.Add(this.mskStudentTc);
            this.Controls.Add(this.rchAdress);
            this.Controls.Add(this.txtParrentName);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentEdit";
            this.Text = "StudentEdit";
            this.Load += new System.EventHandler(this.StudentEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.MaskedTextBox mskParrentPhone;
        private System.Windows.Forms.MaskedTextBox mskBirthDate;
        private System.Windows.Forms.MaskedTextBox mskStudentPhone;
        private System.Windows.Forms.MaskedTextBox mskStudentTc;
        private System.Windows.Forms.RichTextBox rchAdress;
        private System.Windows.Forms.TextBox txtParrentName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelete;
    }
}