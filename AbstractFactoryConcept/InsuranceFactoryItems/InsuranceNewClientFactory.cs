using AbstractFactoryConcept.Factory;
using AbstractFactoryConcept.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryConcept.InsuranceFactoryItems
{
    public class InsuranceNewClientFactory : InsuranceAbstractFactory
    {
        public override bool AddOC()
        {
            return true;
        }

        public override Insurance MakeInsurance()
        {
            return new Insurance(false);
        }
    }
}
