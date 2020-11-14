using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Entidades;

namespace ToDo.Controllers
{
    public class TareasController : Controller
    {
        private static List<Tarea> ListaDeTareas = new List<Tarea>();
        public IActionResult Index()
        {
            return View(ListaDeTareas);
        }
    }
}
