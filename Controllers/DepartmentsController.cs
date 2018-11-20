using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index(){
            List<Department> departamentos = new List<Department>();
            departamentos.Add(new Department {Id = 1, Name = "Eletronicos"});
            departamentos.Add(new Department {Id = 2, Name = "Fashion"});

            return View(departamentos);
        }
    }
}