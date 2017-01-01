using AbstractFactoryConcept.Factory;
using AbstractFactoryConcept.InsuranceFactoryItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryConcept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InsuranceAbstractFactory factory = new RenewalFactory();
            FactoryProvider provider = new FactoryProvider(factory);
            provider.IsItRenewal();
            Console.ReadKey();
        }
    }
}
