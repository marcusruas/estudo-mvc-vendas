using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerservice;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerservice, DepartmentService departmentService)
        {
            _sellerservice = sellerservice;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var lista = _sellerservice.FindAll();
            return View(lista);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerservice.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}