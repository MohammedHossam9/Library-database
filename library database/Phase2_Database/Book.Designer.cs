namespace Phase2_Database
{
    partial class Book
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
            this.label4 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CopiesTextBox = new System.Windows.Forms.TextBox();
            this.EditionTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PubTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UpdateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GenreList = new System.Windows.Forms.ComboBox();
            this.LangList = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.updateLang = new System.Windows.Forms.ComboBox();
            this.updateGenre = new System.Windows.Forms.ComboBox();
            this.updatePublisher = new System.Windows.Forms.TextBox();
            this.updateAuthor = new System.Windows.Forms.TextBox();
            this.updateEdition = new System.Windows.Forms.TextBox();
            this.updateCopies = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.updatePrice = new System.Windows.Forms.TextBox();
            this.updateYear = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.updateTitle = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Book Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(81, 99);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 22);
            this.TitleTextBox.TabIndex = 18;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(521, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 29);
            this.button6.TabIndex = 27;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Update);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(429, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Delete);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Insert_Book);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(94, 137);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.PriceTextBox.TabIndex = 24;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(120, 348);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 22);
            this.YearTextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Book Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Published Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Author ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pub. Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Book Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Book Language:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Book Edition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Copies No.:";
            // 
            // CopiesTextBox
            // 
            this.CopiesTextBox.Location = new System.Drawing.Point(94, 304);
            this.CopiesTextBox.Name = "CopiesTextBox";
            this.CopiesTextBox.Size = new System.Drawing.Size(100, 22);
            this.CopiesTextBox.TabIndex = 34;
            // 
            // EditionTextBox
            // 
            this.EditionTextBox.Location = new System.Drawing.Point(104, 219);
            this.EditionTextBox.Name = "EditionTextBox";
            this.EditionTextBox.Size = new System.Drawing.Size(100, 22);
            this.EditionTextBox.TabIndex = 36;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(81, 18);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(100, 22);
            this.AuthorTextBox.TabIndex = 37;
            // 
            // PubTextBox
            // 
            this.PubTextBox.Location = new System.Drawing.Point(94, 61);
            this.PubTextBox.Name = "PubTextBox";
            this.PubTextBox.Size = new System.Drawing.Size(100, 22);
            this.PubTextBox.TabIndex = 38;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(134, 392);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Book ID to Delete: ";
            // 
            // UpdateTextBox
            // 
            this.UpdateTextBox.Location = new System.Drawing.Point(134, 435);
            this.UpdateTextBox.Name = "UpdateTextBox";
            this.UpdateTextBox.Size = new System.Drawing.Size(100, 22);
            this.UpdateTextBox.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Book ID to Update: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(333, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 46;
            this.button1.Text = "Delete All!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DeleteAll);
            // 
            // GenreList
            // 
            this.GenreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreList.FormattingEnabled = true;
            this.GenreList.Items.AddRange(new object[] {
            "Comedy",
            "Comic",
            "Romantic",
            "History",
            "Fiction",
            "Novel",
            "Mystery"});
            this.GenreList.Location = new System.Drawing.Point(100, 178);
            this.GenreList.Name = "GenreList";
            this.GenreList.Size = new System.Drawing.Size(148, 24);
            this.GenreList.TabIndex = 47;
            this.GenreList.SelectedIndexChanged += new System.EventHandler(this.selected);
            // 
            // LangList
            // 
            this.LangList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LangList.FormattingEnabled = true;
            this.LangList.Items.AddRange(new object[] {
            "English ",
            "Arabic",
            "German",
            "Spanish",
            "Italian",
            "Japanese"});
            this.LangList.Location = new System.Drawing.Point(120, 262);
            this.LangList.Name = "LangList";
            this.LangList.Size = new System.Drawing.Size(148, 24);
            this.LangList.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(477, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 41);
            this.button2.TabIndex = 49;
            this.button2.Text = "To table STUDENT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.toStudent);
            // 
            // updateLang
            // 
            this.updateLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateLang.FormattingEnabled = true;
            this.updateLang.Items.AddRange(new object[] {
            "English ",
            "Arabic",
            "German",
            "Spanish",
            "Italian",
            "Japanese"});
            this.updateLang.Location = new System.Drawing.Point(124, 707);
            this.updateLang.Name = "updateLang";
            this.updateLang.Size = new System.Drawing.Size(148, 24);
            this.updateLang.TabIndex = 67;
            // 
            // updateGenre
            // 
            this.updateGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateGenre.FormattingEnabled = true;
            this.updateGenre.Items.AddRange(new object[] {
            "Comedy",
            "Comic",
            "Romantic",
            "History",
            "Fiction",
            "Novel",
            "Mystery"});
            this.updateGenre.Location = new System.Drawing.Point(100, 636);
            this.updateGenre.Name = "updateGenre";
            this.updateGenre.Size = new System.Drawing.Size(148, 24);
            this.updateGenre.TabIndex = 66;
            // 
            // updatePublisher
            // 
            this.updatePublisher.Location = new System.Drawing.Point(94, 514);
            this.updatePublisher.Name = "updatePublisher";
            this.updatePublisher.Size = new System.Drawing.Size(100, 22);
            this.updatePublisher.TabIndex = 65;
            // 
            // updateAuthor
            // 
            this.updateAuthor.Location = new System.Drawing.Point(81, 479);
            this.updateAuthor.Name = "updateAuthor";
            this.updateAuthor.Size = new System.Drawing.Size(100, 22);
            this.updateAuthor.TabIndex = 64;
            // 
            // updateEdition
            // 
            this.updateEdition.Location = new System.Drawing.Point(100, 671);
            this.updateEdition.Name = "updateEdition";
            this.updateEdition.Size = new System.Drawing.Size(100, 22);
            this.updateEdition.TabIndex = 63;
            // 
            // updateCopies
            // 
            this.updateCopies.Location = new System.Drawing.Point(95, 738);
            this.updateCopies.Name = "updateCopies";
            this.updateCopies.Size = new System.Drawing.Size(100, 22);
            this.updateCopies.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 741);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 61;
            this.label13.Text = "Copies No.:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 674);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 60;
            this.label14.Text = "Book Edition:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 710);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 16);
            this.label15.TabIndex = 59;
            this.label15.Text = "Book Language:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 639);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 16);
            this.label16.TabIndex = 58;
            this.label16.Text = "Book Genre:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 517);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 16);
            this.label17.TabIndex = 57;
            this.label17.Text = "Pub. Name:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 482);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "Author ID:";
            // 
            // updatePrice
            // 
            this.updatePrice.Location = new System.Drawing.Point(89, 596);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.Size = new System.Drawing.Size(100, 22);
            this.updatePrice.TabIndex = 55;
            // 
            // updateYear
            // 
            this.updateYear.Location = new System.Drawing.Point(120, 773);
            this.updateYear.Name = "updateYear";
            this.updateYear.Size = new System.Drawing.Size(100, 22);
            this.updateYear.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 596);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 16);
            this.label19.TabIndex = 53;
            this.label19.Text = "Book Price:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 776);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 16);
            this.label20.TabIndex = 52;
            this.label20.Text = "Published Year:";
            // 
            // updateTitle
            // 
            this.updateTitle.Location = new System.Drawing.Point(89, 549);
            this.updateTitle.Name = "updateTitle";
            this.updateTitle.Size = new System.Drawing.Size(100, 22);
            this.updateTitle.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 555);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 16);
            this.label21.TabIndex = 50;
            this.label21.Text = "Book Title:";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 861);
            this.Controls.Add(this.updateLang);
            this.Controls.Add(this.updateGenre);
            this.Controls.Add(this.updatePublisher);
            this.Controls.Add(this.updateAuthor);
            this.Controls.Add(this.updateEdition);
            this.Controls.Add(this.updateCopies);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.updatePrice);
            this.Controls.Add(this.updateYear);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.updateTitle);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LangList);
            this.Controls.Add(this.GenreList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UpdateTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PubTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.EditionTextBox);
            this.Controls.Add(this.CopiesTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Book";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CopiesTextBox;
        private System.Windows.Forms.TextBox EditionTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PubTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UpdateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GenreList;
        private System.Windows.Forms.ComboBox LangList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox updateLang;
        private System.Windows.Forms.ComboBox updateGenre;
        private System.Windows.Forms.TextBox updatePublisher;
        private System.Windows.Forms.TextBox updateAuthor;
        private System.Windows.Forms.TextBox updateEdition;
        private System.Windows.Forms.TextBox updateCopies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox updatePrice;
        private System.Windows.Forms.TextBox updateYear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox updateTitle;
        private System.Windows.Forms.Label label21;
    }
}