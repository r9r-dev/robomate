using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gettext;
using MetroFramework.Forms;

namespace Robo.Mate
{
    public partial class Compagnon : Form
    {
        public Compagnon()
        {
           InitializeComponent();
        }

        private void Compagnon_Shown(object sender, EventArgs e)
        {
           toolTip1.Show(Strings.T("Hello ! My name is Mate. I am your compagnon helper for Robomate."), label1);
        }

        
    }

   

    
}
