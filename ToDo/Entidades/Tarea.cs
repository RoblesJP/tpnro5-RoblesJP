using System;
using System.Collections.Generic;
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
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public EstadoTarea Estado { get => estado; set => estado = value; }



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
