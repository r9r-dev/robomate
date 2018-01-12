using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class JourJ : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "JourJ"; }
        }

        public string Description
        {
            get { return "Jour au format J"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.Day.ToString(CultureInfo.InvariantCulture);
        }

        public string Default
        {
            get { return "{JourJ}"; }
        }
    }
}
