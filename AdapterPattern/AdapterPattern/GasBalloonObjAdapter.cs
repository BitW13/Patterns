using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class GasBalloonObjAdapter : ITarget
    {
        private readonly GasBalloon gasBalloon;

        public GasBalloonObjAdapter()
        {
            gasBalloon = new GasBalloon();
        }

        public GasBalloonObjAdapter(double volume, double mass, double molar)
        {
            gasBalloon = new GasBalloon(volume, mass, molar);
        }
        public double CalculateDp(int T0, int dT)
        {
            return gasBalloon.GetPressure(dT + T0) - gasBalloon.GetPressure(T0);
        }

        public string GetData()
        {
            return gasBalloon.ToString();
        }

        public void ModifMass(double dm)
        {
            gasBalloon.Mass += dm;
        }
    }
}
