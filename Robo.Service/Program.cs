using System;
using System.Linq;
using System.ServiceProcess;


namespace Robo.Service
{
	static class Program
	{
		// Point d'entrée principal de l'application
		static void Main(string[] args)
		{
			try
			{
				// si la commande était -i (installer), installation du service au niveau runtime
				if (args.Contains("-i", StringComparer.InvariantCultureIgnoreCase))
				{
					WindowsServiceInstaller.RuntimeInstall<ServiceImplementation>();
				}

					// si la commande était -u (désinstaller), désinstallation du service au niveau runtime
				else if (args.Contains("-u", StringComparer.InvariantCultureIgnoreCase))
				{
					WindowsServiceInstaller.RuntimeUnInstall<ServiceImplementation>();
				}

					// Sinon, on lance le service en mode console (program interactif lancé en console ou par l'explorateur) ou en mode service (autres cas)
				else
				{
					var implementation = new ServiceImplementation();

					// lancé depuis la console ou l'explorateur windows, on lance dans une console...
					if (Environment.UserInteractive)
					{
						ConsoleHarness.Run(args, implementation);
					}
					else // Sinon, on lance en mode service
					{
						ServiceBase.Run(new WindowsServiceHarness(implementation));
					}
				}
			}

			catch (Exception ex)
			{
				ConsoleHarness.WriteToConsole(ConsoleColor.Red, "Exception levée dans Main(): {0}", ex);
			}
		}
	}
}
