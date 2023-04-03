using System;
using System.Windows.Input;

namespace NinjaWorld_Encyclopedia.Infastructure.Commands.Base
{
    /* Создание базового абстрактного класса интерфейса ICommand */

    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter);


        public abstract void Execute(object parameter);

    }
}
