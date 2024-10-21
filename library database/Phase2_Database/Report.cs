using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase2_Database
{
    public partial class Report : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-N85O77T\SQLEXPRESS ; Initial Catalog = Library2; Integrated Security = True;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Report()
        {
            InitializeComponent();


        }
        

       

        

        public void showdata_Latefee()
        {
            adapter = new SqlDataAdapter("select distinct stud_fname,stud_lname,late_fee from student,borrow where student.stud__id = borrow.stud__id and borrow.late_fee != 0", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void Show_report(object sender, EventArgs e)
        {
            conn.Open();
            showdata_Latefee();
            string query = "SELECT SUM(book.BOOK_PRICE) AS total_revenue\r\nFROM book\r\nJOIN borrow ON borrow.book_id = book.BOOK_ID;";

            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-N85O77T\SQLEXPRESS ; Initial Catalog = Library; Integrated Security = True;"))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    int total = (int)command.ExecuteScalar();

                    textBox3.Text = total.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            string query2 = "SELECT top 1 BOOK_TITLE\r\nFROM book \r\nJOIN borrow  ON book.BOOK_ID = BORROW.BOOK_ID\r\nGROUP BY book.BOOK_ID, book.BOOK_TITLE\r\nORDER BY COUNT(BORROW.BOOK_ID) DESC;";

            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-N85O77T\SQLEXPRESS ; Initial Catalog = Library; Integrated Security = True;"))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query2, connection);

                    string mostborrowed = (string)command.ExecuteScalar();

                    textBox2.Text = mostborrowed;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            string query3 = "SELECT  COUNT(distinct book_id) FROM borrow"; 


            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-N85O77T\SQLEXPRESS ; Initial Catalog = Library; Integrated Security = True;"))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query3, connection);

                    int numberOfBorrowedBooks = (int)command.ExecuteScalar();

                    textBox1.Text = numberOfBorrowedBooks.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }


            conn.Close();
        }

        
    }
}
