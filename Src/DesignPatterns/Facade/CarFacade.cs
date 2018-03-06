using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class CarFacade
    {
        private IEngine engine;
        private IWheels wheels;
        private IIndicators indicators;

        public void StartCar()
        {
            wheels.ApplyBrakes();
            engine.StartEngine();
        }

        public void Drive()
        {
            indicators.RightTurnOn();
            engine.Accelerate();
            indicators.RightTurnOff();
        }

    }
}
