using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WhlPkrSample.PickerView
{
    internal class CustomPickerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static List<object> listGender, listType, listNames, listLens = new List<object>();

        private double _fontSize = -1;
        public double FontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                OnPropertyChanged();
            }
        }

        private double _columnWidth = 20;
        public double ColumnWidth
        {
            get { return _columnWidth; }
            set
            {
                _columnWidth = value;
                OnPropertyChanged();
            }
        }

        public CustomPickerViewModel()
        {
        }

        // [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Debug.WriteLine($"OnPropertyChanged:{propertyName}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}