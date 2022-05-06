using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.Interfaces;

namespace WeatherForecast.classes
{
  public abstract class ScreenElement : Observer
  {
    public Subject Subject;

    public ScreenElement() { }
    public ScreenElement(Subject subject)
    {
      this.Subject = subject;
      subject.Attach(this);
    }

    public abstract void Update();
  }
}
