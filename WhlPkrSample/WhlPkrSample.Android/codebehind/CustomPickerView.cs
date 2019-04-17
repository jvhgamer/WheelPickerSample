using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using WhlPkrSample.PickerView;

namespace WhlPkrSample.PickerView
{
    public class CustomPickerView : ContentView
    {
        public Xamarin.Forms.ScrollView scrollView = new Xamarin.Forms.ScrollView {
            Orientation = ScrollOrientation.Horizontal
        };

        public StackLayout grid = new StackLayout {
            Orientation = StackOrientation.Horizontal,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            BindingContext = new CustomPickerViewModel()
        };

        #region Properties
        #region FontSize

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(nameof(FontSize), typeof(double), typeof(CustomPickerView), -1.0,
            defaultValueCreator: bindable => Device.GetNamedSize(NamedSize.Default, (CustomPickerView)bindable),
            propertyChanged: OnFontSizeChanged);

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        private static void OnFontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var view = (CustomPickerView)bindable;
            var vm = view.grid.BindingContext as CustomPickerViewModel;
            vm.FontSize = (double)(newvalue ?? Device.GetNamedSize(NamedSize.Default, (CustomPickerView)bindable));
        }

        #endregion

        #region ColumnWidth

        public static readonly BindableProperty ColumnWidthProperty = BindableProperty.Create(nameof(ColumnWidth), typeof(double), typeof(CustomPickerView), 17d,
            propertyChanged: OnColumnWidthChanged);

        public double ColumnWidth
        {
            get { return (double)GetValue(ColumnWidthProperty); }
            set { SetValue(ColumnWidthProperty, value); }
        }

        private static void OnColumnWidthChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (newvalue == null)
            {
                return;
            }

            var view = (CustomPickerView)bindable;
            var vm = view.grid.BindingContext as CustomPickerViewModel;
            vm.ColumnWidth = (double)newvalue;
        }

        #endregion
        #endregion

        public PickerView pickerGender = new WhlPkrSample.PickerView.PickerView();
        public PickerView pickerType = new WhlPkrSample.PickerView.PickerView();
        public PickerView pickerNames = new WhlPkrSample.PickerView.PickerView();
        public PickerView pickerLens = new WhlPkrSample.PickerView.PickerView();

        public CustomPickerView()
        {
            CustomPickerViewModel.listGender = new List<object> {
                "M",
                "F"
            };

            CustomPickerViewModel.listType = new List<object> {
                "Driver",
                "7 Iron"
            };

            CustomPickerViewModel.listNames = new List<object> {
                "ROGUE DRIVER", "ROGUE SZ DRIVER", "ROGUE FAIRWAY SZ DRIVER"
            };

            CustomPickerViewModel.listLens = new List<object> {
                "-2\"",
                "-1 1/2\"",
                "-1\"",
                "-1/2\"",
                "Std",
                "+1/2\"",
                "+1\"",
                "+1 1/2\"",
                "+2\""
            };

            // Bindings
            //pickerGender.SetBinding(WidthRequestProperty, "ColumnWidth");
            //pickerGender.SetBinding(PickerView.FontSizeProperty, "FontSize");
            //pickerGender.SetBinding(PickerView.ItemsSourceProperty, "listGender");
            pickerGender.WidthRequest = 30;
            pickerGender.FontSize = 24;
            pickerGender.ItemsSource = CustomPickerViewModel.listGender;
            pickerGender.SelectedIndex = 0;

            pickerType.SetBinding(WidthRequestProperty, "ColumnWidth");
            pickerType.SetBinding(PickerView.FontSizeProperty, "FontSize");
            pickerType.SetBinding(PickerView.ItemsSourceProperty, "listType");
            pickerType.SelectedIndex = 0;

            pickerNames.SetBinding(WidthRequestProperty, "ColumnWidth");
            pickerNames.SetBinding(PickerView.FontSizeProperty, "FontSize");
            pickerNames.SetBinding(PickerView.ItemsSourceProperty, "listNames");
            pickerNames.SelectedIndex = 0;

            pickerLens.SetBinding(WidthRequestProperty, "ColumnWidth");
            pickerLens.SetBinding(PickerView.FontSizeProperty, "FontSize");
            pickerLens.SetBinding(PickerView.ItemsSourceProperty, "listGender");
            pickerLens.SelectedIndex = 4;

            // Layout
            grid.Children.Add(pickerGender);
            grid.Children.Add(pickerType);
            grid.Children.Add(pickerNames);
            grid.Children.Add(pickerLens);

            // Content
            scrollView.Content = grid;

            // ?
            var vm = grid.BindingContext as CustomPickerViewModel;
            vm.PropertyChanged += ViewModel_OnPropertyChanged;

            // View ViewModel
            vm.ColumnWidth = ColumnWidth;
        }

        private void ViewModel_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var vm = sender as CustomPickerViewModel;
            if (e.PropertyName == "")
            {
            }
        }
    }
}