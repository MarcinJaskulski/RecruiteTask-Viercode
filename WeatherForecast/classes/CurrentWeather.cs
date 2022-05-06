using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.classes;
using WeatherForecast.Interfaces;

namespace WeatherForecast
{
    public class CurrentWeather : ScreenElement
    {
        public string CurrentWeatherInformation;

        public CurrentWeather()
        {
        }

        public CurrentWeather(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            UpdateCurrentWeatherInformation();
        }

        void UpdateCurrentWeatherInformation()
        {
            WeatherData wd = this.Subject as WeatherData;
            this.CurrentWeatherInformation = string.Format("It is {0} degrees of celsius right now", wd.TemperatureInformation.Today);
        }
    }
}
