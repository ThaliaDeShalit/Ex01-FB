using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace A16_Ex01_Nadav_200336436_Thalia_302228002
{
    public class Program
    {
        [STAThread] 
        public static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainAppWindow());
        }
    }
}
