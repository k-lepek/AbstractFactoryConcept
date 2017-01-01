using AbstractFactoryConcept.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryConcept.Model;

namespace AbstractFactoryConcept.InsuranceFactoryItems
{
    public class RenewalFactory : InsuranceAbstractFactory
    {
        public override bool AddOC()
        {
            return true;
        }

        public override Insurance MakeInsurance()
        {
            return new Insurance(true);
        }
    }
}
