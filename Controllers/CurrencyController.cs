using CurrencyAppTestV.Models;
using CurrencyAppTestV.Models.Converter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyAppTestV.Controllers
{
    public class CurrencyController : Controller
    {
        // GET: CurrencyController

        public IActionResult USD_View()
        {

            USDConverter currency = new USDConverter();
            USDModel currencybag = currency.construct();
            return View(currencybag);
        }
        [HttpPost]
        public IActionResult USD_View(decimal given_number, string radio_info)
        {


            USDConverter currency = new USDConverter();
            USDModel currencybag = currency.reconstruct(given_number, radio_info);

            return View(currencybag);
        }

        public IActionResult EUR_View()
        {

            EURConverter currency = new EURConverter();
            EURModel currencybag = currency.construct();
            return View(currencybag);
        }
        [HttpPost]
        public IActionResult EUR_View(decimal given_number, string radio_info)
        {
            

            EURConverter currency = new EURConverter();
            EURModel currencybag = currency.reconstruct(given_number, radio_info);

            return View(currencybag);
        }


    }
}
