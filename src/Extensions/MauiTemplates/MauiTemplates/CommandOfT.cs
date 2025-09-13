#nullable enable
using System;
using System.Windows.Input;

namespace VijayAnand.MauiTemplates
{
    public class Command<T>(Action<T> execute, Func<T, bool>? canExecute = null) : ICommand
    {
        private readonly Action<T> execute = execute ?? throw new ArgumentNullException(nameof(execute));

        private readonly Func<T, bool>? canExecute = canExecute;

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => parameter is T t && (canExecute?.Invoke(t) ?? true);

        public void Execute(object? parameter)
        {
            if (parameter is T t)
            {
                execute(t);
            }
        }

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
