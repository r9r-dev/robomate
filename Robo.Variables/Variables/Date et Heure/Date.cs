using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Variables.Variables.Date_et_Heure
{
    public class Date : ISystemVariable
    {
        public string Category
        {
            get { return "Date et heure"; }
        }

        public string UniqueName
        {
            get { return "Date"; }
        }

        public string Description
        {
            get { return "Date actuelle"; }
        }

        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public string Default
        {
            get { return "{Date}"; }
        }
    }
}
