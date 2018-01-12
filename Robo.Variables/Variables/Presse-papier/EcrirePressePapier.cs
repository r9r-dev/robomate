using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Robo.Interface;

namespace Robo.Variables.Variables.Presse_papier
{
    public class EcrirePressePapier : ISystemVariable
    {
        public string Category
        {
            get { return "Presse-papiers"; }
        }

        public string UniqueName
        {
            get { return "EcrirePressePapier"; }
        }

        public string Description
        {
            get { return "Ecrire du texte dans le presse-papiers et retourne une chaine vide (Robomate par défaut)."; }
        }

        public string GetValue(params string[] args)
        {
            if (args.Length != 1) return GetValue(Default);
            
            Clipboard.SetText(args[0]);
			return String.Empty;
        }

        public string Default
        {
            get { return "{EcrirePressePapier(Robomate)}"; }
        }
    }
}
