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

        public IActionResult CargarTareaForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CargarTarea(Tarea nuevaTarea)
        {
            if (ModelState.IsValid)
            {
                ListaDeTareas.Add(nuevaTarea);
                return View("Index", ListaDeTareas);
            } 
            else
            {
                string mensaje = "Error al crear la tarea";
                return Content(mensaje);
            }
            
            
        }

        public IActionResult RealizarTarea(int id)
        {
            ListaDeTareas.Find(t => t.Id == id).Realizar();
            return View("Index", ListaDeTareas);
        }

        public IActionResult BorrarTarea(int id)
        {
            ListaDeTareas.RemoveAll(t => t.Id == id);
            return View("Index", ListaDeTareas);
        }

        public IActionResult ModificarTareaForm(int id)
        {
            Tarea laTarea = ListaDeTareas.Find(t => t.Id == id);
            return View(laTarea);
        }

        [HttpPost]
        public IActionResult ModificarTarea(int id, string Descripcion, int Duracion) 
        {
            Tarea laTarea = ListaDeTareas.Find(t => t.Id == id);
            laTarea.Descripcion = Descripcion;
            laTarea.Duracion = Duracion;
            return RedirectToAction("Index", "Tareas");
        }
    }
}
