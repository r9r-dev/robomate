using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Robo.UI;
using Robo.Variables;
using MetroFramework;

namespace Robo.Tasks.Files
{
    public partial class FormCopyMove : MetroForm

{
    private TextBox _focusedTextBox = null;

    public FormCopyMove()
    {
        InitializeComponent();

        foreach (var textBox in this.Controls.OfType<TextBox>())
        {
            textBox.GotFocus += textBox_Focus;
        }
    }

    private void textBox_Focus(object sender, EventArgs e)
    {
        _focusedTextBox = (TextBox) sender;
    }

    private void btAddFile_Click(object sender, EventArgs e)
    {
        var diagResult = openFileDialog.ShowDialog();
        if (diagResult == DialogResult.OK)
        {
            tbFichiers.AppendText(openFileDialog.FileName + "\n");
        }
    }

    private void btAddFolder_Click(object sender, EventArgs e)
    {
        var dr = folderBrowserDialog.ShowDialog();
        if (dr == DialogResult.OK)
        {
            tbFichiers.AppendText(folderBrowserDialog.SelectedPath + @"\*" + "\n");
        }
    }

    private void btClearList_Click(object sender, EventArgs e)
    {
        tbFichiers.Clear();
    }

    private void btBrowse_Click(object sender, EventArgs e)
    {
        var dr = folderBrowserDialog.ShowDialog();
        if (dr == DialogResult.OK)
        {
            tbDestination.Text = folderBrowserDialog.SelectedPath + @"\{nomFichier}";
        }
    }

    private void btCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void btVariables_Click(object sender, EventArgs e)
    {
        var formVariables = new FormVariables();
        DialogResult dr = formVariables.ShowDialog();

        if (dr == DialogResult.OK)
        {
            _focusedTextBox.Paste("{" + formVariables.ChosenVariable.UniqueName + "}");
        }
    }

    private void btOK_Click(object sender, EventArgs e)
    {
        RoboBox rb = new RoboBox();
        rb.ShowDialog();

    }


}
}
