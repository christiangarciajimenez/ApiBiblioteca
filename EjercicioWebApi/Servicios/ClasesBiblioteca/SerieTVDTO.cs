using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ClasesBiblioteca
{
 public   class SerieTVDTO:ObraDeVideoDTO
    {
        public int temporadas { get; set; }

        public int capitulos { get; set; }

        public string Canal { get; set; }


     

        public SerieTVDTO():base()
        {
            temporadas = 0;
            capitulos = 0;
            Canal = "";
        }

        public SerieTVDTO(int temporadasexterno,int capitulosexterno,string canalexterno):base()
        {
            temporadas = temporadasexterno;
            capitulos = capitulosexterno;
            Canal = canalexterno;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine($"Número de Temporadas: {temporadas}");
            Console.WriteLine($"Número de capítulos: {capitulos}");
            Console.WriteLine($"Canal:  {Canal} ");
        }

        public void editarInformacionSerie()
        {
            base.editarInformacionObraVideo();

            Console.Write("Desea editar el número de temporadas (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba el número de temporadas de la serie: ");
                temporadas = int.Parse(Console.ReadLine());
                editado = true;

            }

            Console.Write("Desea editar el número de capítulos (s/n): ");
            string editar2 = Console.ReadLine();
            if (editar2.ToLower() == "s")
            {
                Console.Write("Escriba el número de capítulos: ");
                capitulos = int.Parse(Console.ReadLine());
                editado = true;
            }

            Console.Write("Desea editar el canal (s/n): ");
            string editar3 = Console.ReadLine();
            if (editar3.ToLower() == "s")
            {
                Console.Write("Escriba el canal: ");
                Canal = Console.ReadLine();
                editado = true;
            }
        }

        public void pedirInformacionSerie()
        {
            base.pedirInformacionObraVideo();

           
                Console.Write("Escriba el número de temporadas de la serie: ");
                temporadas = int.Parse(Console.ReadLine());
               

           
                Console.Write("Escriba el número de capítulos: ");
                capitulos = int.Parse(Console.ReadLine());
             

          
           
                Console.Write("Escriba el canal: ");
                Canal = Console.ReadLine();
           
        }
    }
}
