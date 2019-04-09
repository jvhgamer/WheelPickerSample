using System.Collections.Generic;
using Xamarin.Forms;
using Vapolia.WheelPickerForms;

#if __IOS__
using UIKit;
using Foundation;
using Vapolia.WheelPickerIos;
using Vapolia.WheelPickerCore;
using Xamarin.Forms.Platform.iOS;
#elif __ANDROID__
using Vapolia.WheelPickerCore;
using Vapolia.WheelPickerForms.Droid;
using Android.App;
#endif

namespace WhlPkrSample
{
    public class MainPage : ContentPage
    {
        #region Variables
        public List<IList<object>> wheelPickerItems;
        public List<object> listDigits, listFooBar, listVowels, listQwerty = new List<object>();

        public View wheelPickerView;
        public bool imgViewable = true;
        Button btnClickMe;
        Label lblWelcome;
        Image imgPreview;

#if __IOS__
        public UIPickerView wheelPicker = new UIPickerView
        { ShowSelectionIndicator = true, BackgroundColor = UIColor.White };
        public WheelPickerModel pickerViewModel;
#elif __ANDROID__
        public WheelPicker pickerViewModel = new Vapolia.WheelPickerForms.WheelPicker();
#endif
        #endregion

        public MainPage()
        {
            #region Initializae
            btnClickMe = new Button
            {
                Text = "Click me to switch!",
                TextColor = Color.Black,
                BackgroundColor = Color.LightGray,
                BorderColor = Color.Black,
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            btnClickMe.Clicked += BtnClickMe_Clicked;

            lblWelcome = new Label
            {
                Text = "Welcome to Xamarin.Forms!",
                TextColor = Color.Black,
                BackgroundColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            imgPreview = new Image
            {
                Source = "preview.png",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Aspect = Aspect.Fill,
            };

            listDigits = new List<object> {
                "0", "1", "2", "3", "4",
                "5", "6", "7", "8", "9"
            };

            listVowels = new List<object> {
                "A", "E", "I", "O", "U",
            };

            listFooBar = new List<object> {
                "Foo", "Bar", "Testing longer data values"
            };

            listQwerty = new List<object> {
                "Q", "W","E", "R", "T", "Y"
            };
            #endregion

            #region Picker
            #region Picker creation
            wheelPickerItems = new List<IList<object>> {
                listDigits, listVowels, listFooBar, listQwerty };
#if __IOS__
            pickerViewModel = new WheelPickerModel(wheelPicker);
            wheelPicker.Model = pickerViewModel;
            pickerViewModel.HorizontalSpaceBetweenWheels = 10f;
            pickerViewModel.ItemsSourceMulti = wheelPickerItems;
            pickerViewModel.SelectedItemsIndex = new IntegerList { 0, 0, 0, 4 };
            pickerViewModel.SelectedItemIndexChanged += Picker_SelectedItemIndexChanged;
            pickerViewModel.ItemAligns = new List<WheelItemAlign> { WheelItemAlign.Left };
            pickerViewModel.ItemFont = UIFont.SystemFontOfSize(12);
            pickerViewModel.ItemWidths = "15 45 * 30";
#elif __ANDROID__
            pickerViewModel.HorizontalSpaceBetweenWheels = 20f;
            pickerViewModel.ItemsSourceMulti = wheelPickerItems;
            pickerViewModel.SelectedItemsIndex = new IntegerList { 0, 0, 0, 4 };
            pickerViewModel.SelectedItemIndexChanged += Picker_SelectedItemIndexChanged;
            pickerViewModel.WheelDefinitions = new List<WheelDefinition> {
                new WheelDefinition {
                    Alignment = WheelItemAlign.Center,
                    Width = new GridLength (15, GridUnitType.Auto),
                    HorizontalOptions = WheelItemAlign.Center,
                    RowHeight = 50,
                },
                new WheelDefinition {
                    Alignment = WheelItemAlign.Center,
                    Width = new GridLength (15, GridUnitType.Auto),
                    HorizontalOptions = WheelItemAlign.Center,
                    RowHeight = 50,
                },
                new WheelDefinition {
                    Alignment = WheelItemAlign.Center,
                    Width = new GridLength (1, GridUnitType.Star),
                    HorizontalOptions = WheelItemAlign.Center,
                    RowHeight = 50,
                },
                new WheelDefinition {
                    Alignment = WheelItemAlign.Center,
                    Width = new GridLength (15, GridUnitType.Auto),
                    HorizontalOptions = WheelItemAlign.Center,
                    RowHeight = 50,
                },
            };
            Font font = new Font{};
            font = font.WithSize(Device.GetNamedSize(NamedSize.Small, typeof(Label)));
            pickerViewModel.ItemTextFont = font;
#endif
            #endregion

#if __IOS__
            wheelPickerView = wheelPicker.ToView();
#elif __ANDROID__
            wheelPickerView = pickerViewModel;
#endif

            wheelPickerView.HorizontalOptions = LayoutOptions.FillAndExpand;
            wheelPickerView.VerticalOptions = LayoutOptions.FillAndExpand;
            wheelPickerView.BackgroundColor = Color.White;

            var gridImgAndPicker = new Grid
            {
                RowDefinitions =
                {
                  new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                  new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                RowSpacing = 0,
                ColumnSpacing = 0,
                Padding = 0
            };

            gridImgAndPicker.Children.Add(wheelPickerView, 0, 0);
            gridImgAndPicker.Children.Add(imgPreview, 0, 0);
            #endregion

            #region Layout
            var gridPage = new Grid
            {
                RowDefinitions =
                {
                  new RowDefinition { Height = new GridLength(.1, GridUnitType.Star) },
                  new RowDefinition { Height = new GridLength(.3, GridUnitType.Star) },
                  new RowDefinition { Height = new GridLength(.6, GridUnitType.Star) },
                },
                Padding = new Thickness(0, 30, 0, 0),
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                RowSpacing = 0,
            };

            gridPage.Children.Add(btnClickMe, 0, 0);
            gridPage.Children.Add(gridImgAndPicker, 0, 1);
            gridPage.Children.Add(lblWelcome, 0, 2);
            #endregion

            #region Hide on start
            Device.BeginInvokeOnMainThread(() =>
            {
#if __IOS__
                wheelPicker.Hidden = true;
#elif __ANDROID__
                pickerViewModel.IsVisible = false;
#endif
                imgPreview.IsVisible = true;
            });
            #endregion

            Content = gridPage;
        }

        #region Events
        private void BtnClickMe_Clicked(object sender, System.EventArgs e)
        {
            bool fBool = false;
            if (imgViewable)
            {
                fBool = true;
                imgViewable = false;
            }
            else
                imgViewable = true;

            Device.BeginInvokeOnMainThread(() =>
            {
                if (!fBool)
                {
#if __IOS__
                    wheelPicker.Hidden = true;
#elif __ANDROID__
                    pickerViewModel.IsVisible = false;
#endif
                    imgPreview.IsVisible = true;
                }
                else
                {
#if __IOS__
                    wheelPicker.Hidden = false;
#elif __ANDROID__
                    pickerViewModel.IsVisible = true;
#endif
                    imgPreview.IsVisible = false;
                }

            });
        }

        private void Picker_SelectedItemIndexChanged(object sender, WheelChangedEventArgs args)
        {
#if __IOS__
            var senderVar = (WheelPickerModel)sender;
#elif __ANDROID__
            var senderVar = (WheelPicker)sender;
#endif
            var text = $"Wheel {args.WheelIndex} selection changed to item index {args.SelectedItemIndex}";

            if (args.WheelIndex == 0)
            {
            }

            if (args.WheelIndex == 1)
            {
            }

            if (args.WheelIndex == 2)
            {
            }

            if (args.WheelIndex == 3)
            {
            }
        }
        #endregion
    }
}