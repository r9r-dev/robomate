using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class AlignerAGauche : ISystemVariable
    {
        public string Category
        {
            get { return "Chaînes"; }
        }

        public string UniqueName
        {
            get { return "AlignerAGauche"; }
        }

        public string Description
        {
            get { return "Aligne la chaîne à gauche en ajoutant le caractère spécifié (chaine,longueur,caractère)."; }
        }
		
		public string GetValue(params string[] args)
        {
            if (args.Length != 3) return GetValue(Default);

            string chaine = args[0];
			int longueur = Convert.ToInt32(args[1]);
			char car = Convert.ToChar(args[2]);
			
			return chaine.PadLeft(longueur, car);
        }

        public string Default
        {
            get { return "{AlignerAGauche({JourJ},3,0)}"; }
        }
    }
}
