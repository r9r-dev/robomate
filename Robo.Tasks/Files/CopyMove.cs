using System;
using System.Collections.Generic;
using Robo.Interface;

namespace Robo.Tasks.Files
{
    public class CopyMove : Task
    {
        private bool _deleteSource;
        private List<string> _filesToCopy = new List<string>();

        public CopyMove()
        {
            ConfigurationInterface = new FormCopyMove();
            UniqueName = "CopyMove";
            Category = "Fichiers";
            Description = "Copier ou déplacer des fichiers.";
        }


        public override void Run()
        {
            
        }

        public override void Load()
        {
            
        }

        public override void Save()
        {
            
        }
    }
}
