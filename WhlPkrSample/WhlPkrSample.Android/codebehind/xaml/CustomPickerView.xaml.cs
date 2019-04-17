using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhlPkrSample.PickerView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomPickerView : ContentView
	{
        public Xamarin.Forms.ScrollView scrollView = new Xamarin.Forms.ScrollView
        {
            Orientation = ScrollOrientation.Horizontal
        };

        public StackLayout grid = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            BindingContext = new CustomPickerViewModel()
        };

        public PickerView pickerDigitOne = new PickerView();
        //public PickerView pickerGender = new WhlPkrSample.PickerView.PickerView();
        //public PickerView pickerType = new WhlPkrSample.PickerView.PickerView();
        //public PickerView pickerNames = new WhlPkrSample.PickerView.PickerView();
        //public PickerView pickerLens = new WhlPkrSample.PickerView.PickerView();

        #region FontSize

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(nameof(FontSize), typeof(double), typeof(CustomPickerView), -1.0,
	        defaultValueCreator: bindable => Device.GetNamedSize(NamedSize.Default, (CustomPickerView)bindable),
	        propertyChanged:OnFontSizeChanged);

	    public double FontSize
	    {
	        get { return (double)GetValue(FontSizeProperty); }
	        set { SetValue(FontSizeProperty, value); }
	    }

	    private static void OnFontSizeChanged(BindableObject bindable, object oldvalue, object newvalue)
	    {
	        var view = (CustomPickerView) bindable;
	        var vm = view.grid.BindingContext as CustomPickerViewModel;
	        vm.FontSize = (double)(newvalue ?? Device.GetNamedSize(NamedSize.Default, (CustomPickerView)bindable));
	    }

	    #endregion

	    #region ColumnWidth

	    public static readonly BindableProperty ColumnWidthProperty = BindableProperty.Create(nameof(ColumnWidth), typeof(double), typeof(CustomPickerView), 17d,
	        propertyChanged:OnColumnWidthChanged);

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

	        var view = (CustomPickerView) bindable;
	        var vm = view.grid.BindingContext as CustomPickerViewModel;
	        vm.ColumnWidth = (double)newvalue;
	    }

	    #endregion

		public CustomPickerView()
		{
			InitializeComponent();

            // Bindings
            pickerDigitOne.SetBinding(WidthRequestProperty, "ColumnWidth");
            pickerDigitOne.SetBinding(PickerView.FontSizeProperty, "FontSize");
            pickerDigitOne.SetBinding(PickerView.ItemsSourceProperty, "Numbers");
            pickerDigitOne.SetBinding(PickerView.SelectedIndexProperty, "IntegerDigit0");

            //pickerGender.SetBinding(WidthRequestProperty, "ColumnWidth");
            //pickerGender.SetBinding(PickerView.FontSizeProperty, "FontSize");
            //pickerGender.SetBinding(PickerView.ItemsSourceProperty, "listGender");
            //pickerType.SelectedIndex = 0;

            //pickerType.SetBinding(WidthRequestProperty, "ColumnWidth");
            //pickerType.SetBinding(PickerView.FontSizeProperty, "FontSize");
            //pickerType.SetBinding(PickerView.ItemsSourceProperty, "listType");
            //pickerType.SelectedIndex = 0;

            //pickerNames.SetBinding(WidthRequestProperty, "ColumnWidth");
            //pickerNames.SetBinding(PickerView.FontSizeProperty, "FontSize");
            //pickerNames.SetBinding(PickerView.ItemsSourceProperty, "listNames");
            //pickerNames.SelectedIndex = 0;

            //pickerLens.SetBinding(WidthRequestProperty, "ColumnWidth");
            //pickerLens.SetBinding(PickerView.FontSizeProperty, "FontSize");
            //pickerLens.SetBinding(PickerView.ItemsSourceProperty, "listGender");
            //pickerLens.SelectedIndex = 4;

            // Layout
            grid.Children.Add(pickerDigitOne);
            //grid.Children.Add(pickerGender);
            //grid.Children.Add(pickerType);
            //grid.Children.Add(pickerNames);
            //grid.Children.Add(pickerLens);

            // Content
            scrollView.Content = grid;

            var vm = grid.BindingContext as CustomPickerViewModel;
		    vm.PropertyChanged += ViewModel_OnPropertyChanged;

			// View の既定値を ViewModel に伝搬
		    vm.ColumnWidth = ColumnWidth;
		}

	    private void ViewModel_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
	    {
			var vm = sender as CustomPickerViewModel;
	        //if (e.PropertyName == "Value")
	        //{
	        //    Value = vm.Value;
	        //}
	    }
	}
}