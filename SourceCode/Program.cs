﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Windows.Forms;
using System.Diagnostics;

namespace CatHacker
{
    static class Program
    {
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CatHackerInfectPC()); 
        }
    }
}
