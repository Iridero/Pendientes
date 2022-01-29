using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendientes.Negocios
{
    public class Tarea
    {
        private string descripcion;

        /// <summary>
        /// Obtiene o establece la descripción de la tarea
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public string Descripcion
        {
            get { return descripcion; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La descripción está vacía.");
                }
                descripcion = value; }
        }
        /// <summary>
        /// Obtiene o establece Realizada. true si ya se realizó.
        /// </summary>
        public bool Realizada { get; set; }

        public override string ToString()
        {
            return descripcion + ((Realizada) ? " ✓" : "");
        }
    }
}
