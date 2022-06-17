using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyAppTestV.Models
{
    public class USDModel
    {
        public decimal priceAZE { get; set; }

        public decimal priceUSD { get; set; }
        public decimal USD { get; set; }

        public decimal ConvertedToAZE { get; set; }
        public decimal ConvertedToUSD { get; set; }
        public void convertToEUR(decimal priceAZE)
        {
            this.priceAZE = priceAZE;
            ConvertedToUSD = Math.Round(priceAZE / USD, 2);

        }

        public void convertToAZE(decimal priceUSD)
        {
            this.priceUSD = priceUSD;
            ConvertedToAZE = Math.Round(priceUSD * USD, 2);

        }
    }
}
