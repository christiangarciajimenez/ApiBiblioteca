//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjercicioWebApi.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PeliculaBiblioteca
    {
        public long IdPelicula { get; set; }
        public long IdObra { get; set; }
        public Nullable<long> DuracionObra { get; set; }
        public string ProductoraObra { get; set; }
    
        public virtual ObraDeVideoBiblioteca ObraDeVideoBiblioteca { get; set; }
    }
}
