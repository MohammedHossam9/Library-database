namespace Phase2_Database
{
    partial class Student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FacultyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BdateTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NewFacultyTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Location = new System.Drawing.Point(90, 55);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.FnameTextBox.TabIndex = 4;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Location = new System.Drawing.Point(90, 92);
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.LnameTextBox.TabIndex = 5;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(66, 129);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Insert_student);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Update);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Delete);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "Join";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Join);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(57, 274);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 22);
            this.AgeTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Age:";
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Location = new System.Drawing.Point(73, 240);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(100, 22);
            this.FacultyTextBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Faculty:";
            // 
            // BdateTextBox
            // 
            this.BdateTextBox.Location = new System.Drawing.Point(78, 204);
            this.BdateTextBox.Name = "BdateTextBox";
            this.BdateTextBox.Size = new System.Drawing.Size(100, 22);
            this.BdateTextBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Birth Date:";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Location = new System.Drawing.Point(66, 167);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(100, 22);
            this.MobileTextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mobile:";
            // 
            // UpdateTextBox
            // 
            this.UpdateTextBox.Location = new System.Drawing.Point(149, 394);
            this.UpdateTextBox.Name = "UpdateTextBox";
            this.UpdateTextBox.Size = new System.Drawing.Size(100, 22);
            this.UpdateTextBox.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "Student ID to Update: ";
            // 
            // NewFacultyTextBox
            // 
            this.NewFacultyTextBox.Location = new System.Drawing.Point(101, 435);
            this.NewFacultyTextBox.Name = "NewFacultyTextBox";
            this.NewFacultyTextBox.Size = new System.Drawing.Size(100, 22);
            this.NewFacultyTextBox.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "New Faculty: ";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(149, 354);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Student ID to Delete: ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(733, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 28);
            this.button5.TabIndex = 52;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Show);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(66, 638);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 61);
            this.button6.TabIndex = 53;
            this.button6.Text = "Delete All!!";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.DeleteAll);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Location = new System.Drawing.Point(490, 107);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 41);
            this.button7.TabIndex = 54;
            this.button7.Text = "Generate Report";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.report);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(640, 107);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(138, 41);
            this.button8.TabIndex = 55;
            this.button8.Text = "To table BOOK";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.toBook);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 855);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.UpdateTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NewFacultyTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BdateTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FacultyTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LnameTextBox);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FacultyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BdateTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UpdateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NewFacultyTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

