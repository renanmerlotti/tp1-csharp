using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    internal class TemperatureSensor
    {
        public event Action TemperatureExceeded;

        public void ChecarTemperatura(double temperatura)
        {
            if (temperatura > 100)
            {
                TemperatureExceeded();
            }
        }

    }
}
