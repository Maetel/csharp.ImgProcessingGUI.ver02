using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.AccessControl;
using System.Security.Principal;
using System.IO;

namespace WindowsFormsApp1
{
    static class Program
    {
        public const string mainTitle = "Image Converter";
        public const string curVersion = "ver0.21";    //180502-1
        //const string curVersion = "ver0.2";    //180501~2

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        

    }

    
}
