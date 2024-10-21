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
    public partial class Book : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-N85O77T\SQLEXPRESS ; Initial Catalog = Library2; Integrated Security = True;");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Book()
        {
            InitializeComponent();
            showdata_Book();
            //delete_table_employee();
        }



        public void showdata_Book()
        {
            adapter = new SqlDataAdapter("select * from Book", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void Reseed()
        {
            adapter = new SqlDataAdapter("DBCC CHECKIDENT ('Book', RESEED, 0);", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            
        }

        private void Insert_Book(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("insert into Book values( " +
                "'" + AuthorTextBox.Text + "'," +
                "'" + PubTextBox.Text + "'," +
                "'" + TitleTextBox.Text + "'," +
                "'" + PriceTextBox.Text + "'," +
                "'" + GenreList.Text + "'," +
                "'" + EditionTextBox.Text + "'," +
                "'" + LangList.Text + "'," +
                "'" + CopiesTextBox.Text + "'," +
                "'" + YearTextBox.Text + "')",
                 conn
                );

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data was saved in database");
            conn.Close();
            showdata_Book();
        }

        private void Delete(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from Book where BOOK_ID = '"+IDTextBox.Text + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tuple was deleted from the table");
            conn.Close();
            showdata_Book();
        }

        private void Update(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("UPDATE Book SET Author_id = '"+updateAuthor.Text + "' , pub_name = '"+updatePublisher.Text + "' , BOOK_TITLE = '" + updateTitle.Text + "' , book_price = '"+updatePrice.Text + "' , book_genre = '"+updateEdition.Text + "' , book_edition = '"+updateEdition.Text + "', book_language = '"+updateLang.Text + "' , book_copiesnum = '"+updateCopies.Text + "' ,  published_year = '"+updateYear.Text + "'  where  BOOK_ID = '" + UpdateTextBox.Text + "' ", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tuple updated successfully!");
            conn.Close();
            showdata_Book();
        }

        private void DeleteAll(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("delete from Book", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Table deleted successfully :)");
            Reseed();
            showdata_Book();
            conn.Close();
            
        }

        private void Show(object sender, EventArgs e)
        {
            conn.Open();
            showdata_Book();
            conn.Close();
        }

        private void selected(object sender, EventArgs e)
        {

        }

        private void toStudent(object sender, EventArgs e)
        {
            Student book = new Student();
            book.ShowDialog();
        }
    }
}
