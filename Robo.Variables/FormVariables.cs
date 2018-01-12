using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Robo.Interface;

namespace Robo.Variables
{
    public partial class FormVariables : MetroForm
    {
        public ISystemVariable ChosenVariable;
        
        public FormVariables()
        {
            InitializeComponent();
            lbVariable.Text = String.Empty;
        }

        private void FormVariables_Load(object sender, EventArgs e)
        {
            var systemVariables = SystemVariables.GetThem;

            var categories = (from src in systemVariables
                            select src.Category).Distinct();

            lbCategories.Items.Add("[Toutes]");

            foreach (var categorie in categories)
            {
                lbCategories.Items.Add(categorie);
            }
            
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSysteme.Rows.Clear();

            var variables = (from src in SystemVariables.GetThem
                             select src).ToList();

            if (lbCategories.SelectedItem.ToString() != "[Toutes]")
            {
                variables = (from src in variables
                             where src.Category == lbCategories.SelectedItem.ToString()
                             select src).ToList();
            }
           
            foreach (var variable in variables)
            {
                dgvSysteme.Rows.Add(variable.UniqueName, variable.Description);
            }
        }

        private void dgvSysteme_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSysteme.CurrentRow == null) return;


            var variable = SystemVariables.Variable(dgvSysteme.CurrentRow.Cells[0].Value.ToString());
            
            try
            {
                lbVariable.Text = variable.Default + " = " + SystemVariables.ReplaceVariables(variable.Default);
            }
            catch(Exception ex)
            {
                lbVariable.Text = variable.Default + " = "+ex.Message;
            }
            

            ChosenVariable = variable;
        }
    }
}
