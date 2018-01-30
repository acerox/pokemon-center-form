﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_center
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
            Application.Run(new LoginForm(
                new Database(
                    new MySql.Data.MySqlClient.MySqlConnection(
                        "Server = 172.16.0.20; Database = pokemon_center; Uid = root; Pwd =root; Port = 3306"
                    ))));
        }
    }
}
