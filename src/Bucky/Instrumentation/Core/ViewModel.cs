using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bucky.Instrumentation.Core;

public class ViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void SetValue<T>(ref T backingField, T value, Action<T>? onChanged = null,
        [CallerMemberName] string? propertyName = null)
    {
        if (Equals(backingField, value)) return;
        var old = backingField;
        backingField = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        onChanged?.Invoke(old);
    }
}