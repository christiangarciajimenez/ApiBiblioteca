using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ClasesBiblioteca
{
  public  class ObraLiterariaDTO : ObraCulturalDTO
    {
        public string autor { get; set; }




        public ObraLiterariaDTO():base()
        {
            autor = "";
            
        }

        public ObraLiterariaDTO(string autorexterno):base()
        {
            autor = autorexterno;
            
        }

        public override void mostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo} ");
            Console.WriteLine($"Año: {anyo} ");
            Console.WriteLine($"Género: {genero} ");
            Console.WriteLine($"Código: {codigoobra}");
            Console.WriteLine($"Alquilado: {alquilado}");
            Console.WriteLine($"Autor: {autor} ") ;

        }

        public void editarInformacionObraLiteraria()
        {
            base.editarInformacion();
            Console.Write("Desea editar el autor (s/n): ");
            string editar = Console.ReadLine();
            if (editar.ToLower() == "s")
            {
                Console.Write("Escriba un autor: ");
                autor = Console.ReadLine();
               
                editado = true;
            }
        }


        public void pedirInformacionObraLiteraria()
        {
            base.pedirInformacion();          
             Console.Write("Escriba un autor: ");
             autor = Console.ReadLine();
                
            
        }



    }
}
