using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class JourJJ : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "JourJJ"; }
        }

        public string Description
        {
            get { return "Jour au format JJ"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("dd");
        }

        public string Default
        {
            get { return "{JourJJ}"; }
        }
    }
}
