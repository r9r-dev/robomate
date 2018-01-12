using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class AnneeAAAA : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "AnneeAAAA"; }
        }

        public string Description
        {
            get { return "Année actuelle au format AAAA"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("yyyy");
        }

        public string Default
        {
            get { return "{AnneeAAAA}"; }
        }
    }
}
