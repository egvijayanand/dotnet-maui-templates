#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VijayAnand.MauiTemplates
{
    public class ObservableObject : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler? PropertyChanging;
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Sets the property and raises the notification.
        /// </summary>
        /// <typeparam name="T">Type parameter of the field &amp; property.</typeparam>
        /// <param name="backingField">Backing field.</param>
        /// <param name="value">Value.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="onChanging">Code that runs before changing the property value.</param>
        /// <param name="onChanged">Code that runs after changing the property value.</param>
        /// <param name="validateValue">Code that validates the value.</param>
        /// <returns><c>true</c>, if property was set, <c>false</c> otherwise.</returns>
        protected virtual bool SetProperty<T>(ref T backingField,
                                              T value,
                                              [CallerMemberName] string? propertyName = null,
                                              Action? onChanging = null,
                                              Action? onChanged = null,
                                              Func<T, T, bool>? validateValue = null)
        {
            // If value didn't change
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return false;
            }

            // If value changed but didn't validate
            if (validateValue != null && !validateValue(backingField, value))
            {
                return false;
            }

            onChanging?.Invoke();
            OnPropertyChanging(propertyName);
            backingField = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        protected virtual void OnPropertyChanging([CallerMemberName] string? propertyName = null)
            => PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
