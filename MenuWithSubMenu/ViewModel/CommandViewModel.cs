using System;
using System.Windows.Input;

namespace MenuWithSubMenu.ViewModel
{
    public class CommandViewModel : ICommand
    {
        private readonly Action _action;
         
        public CommandViewModel(Action action)
        {
            this._action = action;
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _action();
        }
    }
}