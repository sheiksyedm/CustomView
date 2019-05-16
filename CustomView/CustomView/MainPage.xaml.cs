using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomView
{
    public partial class MainPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            customView.IsVisible = !customView.IsVisible;
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class CustomView : View
    {
        public static readonly BindableProperty IsDrawBackgroundProperty =
             BindableProperty.Create("IsDrawBackground", typeof(bool), typeof(CustomView), null, BindingMode.Default, null, null);
        public bool IsDrawBackground
        {
            get { return (bool)GetValue(IsDrawBackgroundProperty); }
            set { SetValue(IsDrawBackgroundProperty, value); }
        }

    }
}
