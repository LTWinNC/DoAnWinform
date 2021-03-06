﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace ApplicationWinform
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

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new FrmMain());
            //Application.Run(new QLHocVien());
            //Application.Run(new QLGiaoVien());
            //Application.Run(new QLKetQua());
            //Application.Run(new QLLopHoc());
            //Application.Run(new QLLichHoc());
            //Application.Run(new QLKhoaHoc());
        }
    }
}
