using System;
using System.Globalization;
using Xamarin.Forms;

namespace WeatherForecast.Converters
{
    public class BackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            var condition = value.ToString();

            if (condition.Contains("cloud"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/clouds_background.jpg";
                else
                    return "clouds_background.jpg";
            }
            else if (condition.Contains("rain"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/rain_background.jpg";
                else
                    return "rain_background.jpg";
            }
            else if (condition.Contains("storm"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/storm_background.jpg";
                else
                    return "storm_background.jpg";
            }
            else if (condition.Contains("snow"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/snow_background.jpg";
                else
                    return "snow_background.jpg";
            }
            else if (condition.Contains("fog"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/fog.jpg";
                else
                    return "fog.jpg";
            }
            else if (condition.Contains("drizzle"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/drizzle_background.jpg";
                else
                    return "drizzle_background.jpg";
            }
            else if (condition.Contains("mist")|| condition.Contains("haze"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/mist_background.jpg";
                else
                    return "mist_background.jpg";
            }
            else if (condition.Contains("hail") || condition.Contains("sleet"))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/hail_background.jpg";
                else
                    return "hail_background.jpg";
            }
            else if (condition.Contains("sun") || (condition.Contains("clear sky")))
            {
                if (Device.RuntimePlatform == Device.UWP)
                    return "Assets/sun_background.jpg";
                else
                    return "sun_background.jpg";
            }
            else
                return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
