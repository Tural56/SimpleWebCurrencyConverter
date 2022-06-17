using CurrencyAppTestV.Models.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyAppTestV.Models.Converter
{
    public class EURConverter
    {
        public EURModel reconstruct(decimal given_number, string radio_info)
        {
            EURModel currency = new EURModel();
            EurParser parser = new EurParser();

            if (radio_info == "EURtoAZE")
            {
                currency = parser.Parse();
                currency.convertToAZE(given_number);
            }

            if (radio_info == "AZEtoEUR")
            {
                currency = parser.Parse();
                currency.convertToEUR(given_number);
            }
            



            return currency;
        }

        public EURModel construct()
        {
            EURModel currency = new EURModel();
            EurParser parser = new EurParser();

            currency = parser.Parse();

            return currency;
        }
    }
}
