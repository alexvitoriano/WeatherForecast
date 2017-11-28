using System;
using System.Globalization;
using Xamarin.Forms;

namespace WeatherForecast.Converters
{
    public class IconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var iconType = value.ToString();

            switch (iconType)
            {
                case "01n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/moon.png";
                    else
                        return "moon.png";
                case "01d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/sun.png";
                    else
                        return "sun.png";
                case "02n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/fewclouds.png";
                    else
                        return "fewclouds.png";
                case "02d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/fewclouds.png";
                    else
                        return "fewclouds.png";
                case "04d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/brokenclouds.png";
                    else
                        return "brokenclouds.png";
                case "04n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/brokenclouds.png";
                    else
                        return "brokenclouds.png";
                case "09d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/shower.png";
                    else
                        return "shower.png";
                case "09n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/shower.png";
                    else
                        return "shower.png";
                case "10d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/rain.png";
                    else
                        return "rain.png";
                case "10n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/rain.png";
                    else
                        return "rain.png";
                case "11d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/storm.png";
                    else
                        return "storm.png";
                case "11n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/storm.png";
                    else
                        return "storm.png";
                case "13d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/snow.png";
                    else
                        return "snow.png";
                case "13n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/snow.png";
                    else
                        return "snow.png";
                case "50d":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/mist.png";
                    else
                        return "mist.png";
                case "50n":
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/mist.png";
                    else
                        return "mist.png";
                default:
                    if (Device.RuntimePlatform == Device.UWP)
                        return "Assets/norain.png";
                    else
                        return "norain.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
