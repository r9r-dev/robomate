using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Robo.Interface;

namespace Robo.Variables.Variables.Presse_papier
{
    public class LirePressePapier : ISystemVariable
    {
        public string Category
        {
            get { return "Presse-papiers"; }
        }

        public string UniqueName
        {
            get { return "LirePressePapier"; }
        }

        public string Description
        {
            get { return "Contenu du presse-papiers sous forme de texte."; }
        }

        public string GetValue(params string[] args)
        {
            return Clipboard.GetText();
        }

        public string Default
        {
            get { return "{LirePressePapier}"; }
        }
    }
}
