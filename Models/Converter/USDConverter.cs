using CurrencyAppTestV.Models.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyAppTestV.Models.Converter
{
    public class USDConverter
    {
        public USDModel reconstruct(decimal given_number, string radio_info)
        {
            USDModel currency = new USDModel();
            UsdParser parser = new UsdParser();

            if (radio_info == "USDtoAZE")
            {
                currency = parser.Parse();
                currency.convertToAZE(given_number);
            }

            if (radio_info == "AZEtoUSD")
            {
                currency = parser.Parse();
                currency.convertToEUR(given_number);
            }




            return currency;
        }

        public USDModel construct()
        {
            USDModel currency = new USDModel();
            UsdParser parser = new UsdParser();

            currency = parser.Parse();

            return currency;
        }
    }
}
