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
        private Action<object> _execute;
        private Func<object, bool> Canexecute;

        public event EventHandler CanExecuteChanged;

        public Command(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            Canexecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return Canexecute == null || Canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
