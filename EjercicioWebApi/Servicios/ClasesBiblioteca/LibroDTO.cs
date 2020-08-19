using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ClasesBiblioteca
{
   public class LibroDTO:ObraLiterariaDTO
    {
        public int paginas { get; set; }




        public LibroDTO():base()
        {
            paginas = 0;
        }

        public LibroDTO(int paginasexterna):base()
        {
            paginas = paginasexterna;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine($"Número de Páginas: {paginas}");
        }

        public void editarInformacionLibro()
        {
            base.editarInformacionObraLiteraria();
            Console.Write("Desea editar el número de páginas (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba el número de páginas del libro: ");
                paginas = int.Parse(Console.ReadLine());
                
               
       
                
                    editado = true;
            }




            
        }

    /*    public void editarInformacionLibroBD(LibroBiblioteca libro)
        {
            Console.Write("Desea editar el número de páginas (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba el número de páginas del libro: ");
                paginas = int.Parse(Console.ReadLine());
                libro.PaginasObra = paginas;



                editado = true;
            }
        }*/


        public void pedirInformacionLibro()
        {
            base.pedirInformacionObraLiteraria();                          
            Console.Write("Escriba el número de páginas del libro: ");
            paginas = int.Parse(Console.ReadLine());
            





        }





    }
}
