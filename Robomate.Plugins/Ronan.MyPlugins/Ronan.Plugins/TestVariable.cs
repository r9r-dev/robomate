using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Ronan.Plugins
{
    public class TestVariable : ISystemVariable
    {
        public string GetValue(params string[] args)
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public string Category
        {
            get { return "date and time"; }
        }

        public string UniqueName
        {
            get { return "RonanCustomDateTime"; }
        }

        public string Description
        {
            get { return "This is a useless Custom DateTime Plugin"; }
        }

        public string Default
        {
            get { return "{RonanCustomDateTime}"; }
        }
    }
}
