using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Robo.Mate;

namespace Robomate
{
    public partial class MainForm : MetroForm
    {

        private Compagnon _mate;


        public MainForm()
        {
            InitializeComponent();

            _mate = new Compagnon();

            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            var mateLoc = Location;
            mateLoc.X -= 50;
            mateLoc.Y += Size.Height - 100;
            _mate.Location = mateLoc;
//            _mate.Show();
        }
    }
}
