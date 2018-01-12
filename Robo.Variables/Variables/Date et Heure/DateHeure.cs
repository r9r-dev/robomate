using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class DateHeure : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "DateHeure"; }
        }

        public string Description
        {
            get { return "Date et heure actuelles"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public string Default
        {
            get { return "{DateHeure}"; }
        }
    }
}
