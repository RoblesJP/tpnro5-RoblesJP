using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    public class TareasController : Controller
    {
        public IActionResult Index()
        {
            List<Tarea> ListaDeTareas = new List<Tarea>();
            Tarea t1 = new Tarea("Tarea 1", 10);
            Tarea t2 = new Tarea("Tarea 2", 7);
            Tarea t3 = new Tarea("Tarea 3", 18);
            ListaDeTareas.Add(t1);
            ListaDeTareas.Add(t2);
            ListaDeTareas.Add(t3);
            return View(ListaDeTareas);
        }
    }
}
