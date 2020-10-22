using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Venezia.Data;

namespace Venezia.Controllers
{
    public class UserIdentityController : Controller
    {

        private readonly VeneziaContext _context;
        public UserIdentityController(VeneziaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("adminOnly", Name = "AdminFiedl")]
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
