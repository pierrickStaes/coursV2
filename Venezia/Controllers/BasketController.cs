using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Venezia.Models;
using Venezia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Venezia.Controllers
{
    public class BasketController : Controller
    {

        private readonly VeneziaContext _context;
        public BasketController(VeneziaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("mon-panier", Name = "BasketUrl")]
        public async Task<IActionResult> Index()
        {
            var vm = new BasketViewModel();
            if (this.HttpContext.Session.GetString("BASKET") == null)
            {
                return View();
            }
            else
            {
                Basket basket = JsonConvert.DeserializeObject<Basket>(this.HttpContext.Session.GetString("BASKET"));
                foreach(var item in basket.Cars)
                {
                    var car = await _context.Car.SingleOrDefaultAsync(x => x.ID == item.Key);
                    vm.Cars.Add(car, item.Value);
                    vm.Total += car.Price.GetValueOrDefault() * item.Value;
                   
                }
                return View(vm);
            }
        }

        [HttpPost]
        public IActionResult AddCarToBasket(int idCar)
        {
            Basket basket; 
            if(this.HttpContext.Session.GetString("BASKET") == null)
            {
                basket = new Basket();
            }
            else
            {
                basket = JsonConvert.DeserializeObject<Basket>(this.HttpContext.Session.GetString("BASKET"));
            }
            basket.AddCar(idCar);
            var json = basket.ToJson();
            this.HttpContext.Session.SetString("BASKET", json);
            return Ok(json);
        }
    }
}
