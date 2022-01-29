using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendientes.Negocios
{
    public class ListaDePendientes
    {
        public List<Tarea> Lista { get; private set; }
        /// <summary>
        /// Agregar una tarea a la lista de pendientes
        /// </summary>
        /// <param name="pendiente">Descripcion de la tarea</param>
        /// <exception cref="ArgumentException"></exception>
        public void Agregar(string pendiente)
        {
            if (Lista == null)
            {
                Lista = new List<Tarea>();
            }
            if (Lista.Any(t => t.Descripcion.ToUpper() == pendiente.ToUpper()))
            {
                throw new ArgumentException("Tarea duplicada");
            }
            try
            {
                Tarea tarea = new Tarea() { Descripcion = pendiente, Realizada = false };
                Lista.Add(tarea);
            }
            catch
            {
                throw;
            }
        }
    }
}
