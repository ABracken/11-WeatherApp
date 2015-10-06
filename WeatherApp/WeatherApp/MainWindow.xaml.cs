using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApp.Classes;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxSearch.Text.Length == 0)
            {
                return;
            }
            WeatherResult wr = WeatherService.GetWeather(textBoxSearch.Text);
            if (wr != null)
            {
                labelCityNameZip.Content = wr.cityState + " " + wr.zipCode;

                labelCityLatLong.Content = "Latitude/Longitude: "
                    + wr.latitude + "/" + wr.longitude;

                labelWeatherCondition.Content = wr.weather;

                labelElevation.Content = "Elevation: " + wr.elevation;

                labelLastUpdated.Content = wr.lastUpdated;

                labelTemperature.Content = "Temperature: " + wr.temperature;

                labelFeelsLike.Content = "Feels Like: " + wr.feelsLike;

                labelWind.Content = "Wind: " + wr.wind;

                labelWindDirection.Content = "Wind Direction: " + wr.windDirection;

                labelHumidity.Content = "Humidity: " + wr.humidity;

                labelVisibility.Content = "Visibility: " +  wr.visibility;

                labelUV.Content = "UV: " + wr.uv;

                labelPrecipitation.Content = "Precipitation: " + wr.precipitation;
            }
        

        }
    }
}
