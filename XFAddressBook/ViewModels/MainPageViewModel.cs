using XFAddressBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XFAddressBook.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public IDictionary<string, IList<IContact>> AddressGroupDict { get; } = AddressBook.GroupBook;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
    }
}
