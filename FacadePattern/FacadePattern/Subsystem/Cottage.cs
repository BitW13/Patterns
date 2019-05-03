﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Subsystem
{
    internal class Cottage: Property
    {
        internal Cottage(double insuranceTerm, double livingSpace, int numberOfResidents, int constructionYear, double buildingWear)
        {
            this.insuranceTerm = insuranceTerm;
            this.livingSpace = livingSpace;
            this.numberOfResidents = numberOfResidents;
            this.constructionYear = constructionYear;
            this.buildingWear = buildingWear;
        }

        internal Cottage() : this(1, 30, 3, 2019, 0.13)
        { }

        internal string ToString()
        {
            return string.Format("Cottage Data:\n" +
                                 "insurance term: {0}\n" +
                                 "living space: {1}\n" +
                                 "number of residents: {2}\n" +
                                 "construction year: {3}\n" +
                                 "building wear: {4}\n", insuranceTerm, livingSpace, numberOfResidents, constructionYear, buildingWear);
        }
    }
}
