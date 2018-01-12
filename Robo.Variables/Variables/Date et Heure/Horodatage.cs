using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class Horodatage : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "Horodatage"; }
        }

        public string Description
        {
            get { return "Horodatage à la seconde + X nombre de décimales de seconde (2 par défaut)"; }
        }

        public string GetValue(params string[] args)
        {
            if (args.Length != 1) return SystemVariables.GetValue(Default);

            string dateTimeString = "yyyyMMddHHmmss";
            for (int i = 0; i < Convert.ToInt32(args[0]); i++ )
            {
                dateTimeString += "f";
            }
            return DateTime.Now.ToString(dateTimeString);
        }

        public string Default
        {
            get { return "{Horodatage(2)}"; }
        }
    }
}
