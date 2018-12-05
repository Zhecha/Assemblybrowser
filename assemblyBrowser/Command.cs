using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace assemblyBrowser
{
    public class Command : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canexecute;

        public event EventHandler CanExecuteChanged;

        public Command(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canexecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canexecute == null || this.canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
