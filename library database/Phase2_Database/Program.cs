using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase2_Database
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Book());

             /*Student newform = new Student();
             newform.Show();
             Book book = new Book();
             book.Show();
             Application.Run();*/

            //Application.Run(new Report());



        }
    }
}
