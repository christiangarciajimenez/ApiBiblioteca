using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ClasesBiblioteca
{
   public class ComicDTO:ObraLiterariaDTO
    {
        public string editora { get; set; }

        public int numerodevolumenes { get; set; }

        public int capitulos { get; set; }

      

        public ComicDTO():base()
        {
            editora = "";
            numerodevolumenes = 0;
            capitulos = 0;
        }

        public ComicDTO(string editoraexterno,int numerodevolumenesexterno,int capitulosexterno):base()
        {
            editora = editoraexterno;
            numerodevolumenes = numerodevolumenesexterno;
            capitulos = capitulosexterno;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine($"Editora: {editora}");
            Console.WriteLine($"Número de Volúmenes: {numerodevolumenes}"); 
            Console.WriteLine($"Número de Capítulos:  {capitulos}");
        }

        public void editarInformacionComic()
        {
            base.editarInformacionObraLiteraria();
            Console.Write("Desea editar la editora (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba una editora: ");
                editora = Console.ReadLine();
                editado = true;
            }

            Console.Write("Desea editar el número de volúmenes (s/n): ");
            string editar2 = Console.ReadLine();
            if (editar2.ToLower() == "s")
            {
                Console.Write("Escriba el número de volúmenes: ");
                numerodevolumenes = int.Parse(Console.ReadLine());
                editado = true;

            }

            Console.Write("Desea editar el número de capítulos (s/n): ");
            string editar3 = Console.ReadLine();
            if (editar3.ToLower() == "s")
            {
                Console.Write("Escriba el número de capítulos del comic: ");
                capitulos = int.Parse(Console.ReadLine());
                editado = true;
            }
          

        }

        public void pedirInformacionComic()
        {
            base.pedirInformacionObraLiteraria();          
             Console.Write("Escriba una editora: ");
             editora = Console.ReadLine();
              

                Console.Write("Escriba el número de volúmenes: ");
                numerodevolumenes = int.Parse(Console.ReadLine());
             

           
                Console.Write("Escriba el número de capítulos del comic: ");
                capitulos = int.Parse(Console.ReadLine());
              

        }



    }
}
