using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Employee.Forms;

namespace AlaMungo.Employee
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            //쓰레드 관련. 메인
            EmployeeMainForm main = new EmployeeMainForm();
            //Application.Run(main);
        }
    }
}
