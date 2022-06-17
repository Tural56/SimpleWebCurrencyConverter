using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyAppTestV.Models
{
    public class EURModel
    {
        public decimal priceAZE { get; set; }
        
        public decimal priceEUR { get; set; }
        public decimal EUR { get; set; }

        public decimal ConvertedToEUR { get; set; }

        public decimal ConvertedToAZE { get; set; }
        public void convertToEUR(decimal priceAZE)
        {
            this.priceAZE = priceAZE;
            ConvertedToEUR = Math.Round(priceAZE / EUR, 2);

        }

        public void convertToAZE(decimal priceEUR)
        {
            this.priceEUR = priceEUR;
            ConvertedToAZE = Math.Round(priceEUR * EUR, 2);

        }
    }
}
