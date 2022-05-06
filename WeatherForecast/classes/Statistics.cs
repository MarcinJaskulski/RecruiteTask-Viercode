using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.classes;
using WeatherForecast.Interfaces;

namespace WeatherForecast
{
    public class Statistics : ScreenElement
    {
        public decimal TemperatureStatistics;

        public Statistics()
        {
        }

        public Statistics(Subject subject) : base(subject)
        {
        }

        public override void Update()
        {
            UpdateStatistics();
        }

        void UpdateStatistics()
        {
            WeatherData wd = this.Subject as WeatherData;
            this.TemperatureStatistics = (wd.TemperatureInformation.Today + wd.TemperatureInformation.Tomorrow + wd.TemperatureInformation.TheDayAfterTomorrow) / 3;
        }

    }
}
