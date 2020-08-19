using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ClasesBiblioteca
{
 public   class PeliculaDTO:ObraDeVideoDTO
    {
        public int duracion { get; set; }

        public string productora { get;set; }

     

        public PeliculaDTO():base()
        {
            duracion = 0;
            productora = "";
        }

        public PeliculaDTO(int duracionexterno,string productoraexterno):base()
        {
            duracion = duracionexterno;
            productora = productoraexterno;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine($"Duración: {duracion} ");
            Console.WriteLine($"Productora: {productora} ");
        }

        public void editarInformacionPelicula()
        {
            base.editarInformacionObraVideo();
            Console.Write("Desea editar la duración (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba la duración de la película: ");
                duracion = int.Parse(Console.ReadLine());
                editado = true;
            }

            Console.Write("Desea editar la productora (s/n): ");
            string editar2 = Console.ReadLine();
            if (editar2.ToLower() == "s")
            {
                Console.Write("Escriba la productora: ");
                productora = Console.ReadLine();
                editado = true;
            }
        }

        public void pedirInformacionPelicula()
        {
            base.pedirInformacionObraVideo();
          
                Console.Write("Escriba la duración de la película: ");
                duracion = int.Parse(Console.ReadLine());
             

          
         
                Console.Write("Escriba la productora: ");
                productora = Console.ReadLine();
              
            
        }
    }
}
