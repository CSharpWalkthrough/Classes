namespace Classes.Exercice
{
    partial class FrmMain
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
            this.pnlClasses = new System.Windows.Forms.Panel();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cboClasses = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvwStudents = new System.Windows.Forms.ListView();
            this.chFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chlClasses = new System.Windows.Forms.CheckedListBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblNewStudent = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlClasses.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClasses
            // 
            this.pnlClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClasses.Controls.Add(this.lblClass);
            this.pnlClasses.Controls.Add(this.txtTeacher);
            this.pnlClasses.Controls.Add(this.lblStudents);
            this.pnlClasses.Controls.Add(this.lblTeacher);
            this.pnlClasses.Controls.Add(this.txtSubject);
            this.pnlClasses.Controls.Add(this.cboClasses);
            this.pnlClasses.Controls.Add(this.lblSubject);
            this.pnlClasses.Controls.Add(this.btnEdit);
            this.pnlClasses.Controls.Add(this.lvwStudents);
            this.pnlClasses.Location = new System.Drawing.Point(12, 12);
            this.pnlClasses.Name = "pnlClasses";
            this.pnlClasses.Size = new System.Drawing.Size(358, 426);
            this.pnlClasses.TabIndex = 0;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblClass.Location = new System.Drawing.Point(21, 24);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(40, 15);
            this.lblClass.TabIndex = 8;
            this.lblClass.Text = "Class:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTeacher.Location = new System.Drawing.Point(84, 124);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(137, 21);
            this.txtTeacher.TabIndex = 7;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStudents.Location = new System.Drawing.Point(21, 159);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(58, 15);
            this.lblStudents.TabIndex = 6;
            this.lblStudents.Text = "Students:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTeacher.Location = new System.Drawing.Point(21, 126);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(55, 15);
            this.lblTeacher.TabIndex = 5;
            this.lblTeacher.Text = "Teacher:";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSubject.Location = new System.Drawing.Point(84, 90);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(137, 21);
            this.txtSubject.TabIndex = 4;
            // 
            // cboClasses
            // 
            this.cboClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(24, 46);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(293, 23);
            this.cboClasses.TabIndex = 3;
            this.cboClasses.SelectedIndexChanged += new System.EventHandler(this.cboClasses_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSubject.Location = new System.Drawing.Point(21, 92);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 15);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject:";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEdit.Location = new System.Drawing.Point(117, 379);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lvwStudents
            // 
            this.lvwStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFullName,
            this.chAge});
            this.lvwStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lvwStudents.FullRowSelect = true;
            this.lvwStudents.HideSelection = false;
            this.lvwStudents.Location = new System.Drawing.Point(24, 187);
            this.lvwStudents.Name = "lvwStudents";
            this.lvwStudents.Size = new System.Drawing.Size(306, 177);
            this.lvwStudents.TabIndex = 0;
            this.lvwStudents.UseCompatibleStateImageBehavior = false;
            this.lvwStudents.View = System.Windows.Forms.View.Details;
            // 
            // chFullName
            // 
            this.chFullName.Text = "Full Name";
            this.chFullName.Width = 212;
            // 
            // chAge
            // 
            this.chAge.Text = "Age";
            this.chAge.Width = 90;
            // 
            // pnlStudent
            // 
            this.pnlStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudent.Controls.Add(this.label1);
            this.pnlStudent.Controls.Add(this.btnAdd);
            this.pnlStudent.Controls.Add(this.chlClasses);
            this.pnlStudent.Controls.Add(this.txtBirthday);
            this.pnlStudent.Controls.Add(this.lblBirthday);
            this.pnlStudent.Controls.Add(this.txtLastName);
            this.pnlStudent.Controls.Add(this.lblNewStudent);
            this.pnlStudent.Controls.Add(this.lblLastName);
            this.pnlStudent.Controls.Add(this.txtFirstName);
            this.pnlStudent.Controls.Add(this.lblFirstName);
            this.pnlStudent.Location = new System.Drawing.Point(388, 12);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(330, 426);
            this.pnlStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(31, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Classes:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Location = new System.Drawing.Point(111, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chlClasses
            // 
            this.chlClasses.CheckOnClick = true;
            this.chlClasses.FormattingEnabled = true;
            this.chlClasses.Location = new System.Drawing.Point(34, 255);
            this.chlClasses.Name = "chlClasses";
            this.chlClasses.Size = new System.Drawing.Size(265, 109);
            this.chlClasses.TabIndex = 15;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBirthday.Location = new System.Drawing.Point(34, 191);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(142, 21);
            this.txtBirthday.TabIndex = 14;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBirthday.Location = new System.Drawing.Point(31, 165);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(127, 15);
            this.lblBirthday.TabIndex = 13;
            this.lblBirthday.Text = "Birthday (MM/dd/yyyy):";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtLastName.Location = new System.Drawing.Point(34, 130);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 21);
            this.txtLastName.TabIndex = 12;
            // 
            // lblNewStudent
            // 
            this.lblNewStudent.AutoSize = true;
            this.lblNewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F);
            this.lblNewStudent.Location = new System.Drawing.Point(130, 17);
            this.lblNewStudent.Name = "lblNewStudent";
            this.lblNewStudent.Size = new System.Drawing.Size(83, 16);
            this.lblNewStudent.TabIndex = 0;
            this.lblNewStudent.Text = "New Student";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLastName.Location = new System.Drawing.Point(31, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 15);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(34, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(142, 21);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFirstName.Location = new System.Drawing.Point(31, 49);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.pnlClasses);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.pnlClasses.ResumeLayout(false);
            this.pnlClasses.PerformLayout();
            this.pnlStudent.ResumeLayout(false);
            this.pnlStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClasses;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cboClasses;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lvwStudents;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Label lblNewStudent;
        private System.Windows.Forms.ColumnHeader chFullName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.CheckedListBox chlClasses;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}

