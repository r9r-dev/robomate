using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Robo.Tools
{
    public static class AssemblyLoader
    {

        public static void LoadFromDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                // On va dans le dossier plugins/variables et récupère les fichiers
                var files = Directory.GetFiles(path);

                foreach (var file in files)
                {
                    if (file.ToLower().EndsWith(".dll"))
                    {
                        try
                        {
                            Assembly.LoadFrom(file);
                        }
                        catch (BadImageFormatException)
                        {
                            // Le fichier n'est pas un assembly.
                        }
                        catch (Exception)
                        {
                            
                        }

                    }
                }
            }
        }

    }
}
