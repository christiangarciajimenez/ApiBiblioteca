using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ClasesBiblioteca
{
    public class ObraDeVideoDTO : ObraCulturalDTO
    {
        public string director { get; set; }

        public string reparto { get; set; }

        public ObraDeVideoDTO():base()
        {
            director = "";
            reparto = "";
        }

        public ObraDeVideoDTO(string directorexterno,string repartoexterno):base()
        {
            director = directorexterno;
            reparto = repartoexterno;
        }
        public override void mostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo} ");
            Console.WriteLine($"Año: {anyo} ");
            Console.WriteLine($"Género: {genero} ");
            Console.WriteLine($"Código: {codigoobra}");
            Console.WriteLine($"Alquilado: {alquilado}");
            Console.WriteLine($"Director: {director} ");
            Console.WriteLine($"Reparto: {reparto} ");
        }

        public void editarInformacionObraVideo()
        {
            base.editarInformacion();
            Console.Write("Desea editar el director (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba un director: ");
                director = Console.ReadLine();
                editado = true;
            }

            Console.Write("Desea editar el reparto (s/n): ");
            string editar2 = Console.ReadLine();
            if (editar2.ToLower() == "s")
            {
                Console.Write("Escriba el reparto: ");
                reparto = Console.ReadLine();
                editado = true;
            }
        }

        public void pedirInformacionObraVideo()
        {
            base.pedirInformacion();        
                Console.Write("Escriba un director: ");
                director = Console.ReadLine();
            
          
                Console.Write("Escriba el reparto: ");
                reparto = Console.ReadLine();
             
        }
    }
}
