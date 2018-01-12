using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Robo.Interface;
using Robo.Tools;
using Robo.Variables.Variables.Presse_papier;

namespace Robo.Variables
{
    public static class SystemVariables
    {
        private static List<ISystemVariable> _variables; // Catégorie, nom, description

        public static IEnumerable<ISystemVariable> GetThem
        {
            get
            {
                LoadVariables();
                return _variables;
            }
        }

        public static string ReplaceVariables(string sentence)
        {
           string newSentence = Regex.Replace(sentence, "{[^{}]*}", m => GetValue(m.Value), RegexOptions.None);
           if (Regex.IsMatch(newSentence, "{[^{}]*}"))
           {
               return ReplaceVariables(newSentence);
           }
           return newSentence;
        }


        public static string GetValue(string variable)
        {
            LoadVariables();
            // décomposition de la variable (ne contient pas de {)
            string sansAccolades = variable.Replace("{", String.Empty).Replace("}", String.Empty);

            if (sansAccolades.Contains("("))
            {
                var decompose = sansAccolades.Replace(")", "").Split('(');
                var nom = decompose[0];
                var args = decompose[1];
                return Variable(nom).GetValue(args.Split(','));
            }
            return Variable(sansAccolades).GetValue();
        }

        public static ISystemVariable Variable(string uniqueName)
        {
            LoadVariables();
            
            var variable = (from src in _variables
                            where src.UniqueName == uniqueName
                            select src).Single();
            return variable;
        }


        public static void ReLoadVariables()
        {
            _variables = null;
            LoadVariables();
        }

        // Chargement des variables
        private static void LoadVariables()
        {
            if (_variables != null) return;

            _variables = new List<ISystemVariable>();

            // Par réflexion, on récupère les variables de type ISystemVariable.
            var type = typeof(ISystemVariable);
            var types = AppDomain.CurrentDomain.GetAssemblies().ToList()
                .SelectMany(s => s.GetTypes())
                .Where(type.IsAssignableFrom)
                .Where(s => !s.IsInterface).ToList();

            // On ajoute chaque variable au dictionnaire
            foreach (var t in types)
            {
                var variable = (ISystemVariable)Activator.CreateInstance(t);
                _variables.Add(variable);
            }

           



        }


    }
}
