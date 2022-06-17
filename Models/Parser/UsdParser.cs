using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CurrencyAppTestV.Models.Parser
{
    public class UsdParser
    {

        
        public USDModel Parse()
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy");


            //Compy Central Bank XMl File
            XDocument xml = XDocument.Load($"https://www.cbar.az/currencies/" + date + ".xml");

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

            USDModel currencyConverter = new USDModel();
            //USD parsing
            XElement USDValtype = (XElement)xml.Elements("ValCurs").Elements("ValType").FirstOrDefault(x => x.Attribute("Type").Value == "Xarici valyutalar");
            XElement USDValue = USDValtype.Elements("Valute").FirstOrDefault(a => a.Attribute("Code").Value == "USD");
            currencyConverter.USD = decimal.Parse(USDValue.Element("Value").Value, formatter);

            return currencyConverter;
        }
    }
}
