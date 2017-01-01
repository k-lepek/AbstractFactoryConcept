using AbstractFactoryConcept.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryConcept.Factory
{
    public abstract class InsuranceAbstractFactory
    {
        //public abstract void CheckInsurance();

        public abstract Insurance MakeInsurance();
        public abstract bool AddOC();

        //public abstract void GetInsurance();
    }
}
