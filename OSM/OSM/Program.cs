using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OSM
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormOSM_Login());
            FormOSM_Login Log = new FormOSM_Login();
            Log.ShowDialog();
            
            if (Log.DialogResult == DialogResult.OK)
            {
                string id = Log.id;
                string userid = Log.userid;
                string username = Log.username;

                Application.Run(new FormOSM_Main(id, userid, username));
            }
        }
    }
}
