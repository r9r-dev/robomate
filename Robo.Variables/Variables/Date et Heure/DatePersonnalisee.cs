using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class DatePersonnalisee : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "DatePersonnalisée"; }
        }

        public string Description
        {
            get { return "Date actuelle personnalisée (format de la date)"; }
        }

        public string GetValue(params string[] args)
        {
            if (args.Length != 1) return Default;

            return DateTime.Now.ToString(args[0]);
        }

        public string Default
        {
            get { return "{DatePersonnalisée(dd MM yyyy)}"; }
        }
    }
}
