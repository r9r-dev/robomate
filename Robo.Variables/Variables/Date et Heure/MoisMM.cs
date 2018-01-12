using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class MoisMM : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "MoisMM"; }
        }

        public string Description
        {
            get { return "Mois au format MM"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("MM");
        }

        public string Default
        {
            get { return "{MoisMM}"; }
        }
    }
}
