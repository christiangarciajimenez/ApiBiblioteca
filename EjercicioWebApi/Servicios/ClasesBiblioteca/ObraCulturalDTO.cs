using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ClasesBiblioteca
{
   public abstract class ObraCulturalDTO
    {
        public string titulo { get; set; }

        public int anyo { get; set; }

        public string genero { get; set; }



        public static int contador { get; set; }


       public int codigoobra { get; set; }
        
        public bool alquilado { get; set; }

        public bool editado { get; set; }


        public ObraCulturalDTO()
        {
            contador++;
            codigoobra = contador;
            titulo = "";
            anyo = 0;
            genero = "";
            alquilado = false;
            editado = false;
        }

        public ObraCulturalDTO(string tituloexterno,int anyoexterno,string generoexterno)
        {
            titulo = tituloexterno;
            anyo = anyoexterno;
            genero = generoexterno;
        }

        public abstract void mostrarInformacion();
        public void editarInformacion()
        {
            Console.Write("Desea editar el título (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba un título: ");
                titulo = Console.ReadLine();
               

                editado = true;
            }


            Console.Write("Desea editar el año (s/n): ");
            string editar2 = Console.ReadLine();
            if (editar2.ToLower() == "s")
            {
                Console.Write("Escriba un año: ");
                anyo = int.Parse(Console.ReadLine());
                
                editado = true;

            }


            Console.Write("Desea editar el género (s/n): ");
            string editar3 = Console.ReadLine();
            if (editar3.ToLower() == "s")
            {
                Console.Write("Escriba un género: ");
                genero = Console.ReadLine();
           
                editado = true;
            }

              

        }

        public void pedirInformacion()
        {
          
                Console.Write("Escriba un título: ");
                titulo = Console.ReadLine();
         
             


         
                Console.Write("Escriba un año: ");
                anyo = int.Parse(Console.ReadLine());
          
            

         
                Console.Write("Escriba un género: ");
                genero = Console.ReadLine();
            


        }





    }
}
