﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerservice;

        public SellersController(SellerService sellerservice)
        {
            _sellerservice = sellerservice;
        }

        public IActionResult Index()
        {
            var lista = _sellerservice.FindAll();
            return View(lista);
        }
    }
}