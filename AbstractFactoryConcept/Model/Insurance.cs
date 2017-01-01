using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryConcept.Model
{
    public class Insurance
    {
        public Insurance()
        {

        }
        public Insurance(bool IsRenewal)
        {
            this.IsRenewal = IsRenewal;
        }

        public bool IsRenewal { get; set; }
        public bool OC { get; set; }
        public bool AC { get; set; }
    }
}
