using System;
using System.Windows.Forms;
using QLDoanhThu.HienThi;
using QLDoanhThu.Main;

namespace QLDoanhThu
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
            Application.Run(new frmThongTinShow());
            //Application.Run(new frmMain());

        }
    }
}
