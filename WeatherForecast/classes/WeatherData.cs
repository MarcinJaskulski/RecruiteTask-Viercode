using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.classes;
using WeatherForecast.Interfaces;

namespace WeatherForecast
{
    public class WeatherData : Subject
    {
        public IList<Observer> Observers;

        public TemperatureInformation TemperatureInformation;

        public WeatherData()
        {
            this.Observers = new List<Observer>();
        }

        public void Attach(Observer o)
        {
            Observers.Add(o);
        }

        public void Detach(Observer o)
        {
            Observers.Remove(o);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
                observer.Update();
        }

        public void SetData(TemperatureInformation ti)
        {
            this.TemperatureInformation = ti;
            Notify();
        }

    }


}
