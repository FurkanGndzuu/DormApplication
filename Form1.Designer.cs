namespace DormApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtParrentName = new System.Windows.Forms.TextBox();
            this.rchAdress = new System.Windows.Forms.RichTextBox();
            this.mskStudentTc = new System.Windows.Forms.MaskedTextBox();
            this.mskStudentPhone = new System.Windows.Forms.MaskedTextBox();
            this.mskBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.mskParrentPhone = new System.Windows.Forms.MaskedTextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Surname : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student T.C :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student BirthDate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Room No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Student Mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Student Department :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adress :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 27);
            this.label10.TabIndex = 9;
            this.label10.Text = "Parrent Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Parrent Phone :";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStudentName.Location = new System.Drawing.Point(258, 32);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(316, 34);
            this.txtStudentName.TabIndex = 11;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStudentSurname.Location = new System.Drawing.Point(259, 81);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(316, 34);
            this.txtStudentSurname.TabIndex = 12;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMail.Location = new System.Drawing.Point(259, 327);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(316, 34);
            this.txtMail.TabIndex = 13;
            // 
            // txtParrentName
            // 
            this.txtParrentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtParrentName.Location = new System.Drawing.Point(259, 431);
            this.txtParrentName.Name = "txtParrentName";
            this.txtParrentName.Size = new System.Drawing.Size(316, 34);
            this.txtParrentName.TabIndex = 14;
            // 
            // rchAdress
            // 
            this.rchAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rchAdress.Location = new System.Drawing.Point(259, 537);
            this.rchAdress.Name = "rchAdress";
            this.rchAdress.Size = new System.Drawing.Size(315, 104);
            this.rchAdress.TabIndex = 15;
            this.rchAdress.Text = "";
            // 
            // mskStudentTc
            // 
            this.mskStudentTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskStudentTc.Location = new System.Drawing.Point(259, 124);
            this.mskStudentTc.Mask = "00000000000";
            this.mskStudentTc.Name = "mskStudentTc";
            this.mskStudentTc.Size = new System.Drawing.Size(316, 34);
            this.mskStudentTc.TabIndex = 16;
            // 
            // mskStudentPhone
            // 
            this.mskStudentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskStudentPhone.Location = new System.Drawing.Point(259, 169);
            this.mskStudentPhone.Mask = "(999) 000-0000";
            this.mskStudentPhone.Name = "mskStudentPhone";
            this.mskStudentPhone.Size = new System.Drawing.Size(315, 34);
            this.mskStudentPhone.TabIndex = 17;
            // 
            // mskBirthDate
            // 
            this.mskBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskBirthDate.Location = new System.Drawing.Point(258, 220);
            this.mskBirthDate.Mask = "00/00/0000";
            this.mskBirthDate.Name = "mskBirthDate";
            this.mskBirthDate.Size = new System.Drawing.Size(315, 34);
            this.mskBirthDate.TabIndex = 18;
            this.mskBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskParrentPhone
            // 
            this.mskParrentPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskParrentPhone.Location = new System.Drawing.Point(260, 485);
            this.mskParrentPhone.Mask = "(999) 000-0000";
            this.mskParrentPhone.Name = "mskParrentPhone";
            this.mskParrentPhone.Size = new System.Drawing.Size(315, 34);
            this.mskParrentPhone.TabIndex = 19;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(258, 271);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(316, 35);
            this.cmbDepartment.TabIndex = 20;
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(260, 374);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(316, 35);
            this.cmbRoomNo.TabIndex = 21;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAdd.Location = new System.Drawing.Point(360, 658);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(216, 71);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "Student Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 621);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 27);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(667, 741);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnAdd);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtParrentName;
        private System.Windows.Forms.RichTextBox rchAdress;
        private System.Windows.Forms.MaskedTextBox mskStudentTc;
        private System.Windows.Forms.MaskedTextBox mskStudentPhone;
        private System.Windows.Forms.MaskedTextBox mskBirthDate;
        private System.Windows.Forms.MaskedTextBox mskParrentPhone;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label12;
    }
}

