using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.classes;
using WeatherForecast.Interfaces;

namespace WeatherForecast
{
    public class Forecast : ScreenElement
    {
        public string ForecastForNextDays;

        public Forecast()
        {
        }

        public Forecast(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            UpdateForecastNews();
        }

        void UpdateForecastNews()
        {
            WeatherData wd = this.Subject as WeatherData;

            this.ForecastForNextDays = String.Format("Temperature for Today: {0}*C Tomorrow: {1}*C and The Day After Tomorrow {2}*C",
              wd.TemperatureInformation.Today,
              wd.TemperatureInformation.Tomorrow,
              wd.TemperatureInformation.TheDayAfterTomorrow);
        }
    }
}
