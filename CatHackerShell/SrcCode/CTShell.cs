using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatHackerShell
{
    public partial class CTShell : Form
    {
        public CTShell()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private void CTShell_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
