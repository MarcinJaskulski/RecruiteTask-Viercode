using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherForecast.classes;

namespace WeatherForecast.Tests
{
  [TestClass]
  public class WeatherForecastTests
  {
    [TestMethod]
    public void CanaricTest()
    {
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void ShouldAttachStatistics()
    {
      WeatherData wd = new WeatherData();

      Statistics s = new Statistics(wd);

      Assert.IsTrue(wd.Observers.Count == 1 && wd.Observers[0] == s);
    }


    [TestMethod]
    public void ShouldNotifyForecast()
    {
      WeatherData wd = new WeatherData();
      Forecast f = new Forecast(wd);

      TemperatureInformation ti = new TemperatureInformation() { Today = 20, Tomorrow = 21, TheDayAfterTomorrow = 22 };
      wd.SetData(ti);
      wd.Notify();

      Assert.IsTrue(f.ForecastForNextDays == String.Format("Temperature for Today: {0}*C Tomorrow: {1}*C and The Day After Tomorrow {2}*C",
        ti.Today,
        ti.Tomorrow,
        ti.TheDayAfterTomorrow));
    }
  }
}
