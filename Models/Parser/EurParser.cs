using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CurrencyAppTestV.Models.Parser
{
    public class EurParser
    {


        public EURModel Parse()
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy");

            
            //Compy Central Bank XMl File
            XDocument xml = XDocument.Load($"https://www.cbar.az/currencies/" + date + ".xml");

            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

            EURModel currencyConverter = new EURModel();
            //EUR parsing
            XElement EURValtype = (XElement)xml.Elements("ValCurs").Elements("ValType").FirstOrDefault(x => x.Attribute("Type").Value == "Xarici valyutalar");
            XElement EURValue = EURValtype.Elements("Valute").FirstOrDefault(a => a.Attribute("Code").Value == "EUR");
            currencyConverter.EUR = Math.Round(decimal.Parse(EURValue.Element("Value").Value, formatter), 2);

            return currencyConverter;
        }
    }
}
