using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class GasBalloon
    {
        protected double volume;
        protected double mass;
        protected double molar;

        protected const double R = 0.0821;

        public GasBalloon (double volume, double mass, double molar)
        {
            this.volume = volume;
            this.mass = mass;
            this.molar = molar;
        }

        public GasBalloon ():this(10, 10, 10)
        { }

        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }

        public double GetPressure(int T)
        {
            return (mass/molar * R * T) / volume;
        }

        public double AmountOfMatter()
        {
            return mass/molar;
        }

        public override string ToString()
        {
            return string.Format("GasBalloon Data:\n" +
                                 "-volume: {0}\n" +
                                 "-mass: {1}\n" +
                                 "-molar: {2}\n",
                                 volume, mass, molar);
        }

    }
}
