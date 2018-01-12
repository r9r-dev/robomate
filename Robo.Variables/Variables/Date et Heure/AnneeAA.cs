using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class AnneeAA : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "AnneeAA"; }
        }

        public string Description
        {
            get { return "Année actuelle au format AA"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("yy");
        }

        public string Default
        {
            get { return "{AnneeAA}"; }
        }
    }
}
