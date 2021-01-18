using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;
using System.ComponentModel;


namespace SZB_vizsgamunka1
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());           
        }
    }
    
    
}
