
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Phase2_Database
{
    public partial class Student : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-N85O77T\SQLEXPRESS ; Initial Catalog = Library2; Integrated Security = True;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        
        public Student()
        {
            InitializeComponent();
            showdata_Student();

        }

        

        private void report(object sender, EventArgs e)
        {          
            Report report = new Report();
            report.ShowDialog();    
        } 

    public void delete_table_student()
        {
            adapter = new SqlDataAdapter("delete from student", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Reseed()
        {
            adapter = new SqlDataAdapter("DBCC CHECKIDENT ('student', RESEED, 0);", conn);
            dt = new DataTable();
            adapter.Fill(dt);

        }


        private void Insert_student(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into student values(" +

                "'"+FnameTextBox.Text+"'," +
                "'"+LnameTextBox.Text+"'," +
                "'"+EmailTextBox.Text+ "'," +
                "'"+MobileTextBox.Text+"'," +
                "'"+BdateTextBox.Text+"'," +
                "'"+FacultyTextBox.Text+"'," +
                "'"+AgeTextBox.Text+"')", conn

                );
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data was saved in database");
            conn.Close();
            showdata_Student();
        }
        private void Join(object sender, EventArgs e)
        {
            conn.Open();
            showdata_join();
            MessageBox.Show("Two tables joined");
            conn.Close();

        }


        public void showdata_Student()
        {
            adapter = new SqlDataAdapter("select * from student",conn); 
            dt=new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;  
        }


        public void showdata_join()
        {
            adapter = new SqlDataAdapter("select  student.stud_fname,student.stud_lname,book.BOOK_TITLE \r\nfrom student, borrow,BOOK\r\nwhere student.stud__id = borrow.stud__id \r\nand book.BOOK_ID=BORROW.BOOK_ID", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       

        private void Update(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE student SET stud_faculty = '" + NewFacultyTextBox.Text + "' where stud__id = '" + UpdateTextBox.Text + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Table updated successfully");
            conn.Close();
            showdata_Student();
        }

        private void Delete(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from student where STUD__ID = '" + IDTextBox.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data deleted from database");
            conn.Close();
            showdata_Student();
        }

        private void Show(object sender, EventArgs e)
        {
            conn.Open();
            showdata_Student();
            conn.Close();

        }

        private void DeleteAll(object sender, EventArgs e)
        {
            conn.Open();
            delete_table_student();
            MessageBox.Show("All table data deleted");
            Reseed();
            showdata_Student();
            conn.Close();
        }

        private void toBook(object sender, EventArgs e)
        {
            Book book = new Book();
            book.ShowDialog();
        }
    }
}

