using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPresentacion
{
    class Libro
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public Persona autor { get; set; }
        public int annoPublicado { get; set; }
        public string resumen { get; set; }

        public Libro() { 
                
        }

        public Libro(int codigo, string nombre, Persona autor, int annoPublicado, string resumen)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.autor = autor;
            this.annoPublicado = annoPublicado;
            this.resumen = resumen;
        }


    }
}
