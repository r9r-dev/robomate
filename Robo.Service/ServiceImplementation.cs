using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.Timers;
using OFid.Logs;
using Robo.Service.Properties;


namespace Robo.Service
{
	/// <summary>
	/// Inscrire l'implémentation actuelle du service ici...
	/// </summary>
	[WindowsService("Robo_Engine",
		DisplayName = "Robomate Engine",
		Description = "Service d'exécution des tâches Robomate.",
		EventLogSource = "Robomate_Service",
		StartMode = ServiceStartMode.Automatic,
		CanPauseAndContinue = false)]
	public class ServiceImplementation : IWindowsService
	{

		private Timer _settingsMonitor; // Intervalle de vérification des paramètres
		private Timer _monitor; // Intervalle de lancement de la tâche du service
		private bool _running = false;


		private string _nomCourt = "Robomate"; // Nom court du service


		/// <summary>
		/// Le service lance une tâche toutes les x secondes (CheckIntervalSeconds)
		/// Supprimer le timer _monitor et modifier la méthode OnStart si vous souhaitez faire un service avec un listener asynchrone
		/// </summary>
		public ServiceImplementation()
		{
			Log.GenerateDefaultConfigFile();
			Log.Debug("ServiceImplementation()");
			Settings.Default.Reload();
			// Initialisation du service

			_settingsMonitor = new Timer(5000);
			_settingsMonitor.Elapsed += SettingsMonitorTick;

			_monitor = new Timer(Settings.Default.CheckIntervalSeconds * 1000);
			_monitor.Elapsed += TacheService;

		}

		/// <summary>
		/// Ceci est la tâche effectuée par le service à chaque Tick de l'objet _monitor
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TacheService(object sender, EventArgs e)
		{
			if (_running) return;
			_running = true;
			try
			{

			}
			catch (Exception ex)
			{
				Log.Error("Exception levée dans TacheService() : " + ex.Message);
			}
			finally
			{
				_running = false;
			}
		}


		/// <summary>
		/// Taches de l'application relatant de la libération des ressources
		/// </summary>
		/// <filterpriority>2</filterpriority>
		public void Dispose()
		{

		}

		/// <summary>
		/// Méthode appelée lorsqu'une demande de démarrage du service est requise.
		/// </summary>
		/// <param name="args">Arguments de démarrage du service</param>
		public void OnStart(string[] args)
		{
			Log.Warn(_nomCourt + " v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version + ". Démarrage du service.");
			Log.Info("Intervalle de vérification : " + Settings.Default.CheckIntervalSeconds + " secondes.");
			try
			{
				Settings.Default.Reload();
				_settingsMonitor.Enabled = true;
				_settingsMonitor.Start();
				_monitor.Enabled = true;
				_monitor.Start();
			}
			catch (Exception ex)
			{
				Log.Fatal("Exception levée dans OnStart() : Impossible de démarrer le service : " + ex.Message + "\n\nStackTrace :\n" + ex.StackTrace);
			}
		}

		/// <summary>
		/// Méthode lancée lorsqu'une demande d'arrêt du service est requise.
		/// </summary>
		public void OnStop()
		{
			Log.Warn("Arrêt du service.");
			_monitor.Stop();
		}

		/// <summary>
		/// Méthode lancée lorsqu'une demande de pause du service est requise,
		/// mais pas arrêté totalement.
		/// </summary>
		public void OnPause()
		{

		}

		/// <summary>
		/// Méthode lancée lorsqu'une demande de reprise du service est requise,
		/// après une demande de pause.
		/// </summary>
		public void OnContinue()
		{

		}

		/// <summary>
		/// Méthode lancée lorsque l'ordinateur est entrain de s'arrêter.
		/// </summary>
		public void OnShutdown()
		{
			_monitor.Stop();
			Dispose();
		}

		/// <summary>
		/// Méthode lancée lorsqu'une commande personnalisée est envoyée au service
		/// </summary>
		/// <param name="command">L'identifiant de la commande à exécuter.</param >
		public void OnCustomCommand(int command)
		{

		}

		/// <summary>
		/// Vérification des paramètres du service
		/// Ici, vous pouvez ajouter des vérifications de présence de dossiers par exemple.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SettingsMonitorTick(object sender, ElapsedEventArgs e)
		{
			Settings.Default.Reload();
			int intervale = (int)_monitor.Interval;
			int nouvelleIntervale = Settings.Default.CheckIntervalSeconds * 1000;
			if (intervale - nouvelleIntervale != 0)
			{
				_monitor.Interval = nouvelleIntervale;
				Log.Info("Nouvelle intervalle de vérification : " + Settings.Default.CheckIntervalSeconds + " secondes.");
			}

		}


	}
}
