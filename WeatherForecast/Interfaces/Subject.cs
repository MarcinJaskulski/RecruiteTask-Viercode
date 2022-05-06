using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Interfaces
{
  public interface Subject
  {
    void Attach(Observer o);

    void Detach(Observer o);

    void Notify();
  }
}
