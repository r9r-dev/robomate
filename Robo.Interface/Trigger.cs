using System;

namespace Robo.Interface
{
    public abstract class Trigger
    {
        public event EventHandler Raise;
        protected virtual void OnRaise(EventArgs e)
        {
            EventHandler handler = Raise;
            if (handler != null) handler(this, e);
        }


    }
}
