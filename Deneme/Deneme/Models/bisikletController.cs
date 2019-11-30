using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Models
{
    public class bisikletController : Controller
    {
        public IActionResult Bianchi()
        {
            return View();
        }
    }
}