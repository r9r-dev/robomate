using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Hosting;
using System.Security.Policy;
using System.Text;
using Robo.Interface;
using Robo.Tools;

namespace Robo.Tasks
{
    public static class RoboTasks
    {
        private static List<Task> _tasks;

        public static List<Task> GetThem
        {
            get 
            { 
                LoadTasks();
                return _tasks;
            }
        }

        // Chargement des variables
        private static void LoadTasks()
        {
            if (_tasks != null) return;

            _tasks = new List<Task>();

            // Par réflexion, on récupère les variables de type ISystemVariable.
            var type = typeof(Task);
            var types = AppDomain.CurrentDomain.GetAssemblies().ToList()
                .SelectMany(s => s.GetTypes())
                .Where(type.IsAssignableFrom)
                .Where(s => !s.IsAbstract).ToList();

            // On ajoute chaque variable au dictionnaire
            foreach (var t in types)
            {
                var tache = (Task)Activator.CreateInstance(t);
                _tasks.Add(tache);
            }
        }
    }
}
