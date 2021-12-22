using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoteriaMexicanaRandom.Models;

namespace LoteriaMexicanaRandom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Carton()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(string cantidad = "500")
        {
            try
            {
                Random _random = new Random();
                List<int> listNumbers = new List<int>();
                List<Tuple<string,string>> listReturn = new List<Tuple<string,string>>();
                Int64 l_cantidad = 0;
                Int32 l_number = 0;
                string codigo = String.Empty;

                if (!Int64.TryParse(cantidad, out l_cantidad))
                    return BadRequest();

                for (Int64 x = 0; x < l_cantidad; x++)
                {
                    codigo = string.Empty;
                    listNumbers.Clear();
                    for (Int16 y = 0; y < 16; y++)
                    {
                        do
                        {
                            l_number = _random.Next(1, 55);
                        } while (listNumbers.Contains(l_number));
                        listNumbers.Add(l_number);
                        codigo += l_number.ToString("00");
                    }
                    listReturn.Add(new Tuple<string,string>(codigo,codigo));
                }

                return Json(new { data = listReturn.AsEnumerable() });
            }
            catch (Exception ex)
            { throw new NotImplementedException(); }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
