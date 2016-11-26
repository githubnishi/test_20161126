﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test_project
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       

            try
            {
                database.database.Instance.Connect();
                Application.Run(new Form1());
            }
            finally
            {
                database.database.Instance.Disconnect();
            }
        }
    }
}
