using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Entidades
{
    public enum EstadoTarea
    {
        Pendiente,
        Realizada
    }

    public class Tarea
    {
        private static int nextId = 0;
        private int id;
        private string descripcion;
        private int duracion;
        private EstadoTarea estado;

        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        [Range(1, 100, ErrorMessage = "La duracion debe ser entre 1 y 100")]
        public int Duracion { get => duracion; set => duracion = value; }
        public EstadoTarea Estado { get => estado; set => estado = value; }

        public Tarea() 
        {
            Id = ++nextId;
            Estado = EstadoTarea.Pendiente;
        }

        public Tarea(string descripcion, int duracion)
        {
            Id = ++nextId;
            Descripcion = descripcion;
            Duracion = duracion;
            Estado = EstadoTarea.Pendiente;
        }

        public void Realizar()
        {
            Estado = EstadoTarea.Realizada;
        }
    }
}
