
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherForecast.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherItemTemplate : ContentView
    {
        public WeatherItemTemplate()
        {
            InitializeComponent();
        }
    }
}