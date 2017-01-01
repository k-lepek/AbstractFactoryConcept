using AbstractFactoryConcept.Factory;
using AbstractFactoryConcept.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryConcept
{
    public class FactoryProvider
    {
        private Insurance Ins;
        public FactoryProvider(InsuranceAbstractFactory factory)
        {
            Ins = factory.MakeInsurance();
            Ins.OC = factory.AddOC();
        }

        public void IsItRenewal()
        {
            Console.WriteLine($"{Ins.IsRenewal}");
        }

    }
}
