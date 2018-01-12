using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Robo.Interface
{
    public abstract class Task
    {
        public string UniqueName;
        public string Category;
        public string Description;

        public Form ConfigurationInterface;

        public abstract void Run();
        public abstract void Load();
        public abstract void Save();
        

        public Dictionary<string, string> Variables; 

        public DialogResult Configure()
        {
            DialogResult dr = ConfigurationInterface.ShowDialog();
            return dr;
        }

        public event EventHandler Progress;
        protected virtual void OnProgress(EventArgs e)
        {
            EventHandler handler = Progress;
            if (handler != null) handler(this, e);
        }

        public event EventHandler Terminated;
        protected virtual void OnTerminated(EventArgs e)
        {
            EventHandler handler = Terminated;
            if (handler != null) handler(this, e);
        }

        public event EventHandler Error;
        protected virtual void OnError(EventArgs e)
        {
            EventHandler handler = Error;
            if (handler != null) handler(this, e);
        }
    }
}
