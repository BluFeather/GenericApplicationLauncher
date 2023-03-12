using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GenericApplicationLauncher.View
{
    public class RelayCommand : ICommand
    {
        Action _command;
        Func<bool> _canExecute;

        public RelayCommand(Action command) : this(command, DefaultCanExecute) { }

        public RelayCommand(Action command, Func<bool> canExecute)
        {
            _command = command;
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object? parameter) => _canExecute();

        public void Execute(object? parameter) => _command.Invoke();

        private static bool DefaultCanExecute() => true;
    }
}
