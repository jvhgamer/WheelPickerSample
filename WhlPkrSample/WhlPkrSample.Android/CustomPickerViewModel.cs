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

        private int[] _numbers;
        public int[] Numbers {
            get { return _numbers; }
            set
            {
                _numbers = value;
                OnPropertyChanged();
            }
        }

        private int _integerDigit0;
        public int IntegerDigit0
        {
            get { return _integerDigit0; }
            set
            {
                _integerDigit0 = value;
                OnPropertyChanged();
            }
        }

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

        readonly IList<Action<int>> _intSetters = new List<Action<int>>();
        readonly IList<Func<int>> _intGetters = new List<Func<int>>();

        public CustomPickerViewModel()
        {
            Numbers = new int[] {0,1,2,3,4,5,6,7,8,9};

            _intSetters.Add(digitValue => IntegerDigit0 = digitValue);

            _intGetters.Add(() => IntegerDigit0);

            FontSize = -1;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Debug.WriteLine($"OnPropertyChanged:{propertyName}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            //if (propertyName == "Value")
            //{
            //}
        }


    }
}