namespace StudentRegistrationApplication
{
    partial class Student
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TBLastName = new TextBox();
            TBFirstName = new TextBox();
            TBMiddleName = new TextBox();
            RBMale = new RadioButton();
            RBFemale = new RadioButton();
            CBDay = new ComboBox();
            CBMonth = new ComboBox();
            CBYear = new ComboBox();
            CBProgram = new ComboBox();
            BRegister = new Button();
            PBPicture = new PictureBox();
            BBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)PBPicture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(277, 24);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 56);
            label2.Name = "label2";
            label2.Size = new Size(100, 18);
            label2.TabIndex = 1;
            label2.Text = "Last Name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 114);
            label3.Name = "label3";
            label3.Size = new Size(101, 18);
            label3.TabIndex = 2;
            label3.Text = "First Name*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 172);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 3;
            label4.Text = "Middle Name*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 228);
            label5.Name = "label5";
            label5.Size = new Size(75, 18);
            label5.TabIndex = 4;
            label5.Text = "Gender*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 260);
            label6.Name = "label6";
            label6.Size = new Size(113, 18);
            label6.TabIndex = 5;
            label6.Text = "Date of birth*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 330);
            label7.Name = "label7";
            label7.Size = new Size(151, 18);
            label7.TabIndex = 6;
            label7.Text = "Program to apply*";
            // 
            // TBLastName
            // 
            TBLastName.Location = new Point(33, 77);
            TBLastName.Name = "TBLastName";
            TBLastName.Size = new Size(375, 23);
            TBLastName.TabIndex = 7;
            // 
            // TBFirstName
            // 
            TBFirstName.Location = new Point(33, 135);
            TBFirstName.Name = "TBFirstName";
            TBFirstName.Size = new Size(375, 23);
            TBFirstName.TabIndex = 8;
            // 
            // TBMiddleName
            // 
            TBMiddleName.Location = new Point(33, 193);
            TBMiddleName.Name = "TBMiddleName";
            TBMiddleName.Size = new Size(375, 23);
            TBMiddleName.TabIndex = 9;
            // 
            // RBMale
            // 
            RBMale.AutoSize = true;
            RBMale.Location = new Point(124, 229);
            RBMale.Name = "RBMale";
            RBMale.Size = new Size(51, 19);
            RBMale.TabIndex = 10;
            RBMale.TabStop = true;
            RBMale.Text = "Male";
            RBMale.UseVisualStyleBackColor = true;
            // 
            // RBFemale
            // 
            RBFemale.AutoSize = true;
            RBFemale.Location = new Point(181, 229);
            RBFemale.Name = "RBFemale";
            RBFemale.Size = new Size(63, 19);
            RBFemale.TabIndex = 11;
            RBFemale.TabStop = true;
            RBFemale.Text = "Female";
            RBFemale.UseVisualStyleBackColor = true;
            // 
            // CBDay
            // 
            CBDay.FormattingEnabled = true;
            CBDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            CBDay.Location = new Point(33, 290);
            CBDay.Name = "CBDay";
            CBDay.Size = new Size(121, 23);
            CBDay.TabIndex = 12;
            CBDay.Text = "-Day-";
            // 
            // CBMonth
            // 
            CBMonth.FormattingEnabled = true;
            CBMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            CBMonth.Location = new Point(160, 290);
            CBMonth.Name = "CBMonth";
            CBMonth.Size = new Size(121, 23);
            CBMonth.TabIndex = 13;
            CBMonth.Text = "-Month-";
            // 
            // CBYear
            // 
            CBYear.FormattingEnabled = true;
            CBYear.Items.AddRange(new object[] { "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010" });
            CBYear.Location = new Point(287, 290);
            CBYear.Name = "CBYear";
            CBYear.Size = new Size(121, 23);
            CBYear.TabIndex = 14;
            CBYear.Text = "-Year-";
            // 
            // CBProgram
            // 
            CBProgram.FormattingEnabled = true;
            CBProgram.Items.AddRange(new object[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Business Administration", "Bachelor of Science in Accounting Information System", "Bachelor of Science in Accountancy", "Bachelor of Science in Hospitality Management", "Bachelor of Arts in Communication", "Bachelor of Multimedia Arts", "Bachelor of Science in Tourism Management" });
            CBProgram.Location = new Point(33, 351);
            CBProgram.Name = "CBProgram";
            CBProgram.Size = new Size(375, 23);
            CBProgram.TabIndex = 15;
            CBProgram.Text = "-Select program-";
            // 
            // BRegister
            // 
            BRegister.BackColor = Color.IndianRed;
            BRegister.Location = new Point(103, 390);
            BRegister.Name = "BRegister";
            BRegister.Size = new Size(207, 37);
            BRegister.TabIndex = 16;
            BRegister.Text = "Register Student";
            BRegister.UseVisualStyleBackColor = false;
            BRegister.Click += button1_Click;
            // 
            // PBPicture
            // 
            PBPicture.BackColor = SystemColors.ButtonShadow;
            PBPicture.Location = new Point(450, 38);
            PBPicture.Name = "PBPicture";
            PBPicture.Size = new Size(279, 210);
            PBPicture.TabIndex = 17;
            PBPicture.TabStop = false;
            // 
            // BBrowse
            // 
            BBrowse.BackColor = Color.IndianRed;
            BBrowse.Location = new Point(546, 260);
            BBrowse.Name = "BBrowse";
            BBrowse.Size = new Size(107, 32);
            BBrowse.TabIndex = 18;
            BBrowse.Text = "Browse";
            BBrowse.UseVisualStyleBackColor = false;
            BBrowse.Click += BBrowse_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BBrowse);
            Controls.Add(PBPicture);
            Controls.Add(BRegister);
            Controls.Add(CBProgram);
            Controls.Add(CBYear);
            Controls.Add(CBMonth);
            Controls.Add(CBDay);
            Controls.Add(RBFemale);
            Controls.Add(RBMale);
            Controls.Add(TBMiddleName);
            Controls.Add(TBFirstName);
            Controls.Add(TBLastName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Student";
            Text = "Student Registration";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)PBPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TBLastName;
        private TextBox TBFirstName;
        private TextBox TBMiddleName;
        private RadioButton RBMale;
        private RadioButton RBFemale;
        private ComboBox CBDay;
        private ComboBox CBMonth;
        private ComboBox CBYear;
        private ComboBox CBProgram;
        private Button BRegister;
        private PictureBox PBPicture;
        private Button BBrowse;
        
    }
}
