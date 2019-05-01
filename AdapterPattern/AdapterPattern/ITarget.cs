using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface ITarget
    {
        double CalculateDp(int T0, int dT);
        void ModifMass(double dm);
        string GetData();
    }
}
