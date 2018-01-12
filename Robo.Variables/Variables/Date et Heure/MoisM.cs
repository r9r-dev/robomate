using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class MoisM : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "MoisM"; }
        }

        public string Description
        {
            get { return "Mois au format M"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("M");
        }

        public string Default
        {
            get { return "{MoisM}"; }
        }
    }
}
