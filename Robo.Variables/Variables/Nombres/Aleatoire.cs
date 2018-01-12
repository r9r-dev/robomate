using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Nombres
{
    public class Aleatoire : ISystemVariable
    {
        public string Category
        {
            get { return "Nombres"; }
        }

        public string UniqueName
        {
            get { return "Aleatoire"; }
        }

        public string Description
        {
            get { return "Génère un nombre aléatoire entre X et Y (1 et 1000 par défaut)."; }
        }

        public string GetValue(params string[] args)
        {
            if (args.Length != 2) return GetValue(Default);

            var rnd = new Random();
            rnd.Next(); // j'ai pas confiance en ce Random :)
            return rnd.Next(Convert.ToInt32(args[0]), Convert.ToInt32(args[1])).ToString(CultureInfo.InvariantCulture);
        }

        public string Default
        {
            get { return "{Aleatoire(1,1000)}"; }
        }
    }
}
