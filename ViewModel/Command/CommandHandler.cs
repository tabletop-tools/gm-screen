using System;
using System.Windows.Input;

namespace TabletopTools.GMScreen.ViewMOdel.Command
{
    class CommandHandler : ICommand
    {
        private readonly Action action;

        public CommandHandler(Action action)
        {
            this.action = action;
        }

        public void Execute(object parameter)
        {
            action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }

    class CommandHandlerParameter<T> : ICommand
    {
        private readonly Action<T> action;

        public CommandHandlerParameter(Action<T> action)
        {
            this.action = action;
        }

        public void Execute(object parameter)
        {
            action((T)parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}