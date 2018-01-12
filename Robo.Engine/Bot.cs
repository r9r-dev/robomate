using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robo.Interface;

namespace Robo.Engine
{
    public class Bot
    {
        public string Name; // nom publique
        public string InternalName; // nom sans espaces utilisé pour un appel par une autre tache
        public LogLevel LogLevel; // niveau de log de la tache

        public ActionAfter ActionAfter; // Action à effectuer à la fin de la tache
        public bool ContinueOnError; // Continuer la tâche si erreur;
        public Bot BotOnError; // Tâche à lancer après une erreur;

        // Status
        public bool Enabled; // tache active
        
        public bool Started; // tache démarrée

        // Eléments du bot
        public List<Trigger> Triggers; // évènements de lancement
        public List<Task> Actions; // actions chainées dans une Queue
        public Dictionary<string, string> Variables; // variables internes du bot

        public string Comments; // Commentaires utilisateur



        public Bot(string name)
        {
            Name = name;
            InternalName = "Bot" + ""; // TODO : Incrémenter les tâches Task1, Task2, etc.
            LogLevel = LogLevel.Event;
            ActionAfter = ActionAfter.Nothing;
            ContinueOnError = false;
            Enabled = false;
            Started = false;
            Triggers = new List<Trigger>();
            Actions = new List<Task>();
            Variables = new Dictionary<string, string>();
        }

        public void Enable()
        {
            // Lancement de tous les Triggers

        }

        public void Start()
        {
            // Lancement de la liste
			Started = true;
        }

    }
}
