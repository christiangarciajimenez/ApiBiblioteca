using EjercicioWebApi.Datos;
using Figgle;
using Moq;
using NAudio.Wave;
using Servicios.ClasesBiblioteca;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO.Ports;
using System.Linq;
using System.Runtime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Servicios
{
    public class Biblioteca
    {
     /*   public List<ObraCulturalDTO> listaobras { get; set; }*/

     //   public List<ObraCulturalBiblioteca> listaObrasCulturales { get; set; }
   /*     public bool terminar { get; set; }*/

        public BibliotecaEntities accesoaBDBiblioteca { get; set; }

   /*     public List<ObraCulturalDTO> loc { get; set; }*/

      /*  public List<LibroBiblioteca> lLibrosBD { get; set; }*/

     /*   public List<ComicBiblioteca> lComicsBD { get; set; }

        public List<PeliculaBiblioteca> lPeliculaBD { get; set; }

        public List<SerieTVBiblioteca> lSerieBD { get; set; }*/

       

        /*public string menu()
        {
            Console.WriteLine("----- Menú Principal -------");
            Console.WriteLine();
            Console.WriteLine("1- Gestión de libros");
            Console.WriteLine("2- Gestión de comics");
            Console.WriteLine("3- Gestión de películas");
            Console.WriteLine("4- Gestión de series TV");
            Console.WriteLine("5- Alquilar una obra");
            Console.WriteLine("6- Devolver una obra");
            Console.WriteLine("7- Borrar una obra");
            Console.WriteLine("8- Editar una obra");
            Console.WriteLine("9- Salir");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine();
            Console.Write("Elija una opción: ");
            string opcionseleccionada = Console.ReadLine();
            return opcionseleccionada;
        }


        public string menu2()
        {           
            Console.WriteLine("----- Menú de libros -------");
            Console.WriteLine();
            Console.WriteLine("1- Alta de libros");
            Console.WriteLine("2- Mostrar todos los libros");
            Console.WriteLine("3- Mostrar libros según autor");
            Console.WriteLine("4- Salir");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine();
            Console.Write("Elija una opción: ");
            string opcionseleccionada = Console.ReadLine();
            return opcionseleccionada;




        }

        public string menu3()
        {
            Console.WriteLine("----- Menú de comic -------");
            Console.WriteLine();
            Console.WriteLine("1- Alta de cómic");
            Console.WriteLine("2- Mostrar cómics según año");
            Console.WriteLine("3- Mostrar cómics según editora");
            Console.WriteLine("4- Salir");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine();
            Console.Write("Elija una opción: ");
            string opcionseleccionada = Console.ReadLine();
            return opcionseleccionada;

        }

        public string menu4()
        {
            Console.WriteLine("----- Menú de películas -------");
            Console.WriteLine();
            Console.WriteLine("1- Alta de película");
            Console.WriteLine("2- Mostrar películas según género");
            Console.WriteLine("3- Mostrar películas según director");
            Console.WriteLine("4- Salir");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine();
            Console.Write("Elija una opción: ");
            string opcionseleccionada = Console.ReadLine();
            return opcionseleccionada;

        }

        public string menu5()
        {
            Console.WriteLine("----- Menú de Series TV -------");
            Console.WriteLine();
            Console.WriteLine("1- Alta de serie de TV");
            Console.WriteLine("2- Mostrar series de tv por género");
            Console.WriteLine("3- Mostrar todas las series TV");
            Console.WriteLine("4- Salir");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            Console.WriteLine();
            Console.Write("Elija una opción: ");
            string opcionseleccionada = Console.ReadLine();
            return opcionseleccionada;

        }



        public void salir()
        {
            Console.Write("Desea realizar otra operación (s/n): ");
            string continuar = Console.ReadLine();

            if (continuar.ToLower() == "s")
            {
                Console.Clear();
            }
            else
            {
                terminar = true;


            }
        }*/

       /* public void creardatosIniciales()
        {
            /*    accesoaBDBiblioteca = new BibliotecaEntities();
            listaObrasCulturales= accesoaBDBiblioteca.ObraCulturalBiblioteca.ToList();*/

            //   loc = MapeoBD_DTO(listaObrasCulturales);





            /*   foreach (ObraCulturalBiblioteca elemento in listaObrasCulturales)
               {
                   if(elemento.ObraDeVideoBiblioteca != null)
                   {
                       ObraDeVideoBiblioteca nuevaobravideo = new ObraDeVideoBiblioteca()
                       {

                           IdObra = elemento.IdObra,
                           DirectorObra = elemento.ObraDeVideoBiblioteca.First().DirectorObra,
                           RepartoObra=elemento.ObraDeVideoBiblioteca.First().RepartoObra
                       };
                     //  loc.Add(nuevaobravideo);
                   }
               }*/

         /*   inicializarlista();*/
          /*  foreach(ObraCulturalDTO elemento in loc)
            {
                Console.WriteLine(elemento.titulo);
                Console.WriteLine(elemento.anyo);
                Console.WriteLine(elemento.genero);             
                
            }*/

        /*    listaobras = new List<ObraCulturalDTO>()
            {
                new LibroDTO()
                {
                    titulo="Don Quijote de la Mancha",
                    anyo=1605,
                    genero="Novela de caballerias",
                    autor="Miguel de Cervantes",
                    paginas=839

                },
                new ComicDTO()
                {
                    titulo="Spiderman",
                    anyo=1962,
                    genero="Superheroes",
                    autor="Stan Lee",
                    editora="Marvel",
                    numerodevolumenes=23,
                    capitulos=34


                },
                new PeliculaDTO()
                {
                    titulo="Gran Torino",
                    anyo=2008,
                    genero="drama",
                    director="Clint Eastwood",
                    reparto="Clint Eastwood, Christopher Carley",
                    duracion=119,
                    productora="Warner Bros"
                },
                new SerieTVDTO()
                {
                    titulo="The Wire",
                    anyo=2002,
                    genero="Drama",
                    director="David Simon",
                    reparto="Dominic West, Lance Reddick",
                    temporadas=5,
                    capitulos=60,
                    Canal="HBO"
                },
                new SerieTVDTO()
                {
                    titulo="The Simpsons (Los Simpson)",
                    anyo=1989,
                    genero="Animación",
                    director="Matt Groening",
                    reparto="Dan Castellaneta, Julie Kavner",
                    temporadas=31,
                    capitulos=684,
                    Canal="Fox"
                },
                new LibroDTO()
                {
                     titulo="La Celestina",
                    anyo=1499,
                    genero="Teatro",
                    autor="Fernando de Rojas",
                    paginas=324
                },
                new ComicDTO(){
                     titulo="One Piece",
                    anyo=1997,
                    genero="Manga",
                    autor="Eiichiro Oda",
                    editora="Shueisha",
                    numerodevolumenes=96,
                    capitulos=950
                }

            };*/

        /*}*/

      /*  public void inicializarlista()
        {
            listaobras = new List<ObraCulturalDTO>();
            accesoaBDBiblioteca = new BibliotecaEntities();
            lLibrosBD = accesoaBDBiblioteca.LibroBiblioteca.ToList();
            lComicsBD = accesoaBDBiblioteca.ComicBiblioteca.ToList();
            lPeliculaBD = accesoaBDBiblioteca.PeliculaBiblioteca.ToList();
            lSerieBD = accesoaBDBiblioteca.SerieTVBiblioteca.ToList();
          
            loc = new List<ObraCulturalDTO>();
           
            foreach (LibroBiblioteca item in lLibrosBD)
            {
                LibroDTO libroDTO = new LibroDTO();

                libroDTO.codigoobra = (int)item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                libroDTO.titulo = item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                libroDTO.anyo = (int)item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                libroDTO.genero = item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                libroDTO.alquilado = (bool)item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
                libroDTO.autor = item.ObraLiterariaBiblioteca.AutorObra;
                libroDTO.paginas = (int)item.PaginasObra;
               
               
                listaobras.Add(libroDTO);
            }
            foreach(ComicBiblioteca item in lComicsBD)
            {
                ComicDTO comicDTO = new ComicDTO();


                comicDTO.codigoobra = (int)item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                comicDTO.titulo = item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                comicDTO.anyo = (int)item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                comicDTO.genero = item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                comicDTO.alquilado = (bool)item.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
                comicDTO.autor = item.ObraLiterariaBiblioteca.AutorObra;
                comicDTO.editora = item.EditoraObra;
                comicDTO.numerodevolumenes = (int)item.NumeroVolumenesObra;
                comicDTO.capitulos = (int)item.CapitulosObra;


                listaobras.Add(comicDTO);
            }
            foreach(PeliculaBiblioteca item in lPeliculaBD)
            {
                PeliculaDTO peliculaDTO = new PeliculaDTO();
             
                peliculaDTO.codigoobra = (int)item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                peliculaDTO.titulo = item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                peliculaDTO.anyo = (int)item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                peliculaDTO.genero = item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                peliculaDTO.alquilado = (bool)item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
                peliculaDTO.director = item.ObraDeVideoBiblioteca.DirectorObra;
                peliculaDTO.reparto = item.ObraDeVideoBiblioteca.RepartoObra;
                peliculaDTO.duracion = (int)item.DuracionObra;
                peliculaDTO.productora = item.ProductoraObra;

                listaobras.Add(peliculaDTO);
            }

            foreach(SerieTVBiblioteca item in lSerieBD)
            {
                SerieTVDTO serieDTO = new SerieTVDTO();
              
                serieDTO.codigoobra = (int)item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                serieDTO.titulo = item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                serieDTO.anyo =(int) item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                serieDTO.genero = item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                serieDTO.alquilado = (bool)item.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
                serieDTO.director = item.ObraDeVideoBiblioteca.DirectorObra;
                serieDTO.reparto = item.ObraDeVideoBiblioteca.RepartoObra;
                serieDTO.temporadas = (int)item.TemporadasObra;
                serieDTO.capitulos = (int)item.CapitulosObra;
                serieDTO.Canal = item.CanalObra;

                listaobras.Add(serieDTO);
            }
          
            MapeoDTO_PorLibros(lLibrosBD, loc);
            MapeoDTO_PorComics(lComicsBD, loc);
            MapeoDTO_PorPeliculas(lPeliculaBD, loc);
            MapeoDTO_PorSeriesTV(lSerieBD, loc);
            loc.OrderBy(x => x.titulo);


        }*/

     /*   public List<ObraCulturalBiblioteca> MapeoBD_DTO(List<ObraCulturalDTO> lista)
        {
            List<ObraCulturalDTO> resul = new List<ObraCulturalDTO>(); 
            foreach (ObraCulturalBiblioteca elemento in listaObrasCulturales)
            {
                /* if (elemento.ObraDeVideoBiblioteca.Count==1)
                 {
                     ObraDeVideoBiblioteca nuevaobravideo = new ObraDeVideoBiblioteca()
                     {

                         IdObra = elemento.IdObra,
                         DirectorObra = elemento.ObraDeVideoBiblioteca.First().DirectorObra,
                         RepartoObra = elemento.ObraDeVideoBiblioteca.First().RepartoObra
                     };
                       //resul.Add(nuevaobravideo);

                 }*/
            /*    if (elemento.IdObra == 0)
                {
                    accesoaBDBiblioteca.ObraCulturalBiblioteca.Add(elemento);
                }
                else
                {
                    ObraCulturalBiblioteca obraculturalModificar = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(elemento.IdObra);
                    obraculturalModificar.TituloObra = elemento.TituloObra;
                    obraculturalModificar.AnyoObra = elemento.AnyoObra;
                    obraculturalModificar.GeneroObra = elemento.GeneroObra;
                }
            }
            accesoaBDBiblioteca.SaveChanges();
            return listaObrasCulturales;
        }*/

      /*  public void MapeoDTO_PorLibros(List<LibroBiblioteca> listalibros,List<ObraCulturalDTO> listafinalDTO)
        {
            foreach(LibroBiblioteca elemento in listalibros)
            {
                ObraCulturalDTO nuevoLibro = Mapeo_Libros_LibrosDTO(elemento);
                listafinalDTO.Add(nuevoLibro);
            }
        } 

        public void MapeoDTO_PorComics(List<ComicBiblioteca> listacomics,List<ObraCulturalDTO> listafinalDTO)
        {
            foreach(ComicBiblioteca elemento in listacomics)
            {
                ObraCulturalDTO nuevoComic = Mapeo_Comics_ComicsDTO(elemento);
                listafinalDTO.Add(nuevoComic);
            }
        }

        public void MapeoDTO_PorPeliculas(List<PeliculaBiblioteca> listapelicula,List<ObraCulturalDTO> listafinalDTO)
        {
            foreach(PeliculaBiblioteca elemento in listapelicula)
            {
                ObraCulturalDTO nuevaPelicula = Mapeo_Peliculas_PeliculasDTO(elemento);
                listafinalDTO.Add(nuevaPelicula);
            }
        }

        public void MapeoDTO_PorSeriesTV(List<SerieTVBiblioteca> listaseries,List<ObraCulturalDTO> listafinalDTO)
        {
            foreach(SerieTVBiblioteca elemento in listaseries)
            {
                ObraCulturalDTO nuevaSerie = Mapeo_Series_SeriesDTO(elemento);
                listafinalDTO.Add(nuevaSerie);
            }
            
        }
       

        public LibroDTO Mapeo_Libros_LibrosDTO(LibroBiblioteca elementoamapear)
        {
            LibroDTO nuevoLibroDTO = new LibroDTO()
            {
                codigoobra=(int)elementoamapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra,
                titulo = elementoamapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra,
                anyo= (int)elementoamapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra,
                genero=elementoamapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra,
                autor=elementoamapear.ObraLiterariaBiblioteca.AutorObra,
                paginas=(int)elementoamapear.PaginasObra

            };
            return nuevoLibroDTO;
        }

        public ComicDTO Mapeo_Comics_ComicsDTO(ComicBiblioteca elementoAMapear)
        {
            ComicDTO nuevoComicDTO = new ComicDTO()
            {
                codigoobra=(int)elementoAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra,
                titulo = elementoAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra,
                anyo=(int) elementoAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra,
                genero=elementoAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra,
                autor=elementoAMapear.ObraLiterariaBiblioteca.AutorObra,
                editora=elementoAMapear.EditoraObra,
                numerodevolumenes=(int)elementoAMapear.NumeroVolumenesObra,
                capitulos=(int)elementoAMapear.CapitulosObra
            };
            return nuevoComicDTO;
        }

        public PeliculaDTO Mapeo_Peliculas_PeliculasDTO(PeliculaBiblioteca elementoAMapear)
        {
            PeliculaDTO nuevaPeliculaDTO = new PeliculaDTO()
            {
                codigoobra = (int)elementoAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra,
                titulo = elementoAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra,
                anyo = (int)elementoAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra,
                genero = elementoAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra,
                director = elementoAMapear.ObraDeVideoBiblioteca.DirectorObra,
                reparto = elementoAMapear.ObraDeVideoBiblioteca.RepartoObra,
                duracion = (int)elementoAMapear.DuracionObra,
                productora = elementoAMapear.ProductoraObra

            };
            return nuevaPeliculaDTO;
        }

        public SerieTVDTO Mapeo_Series_SeriesDTO(SerieTVBiblioteca elementoaMapear)
        {
            SerieTVDTO nuevaSerieDTO = new SerieTVDTO()
            {
                codigoobra = (int)elementoaMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra,
                titulo=elementoaMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra,
                anyo=(int) elementoaMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra,
                genero=elementoaMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra,
                director=elementoaMapear.ObraDeVideoBiblioteca.DirectorObra,
                reparto=elementoaMapear.ObraDeVideoBiblioteca.RepartoObra,
                temporadas=(int)elementoaMapear.TemporadasObra,
                capitulos=(int)elementoaMapear.CapitulosObra,
                Canal=elementoaMapear.CanalObra

            };
            return nuevaSerieDTO;
        }*/

      /*  public void borrarelemento()
        {
            ObraCulturalDTO obraaborrar = buscarporcodigo();

            ObraCulturalBiblioteca obraculturalaborrar = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraaborrar.titulo);

            accesoaBDBiblioteca.SaveChanges();
        }*/
    /*  public LibroBiblioteca Mapeo_LibrosDTO_Libros(LibroDTO elementoAMapear)
        {
            LibroBiblioteca librodesdebbdd = new LibroBiblioteca();

            librodesdebbdd.ObraLiterariaBiblioteca = new ObraLiterariaBiblioteca();
            librodesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();
            librodesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra = elementoAMapear.codigoobra;
            librodesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra = elementoAMapear.titulo;
            librodesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra = elementoAMapear.anyo;
            librodesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra = elementoAMapear.genero;
            librodesdebbdd.ObraLiterariaBiblioteca.AutorObra = elementoAMapear.autor;
            librodesdebbdd.PaginasObra = elementoAMapear.paginas;
            return librodesdebbdd;
        }

        public ComicBiblioteca Mapeo_ComicsDTO_Comics(ComicDTO elementoAMapear)
        {
            ComicBiblioteca comicdesdebbdd = new ComicBiblioteca();
            comicdesdebbdd.ObraLiterariaBiblioteca = new ObraLiterariaBiblioteca();
            comicdesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();
            comicdesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra = elementoAMapear.codigoobra;
            comicdesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra = elementoAMapear.titulo;
            comicdesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra = elementoAMapear.anyo;
            comicdesdebbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra = elementoAMapear.genero;
            comicdesdebbdd.ObraLiterariaBiblioteca.AutorObra = elementoAMapear.autor;
            comicdesdebbdd.EditoraObra = elementoAMapear.editora;
            comicdesdebbdd.NumeroVolumenesObra = elementoAMapear.numerodevolumenes;
            comicdesdebbdd.CapitulosObra = elementoAMapear.capitulos;
            return comicdesdebbdd;
        }

        public PeliculaBiblioteca Mapeo_PeliculasDTO_Peliculas(PeliculaDTO elementoAMapear)
        {
            PeliculaBiblioteca peliculadesdebbdd = new PeliculaBiblioteca();
            peliculadesdebbdd.ObraDeVideoBiblioteca = new ObraDeVideoBiblioteca();
            peliculadesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();
            peliculadesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra = elementoAMapear.codigoobra;
            peliculadesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra = elementoAMapear.titulo;
            peliculadesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra = elementoAMapear.anyo;
            peliculadesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra = elementoAMapear.genero;
            peliculadesdebbdd.ObraDeVideoBiblioteca.DirectorObra = elementoAMapear.director;
            peliculadesdebbdd.ObraDeVideoBiblioteca.RepartoObra = elementoAMapear.reparto;
            peliculadesdebbdd.DuracionObra = elementoAMapear.duracion;
            peliculadesdebbdd.ProductoraObra = elementoAMapear.productora;
            return peliculadesdebbdd;
        }

        public SerieTVBiblioteca Mapeo_SerieTVDTO_Series(SerieTVDTO elementoAMapear)
        {
            SerieTVBiblioteca seriedesdebbdd = new SerieTVBiblioteca();
            seriedesdebbdd.ObraDeVideoBiblioteca = new ObraDeVideoBiblioteca();
            seriedesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();
            seriedesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra = elementoAMapear.codigoobra;
            seriedesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra = elementoAMapear.titulo;
            seriedesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra = elementoAMapear.anyo;
            seriedesdebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra = elementoAMapear.genero;
            seriedesdebbdd.ObraDeVideoBiblioteca.DirectorObra = elementoAMapear.director;
            seriedesdebbdd.ObraDeVideoBiblioteca.RepartoObra = elementoAMapear.reparto;
            seriedesdebbdd.TemporadasObra = elementoAMapear.temporadas;
            seriedesdebbdd.CapitulosObra =elementoAMapear.capitulos;
            seriedesdebbdd.CanalObra = elementoAMapear.Canal;
            return seriedesdebbdd;
        
        }*/


        public void MapeoBD_DTO_Por_Libros(List<LibroBiblioteca> listalibros, List<ObraCulturalDTO> listaFinalDTOs)
        {
            foreach (LibroBiblioteca libroBD in listalibros)
            {
                LibroDTO nuevolibroDto = new LibroDTO();
                Mapeo_LibrosBiblioteca_LibrosDTO(libroBD, nuevolibroDto);
                listaFinalDTOs.Add(nuevolibroDto);
            }
        }

        public void MapeoBD_DTO_Por_Comics(List<ComicBiblioteca> listacomics,List<ObraCulturalDTO> listaFinalDTOs)
        {
            foreach(ComicBiblioteca comicBD in listacomics)
            {
                ComicDTO nuevocomicDto = new ComicDTO();
                Mapeo_ComicsBiblioteca_ComicsDTO(comicBD, nuevocomicDto);
                listaFinalDTOs.Add(nuevocomicDto);
            }
        }

        public void MapeoBD_DTO_Por_Peliculas(List<PeliculaBiblioteca> listapeliculas,List<ObraCulturalDTO> listaFinalDTOs)
        {
            foreach(PeliculaBiblioteca peliculaBD in listapeliculas)
            {
                PeliculaDTO nuevapeliculaDto = new PeliculaDTO();
                Mapeo_PeliculasBiblioteca_PeliculasDTO(peliculaBD, nuevapeliculaDto);
                listaFinalDTOs.Add(nuevapeliculaDto);
            }
        }

        public void MapeoBD_DTO_Por_Series(List<SerieTVBiblioteca> listaseries,List<ObraCulturalDTO> listaFinalDTOs)
        {
            foreach(SerieTVBiblioteca serieTVBD in listaseries)
            {
                SerieTVDTO nuevaserietvDto = new SerieTVDTO();
                Mapeo_SeriesBiblioteca_SeriesTVDTO(serieTVBD, nuevaserietvDto);
                listaFinalDTOs.Add(nuevaserietvDto);
            }
        }

        public void Mapeo_LibrosBiblioteca_LibrosDTO(LibroBiblioteca libroEntityAMapear, LibroDTO libroDto)
        {
            libroDto.codigoobra = (int)libroEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
            libroDto.titulo = libroEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
            libroDto.anyo = (int)libroEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
            libroDto.genero = libroEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
            libroDto.alquilado = (bool)libroEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
            libroDto.autor = libroEntityAMapear.ObraLiterariaBiblioteca.AutorObra;
            libroDto.paginas = (int)libroEntityAMapear.PaginasObra;
          
        }

        public void Mapeo_ComicsBiblioteca_ComicsDTO(ComicBiblioteca comicEntityAMapear, ComicDTO comicDto)
        {
            comicDto.codigoobra = (int)comicEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
            comicDto.titulo = comicEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
            comicDto.anyo = (int)comicEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
            comicDto.genero = comicEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
            comicDto.alquilado = (bool)comicEntityAMapear.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
            comicDto.autor = comicEntityAMapear.ObraLiterariaBiblioteca.AutorObra;
            comicDto.editora = comicEntityAMapear.EditoraObra;
            comicDto.numerodevolumenes =(int) comicEntityAMapear.NumeroVolumenesObra;
            comicDto.capitulos = (int)comicEntityAMapear.CapitulosObra;
        }

        public void Mapeo_PeliculasBiblioteca_PeliculasDTO(PeliculaBiblioteca peliculaEntityAMapear, PeliculaDTO peliculaDto)
        {
            peliculaDto.codigoobra = (int)peliculaEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
            peliculaDto.titulo = peliculaEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
            peliculaDto.anyo = (int)peliculaEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
            peliculaDto.genero = peliculaEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
            peliculaDto.alquilado = (bool)peliculaEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
            peliculaDto.director = peliculaEntityAMapear.ObraDeVideoBiblioteca.DirectorObra;
            peliculaDto.reparto = peliculaEntityAMapear.ObraDeVideoBiblioteca.RepartoObra;
            peliculaDto.duracion = (int)peliculaEntityAMapear.DuracionObra;
            peliculaDto.productora = peliculaEntityAMapear.ProductoraObra;
        }

        public void Mapeo_SeriesBiblioteca_SeriesTVDTO(SerieTVBiblioteca serieEntityAMapear, SerieTVDTO serieTVDto)
        {
            serieTVDto.codigoobra = (int)serieEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
            serieTVDto.titulo = serieEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
            serieTVDto.anyo = (int)serieEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
            serieTVDto.genero = serieEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
            serieTVDto.alquilado = (bool)serieEntityAMapear.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra;
            serieTVDto.director = serieEntityAMapear.ObraDeVideoBiblioteca.DirectorObra;
            serieTVDto.reparto = serieEntityAMapear.ObraDeVideoBiblioteca.RepartoObra;
            serieTVDto.temporadas = (int)serieEntityAMapear.TemporadasObra;
            serieTVDto.capitulos = (int)serieEntityAMapear.CapitulosObra;
            serieTVDto.Canal = serieEntityAMapear.CanalObra;
        }

        public void Mapeo_LibroDto_LibrosBiblioteca(LibroDTO libroDTOAMapear,LibroBiblioteca libroBD)
        {
            libroBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra = libroDTOAMapear.codigoobra;
            libroBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra = libroDTOAMapear.titulo;
            libroBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra = libroDTOAMapear.anyo;
            libroBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra = libroDTOAMapear.genero;
            libroBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = libroDTOAMapear.alquilado;
            libroBD.ObraLiterariaBiblioteca.AutorObra = libroDTOAMapear.autor;
            libroBD.PaginasObra = libroDTOAMapear.paginas;
            
        }

        public void Mapeo_ComicDto_ComicsBiblioteca(ComicDTO comicDTOAMapear, ComicBiblioteca comicBD)
        {
            comicBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra = comicDTOAMapear.codigoobra;
            comicBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra = comicDTOAMapear.titulo;
            comicBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra = comicDTOAMapear.anyo;
            comicBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra = comicDTOAMapear.genero;
            comicBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = comicDTOAMapear.alquilado;
            comicBD.ObraLiterariaBiblioteca.AutorObra = comicDTOAMapear.autor;
            comicBD.EditoraObra = comicDTOAMapear.editora;
            comicBD.NumeroVolumenesObra = comicDTOAMapear.numerodevolumenes;
            comicBD.CapitulosObra = comicDTOAMapear.capitulos;
        }

        public void Mapeo_PeliculaDto_PeliculasBiblioteca(PeliculaDTO peliculaDTOAMapear,PeliculaBiblioteca peliculaBD)
        {
            peliculaBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra = peliculaDTOAMapear.codigoobra;
            peliculaBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra = peliculaDTOAMapear.titulo;
            peliculaBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra = peliculaDTOAMapear.anyo;
            peliculaBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra = peliculaDTOAMapear.genero;
            peliculaBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = peliculaDTOAMapear.alquilado;
            peliculaBD.ObraDeVideoBiblioteca.DirectorObra = peliculaDTOAMapear.director;
            peliculaBD.ObraDeVideoBiblioteca.RepartoObra = peliculaDTOAMapear.reparto;
            peliculaBD.DuracionObra = peliculaDTOAMapear.duracion;
            peliculaBD.ProductoraObra = peliculaDTOAMapear.productora;
        }

        public void Mapeo_SerieTVDto_SeriesTVBiblioteca(SerieTVDTO serieDTOAMapear, SerieTVBiblioteca serieTVBD)
        {
            serieTVBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra = serieDTOAMapear.codigoobra;
            serieTVBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra = serieDTOAMapear.titulo;
            serieTVBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra = serieDTOAMapear.anyo;
            serieTVBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra = serieDTOAMapear.genero;
            serieTVBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = serieDTOAMapear.alquilado;
            serieTVBD.ObraDeVideoBiblioteca.DirectorObra = serieDTOAMapear.director;
            serieTVBD.ObraDeVideoBiblioteca.RepartoObra = serieDTOAMapear.reparto;
            serieTVBD.TemporadasObra = serieDTOAMapear.temporadas;
            serieTVBD.CapitulosObra = serieDTOAMapear.capitulos;
            serieTVBD.CanalObra = serieDTOAMapear.Canal;
        }

        public List<LibroDTO> DevolverTodosLosLibros()
        {
            Biblioteca bib = new Biblioteca();
            return bib.GetListaLibrosDesdeBD();
        }

        public LibroDTO GetLibroPorId(long id)
        {
            LibroDTO libro = GetListaLibrosDesdeBD().FirstOrDefault(x => x.codigoobra == id);
            if (libro == null)
            {
                throw new NullReferenceException("El libro solicitado no se ha encontrado");
            }
            return libro;
        }

        public ComicDTO GetComicPorId(long id)
        {
            ComicDTO comic = GetListaComicsDesdeBD().FirstOrDefault(x => x.codigoobra == id);
            if(comic == null)
            {
                throw new NullReferenceException("El comic solicitado no se ha encontrado");
            }
            return comic;
        }

        public PeliculaDTO GetPeliculaPorId(long id)
        {
            PeliculaDTO pelicula = GetListaPeliculasDesdeBD().FirstOrDefault(x => x.codigoobra == id);
            if(pelicula == null)
            {
                throw new NullReferenceException("La pelicula solicitada no se ha encontrado");
            }
            return pelicula;
        }

        public SerieTVDTO GetSeriePorId(long id)
        {
            SerieTVDTO serie = GetListaSeriesDesdeBD().FirstOrDefault(x => x.codigoobra == id);
            if(serie == null)
            {
                throw new NullReferenceException("La serie solicitada no se ha encontrado");
            }
            return serie;
        }

        public List<LibroDTO> GetListaLibrosDesdeBD()
        {
            using (BibliotecaEntities accesoaBDBiblioteca = new BibliotecaEntities())
            {
                List<ObraCulturalDTO> locu = new List<ObraCulturalDTO>();
               MapeoBD_DTO_Por_Libros(GetListaLibros(accesoaBDBiblioteca), locu);
                return locu.OfType<LibroDTO>().ToList();
            }
        }

        public List<ComicDTO> GetListaComicsDesdeBD()
        {
            using(BibliotecaEntities accesoaBDBiblioteca = new BibliotecaEntities())
            {
                List<ObraCulturalDTO> locu = new List<ObraCulturalDTO>();
                MapeoBD_DTO_Por_Comics(GetListaComics(accesoaBDBiblioteca), locu);
                return locu.OfType<ComicDTO>().ToList();
            }
        }

        public List<PeliculaDTO> GetListaPeliculasDesdeBD()
        {
            using(BibliotecaEntities accesoaBDBiblioteca=new BibliotecaEntities())
            {
                List<ObraCulturalDTO> locu = new List<ObraCulturalDTO>();
                MapeoBD_DTO_Por_Peliculas(GetListaPeliculas(accesoaBDBiblioteca), locu);
                return locu.OfType<PeliculaDTO>().ToList();
            }
        }

        public List<SerieTVDTO> GetListaSeriesDesdeBD()
        {
            using(BibliotecaEntities accesoaBDBiblioteca= new BibliotecaEntities())
            {
                List<ObraCulturalDTO> locu = new List<ObraCulturalDTO>();
                MapeoBD_DTO_Por_Series(GetListaSeries(accesoaBDBiblioteca), locu);
                return locu.OfType<SerieTVDTO>().ToList();
            }
        }

        
        public List<LibroBiblioteca> GetListaLibros(BibliotecaEntities accesoaBDBiblioteca)
        {
            List<LibroBiblioteca> listadevuelta = accesoaBDBiblioteca.LibroBiblioteca.ToList();
            return listadevuelta;
        }


        public List<ComicBiblioteca> GetListaComics(BibliotecaEntities accesoaBDBiblioteca)
        {
            List<ComicBiblioteca> listadevuelta = accesoaBDBiblioteca.ComicBiblioteca.ToList();
            return listadevuelta;
        }

        public List<PeliculaBiblioteca> GetListaPeliculas(BibliotecaEntities accesoaBDBiblioteca)
        {
            List<PeliculaBiblioteca> listadevuelta = accesoaBDBiblioteca.PeliculaBiblioteca.ToList();
            return listadevuelta;
        }

        public List<SerieTVBiblioteca> GetListaSeries(BibliotecaEntities accesoaBDBiblioteca)
        {
            List<SerieTVBiblioteca> listadevuelta = accesoaBDBiblioteca.SerieTVBiblioteca.ToList();
            return listadevuelta;
        }

        public LibroDTO mostrarLibros(long id)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                return bib.GetLibroPorId(id);
            }
            catch(Exception e)
            {
                throw new NullReferenceException("El libro solicitado no se ha encontrado");
            }
        }

        public ComicDTO mostrarComics(long id)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                return bib.GetComicPorId(id);
            }
            catch(Exception e)
            {
                throw new NullReferenceException("El comic solicitado no se ha encontrado");
            }
        }

        public PeliculaDTO mostrarPeliculas(long id)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                return bib.GetPeliculaPorId(id);
            }
            catch(Exception e)
            {
                throw new NullReferenceException("La pelicula solicitada no se ha encontrado");
            }
        }

        public SerieTVDTO mostrarSeries(long id)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                return bib.GetSeriePorId(id);
            }
            catch(Exception e)
            {
                throw new NullReferenceException("La serie solicitada no se ha encontrado");
            }
        }


        public bool annadirLibros(LibroDTO libroaanadir)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.insertarNuevoLibro(libroaanadir);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool annadirComics(ComicDTO comicaanadir)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.insertarNuevoComic(comicaanadir);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool annadirPeliculas(PeliculaDTO peliculaaanadir)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.insertarNuevaPelicula(peliculaaanadir);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool annadirSeries(SerieTVDTO serieaanadir)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.insertarNuevaSerie(serieaanadir);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }


        public void insertarNuevoLibro(LibroDTO nuevoLibroDto)
        {
            LibroBiblioteca nuevoLibroBD = new LibroBiblioteca();
            nuevoLibroBD.ObraLiterariaBiblioteca = new ObraLiterariaBiblioteca();
            nuevoLibroBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();

            Mapeo_LibroDto_LibrosBiblioteca(nuevoLibroDto, nuevoLibroBD);

            using(BibliotecaEntities accesoaBDBiblioteca = new BibliotecaEntities())
            {
                accesoaBDBiblioteca.LibroBiblioteca.Add(nuevoLibroBD);
                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public void insertarNuevoComic(ComicDTO nuevoComicDto)
        {
            ComicBiblioteca nuevoComicBD = new ComicBiblioteca();
            nuevoComicBD.ObraLiterariaBiblioteca = new ObraLiterariaBiblioteca();
            nuevoComicBD.ObraLiterariaBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();

            Mapeo_ComicDto_ComicsBiblioteca(nuevoComicDto, nuevoComicBD);

            using (BibliotecaEntities accesoaBDBiblioteca = new BibliotecaEntities())
            {
                accesoaBDBiblioteca.ComicBiblioteca.Add(nuevoComicBD);
                accesoaBDBiblioteca.SaveChanges();
            }

        }

        public void insertarNuevaPelicula(PeliculaDTO nuevaPeliculaDto)
        {
            PeliculaBiblioteca nuevaPeliculaBD = new PeliculaBiblioteca();
            nuevaPeliculaBD.ObraDeVideoBiblioteca = new ObraDeVideoBiblioteca();
            nuevaPeliculaBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();

            Mapeo_PeliculaDto_PeliculasBiblioteca(nuevaPeliculaDto, nuevaPeliculaBD);

            using (BibliotecaEntities accesoaBDBiblioteca = new BibliotecaEntities())
            {
                accesoaBDBiblioteca.PeliculaBiblioteca.Add(nuevaPeliculaBD);
                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public void insertarNuevaSerie(SerieTVDTO nuevaSerieTVDto)
        {
            SerieTVBiblioteca nuevaSerieTVBD = new SerieTVBiblioteca();
            nuevaSerieTVBD.ObraDeVideoBiblioteca = new ObraDeVideoBiblioteca();
            nuevaSerieTVBD.ObraDeVideoBiblioteca.ObraCulturalBiblioteca = new ObraCulturalBiblioteca();

            Mapeo_SerieTVDto_SeriesTVBiblioteca(nuevaSerieTVDto, nuevaSerieTVBD);

            using(BibliotecaEntities accesoaBDBiblioteca=new BibliotecaEntities())
            {
                accesoaBDBiblioteca.SerieTVBiblioteca.Add(nuevaSerieTVBD);
                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public bool modificarLibro(LibroDTO libroaModificar)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.modificarLibroEnBD(libroaModificar);
                return true;
            }
            catch(Exception )
            {
                return false;
            }
        }

        public bool modificarComic(ComicDTO comicaModificar)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.modificarComicEnBD(comicaModificar);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool modificarPelicula(PeliculaDTO peliculaaModificar)
        {
            Biblioteca bib = new Biblioteca();
            try
            {

                bib.modificarPeliculaEnBD(peliculaaModificar);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool modificarSerie(SerieTVDTO serieaModificar)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.modificarSerieEnBD(serieaModificar);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }


        public void modificarLibroEnBD(LibroDTO dtoAModificar)
        {
            using(BibliotecaEntities accesoaBDBiblioteca=new BibliotecaEntities())
            {
                LibroBiblioteca libroAModificar = accesoaBDBiblioteca.LibroBiblioteca.FirstOrDefault(x => x.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra == dtoAModificar.codigoobra);

                Mapeo_LibroDTO_Libros_Edit(dtoAModificar, libroAModificar);

                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public void modificarComicEnBD(ComicDTO dtoAModificar)
        {
            using(BibliotecaEntities accesoaBDBiblioteca=new BibliotecaEntities())
            {
                ComicBiblioteca comicAModificar = accesoaBDBiblioteca.ComicBiblioteca.FirstOrDefault(x => x.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra == dtoAModificar.codigoobra);

                Mapeo_ComicDTO_Comics_Edit(dtoAModificar, comicAModificar);

                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public void modificarPeliculaEnBD(PeliculaDTO dtoAModificar)
        {
            using(BibliotecaEntities accesoaBDBiblioteca=new BibliotecaEntities())
            {
                PeliculaBiblioteca peliculaAModificar = accesoaBDBiblioteca.PeliculaBiblioteca.FirstOrDefault(x => x.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra == dtoAModificar.codigoobra);

                Mapeo_PeliculaDTO_Peliculas_Edit(dtoAModificar, peliculaAModificar);

                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public void modificarSerieEnBD(SerieTVDTO dtoAModificar)
        {
            using(BibliotecaEntities accesoaBDBiblioteca=new BibliotecaEntities())
            {
                SerieTVBiblioteca serieAModificar = accesoaBDBiblioteca.SerieTVBiblioteca.FirstOrDefault(x => x.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra == dtoAModificar.codigoobra);

                Mapeo_SerieTVDTO_Series_Edit(dtoAModificar, serieAModificar);

                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public void Mapeo_LibroDTO_Libros_Edit(LibroDTO libroDTOAMapear,LibroBiblioteca librobd)
        {
            librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra = libroDTOAMapear.codigoobra;
            librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra = libroDTOAMapear.titulo;
            librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra = libroDTOAMapear.anyo;
            librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra = libroDTOAMapear.genero;
            librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = libroDTOAMapear.alquilado;
            librobd.ObraLiterariaBiblioteca.AutorObra = libroDTOAMapear.autor;
            librobd.PaginasObra = libroDTOAMapear.paginas;

        }

        public void Mapeo_ComicDTO_Comics_Edit(ComicDTO comicDTOAMapear, ComicBiblioteca comicbd)
        {
            comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra = comicDTOAMapear.codigoobra;
            comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra = comicDTOAMapear.titulo;
            comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra = comicDTOAMapear.anyo;
            comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra = comicDTOAMapear.genero;
            comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = comicDTOAMapear.alquilado;
            comicbd.ObraLiterariaBiblioteca.AutorObra = comicDTOAMapear.autor;
            comicbd.EditoraObra = comicDTOAMapear.editora;
            comicbd.NumeroVolumenesObra = comicDTOAMapear.numerodevolumenes;
            comicbd.CapitulosObra = comicDTOAMapear.capitulos;
        }

        public void Mapeo_PeliculaDTO_Peliculas_Edit(PeliculaDTO peliculaDTOAMapear, PeliculaBiblioteca peliculabd)
        {
            peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra = peliculaDTOAMapear.codigoobra;
            peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra = peliculaDTOAMapear.titulo;
            peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra = peliculaDTOAMapear.anyo;
            peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra = peliculaDTOAMapear.genero;
            peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = peliculaDTOAMapear.alquilado;
            peliculabd.ObraDeVideoBiblioteca.DirectorObra = peliculaDTOAMapear.director;
            peliculabd.ObraDeVideoBiblioteca.RepartoObra = peliculaDTOAMapear.reparto;
            peliculabd.DuracionObra = peliculaDTOAMapear.duracion;
            peliculabd.ProductoraObra = peliculaDTOAMapear.productora;
        }

        public void Mapeo_SerieTVDTO_Series_Edit(SerieTVDTO serieTVDTOAMapear, SerieTVBiblioteca serietvbd)
        {
            serietvbd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra = serieTVDTOAMapear.codigoobra;
            serietvbd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra = serieTVDTOAMapear.titulo;
            serietvbd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra = serieTVDTOAMapear.anyo;
            serietvbd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra = serieTVDTOAMapear.genero;
            serietvbd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = serieTVDTOAMapear.alquilado;
            serietvbd.ObraDeVideoBiblioteca.DirectorObra = serieTVDTOAMapear.director;
            serietvbd.ObraDeVideoBiblioteca.RepartoObra = serieTVDTOAMapear.reparto;
            serietvbd.TemporadasObra = serieTVDTOAMapear.temporadas;
            serietvbd.CapitulosObra = serieTVDTOAMapear.capitulos;
            serietvbd.CanalObra = serieTVDTOAMapear.Canal;
        }

        public bool borrarLibro(long idABorrar)
        {
            Biblioteca bib = new Biblioteca();
            try
            {
                bib.borrarLibroEnBDPorId(idABorrar);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void borrarLibroEnBDPorId(long idABorrar)
        {
            using (BibliotecaEntities accesoaBDBiblioteca=new BibliotecaEntities())
            {
                ObraCulturalBiblioteca libroABorrar = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(idABorrar);
                accesoaBDBiblioteca.LibroBiblioteca.Remove(libroABorrar.ObraLiterariaBiblioteca.First().LibroBiblioteca.First());
                accesoaBDBiblioteca.ObraLiterariaBiblioteca.Remove(libroABorrar.ObraLiterariaBiblioteca.First());
                accesoaBDBiblioteca.ObraCulturalBiblioteca.Remove(libroABorrar);

                accesoaBDBiblioteca.SaveChanges();
            }
        }

        public List<LibroDTO> DevolverLibrosPorAutor(string autor)
        {
            Biblioteca bib = new Biblioteca();
            return bib.GetLibrosPorAutor(autor);
        }

     /*   public List<ComicDTO> DevolverComicsPorAnyo(long anyo)
        {
            Biblioteca bib = new Biblioteca();
            return bib.GetComicsPorAnyo(anyo);
        }*/

        public List<LibroDTO> GetLibrosPorAutor(string autor)
        {
            return GetListaLibrosDesdeBD().Where(x => x.autor.ToLower().Contains(autor.ToLower())).ToList();
        }

     /*   public List<ComicDTO> GetComicsPorAnyo(long anyo)
        {
            return GetListaComicsDesdeBD().Where(x => x.anyo.ToString().Contains(anyo.ToString())).ToList();
        }*/

      /*  public void insertarLibros()
        {
        
            LibroDTO libro = new LibroDTO();
            libro.pedirInformacionLibro();
            // listaobras.Add(libro);
            /*   ObraCulturalBiblioteca obrabiblio = new ObraCulturalBiblioteca();
               Console.Write("Escriba un título: ");
              obrabiblio.TituloObra = Console.ReadLine();


               Console.Write("Escriba un año: ");
               obrabiblio.AnyoObra = int.Parse(Console.ReadLine());

               Console.Write("Escriba un género: ");
               obrabiblio.GeneroObra = Console.ReadLine();


               accesoaBDBiblioteca.ObraCulturalBiblioteca.Add(obrabiblio);
           accesoaBDBiblioteca.SaveChanges();*/
      /*      LibroBiblioteca librobbdd = new LibroBiblioteca();
            librobbdd = Mapeo_LibrosDTO_Libros(libro);
            BibliotecaEntities accesoaBD = new BibliotecaEntities();
            librobbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = false;
            accesoaBD.LibroBiblioteca.Add(librobbdd);
            lLibrosBD.Add(librobbdd);
            accesoaBD.SaveChanges();
           
            listaobras.Add(libro);

            Console.WriteLine("Se ha insertado un libro en base de datos");

        }*/

      /*  public void insertarComic()
        {
            ComicDTO comic = new ComicDTO();
            comic.pedirInformacionComic();
           
            ComicBiblioteca comicbbdd = new ComicBiblioteca();
            comicbbdd = Mapeo_ComicsDTO_Comics(comic);
            BibliotecaEntities accesoaBD = new BibliotecaEntities();
            comicbbdd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = false;
            accesoaBD.ComicBiblioteca.Add(comicbbdd);
            lComicsBD.Add(comicbbdd);
            accesoaBD.SaveChanges();
            listaobras.Add(comic);
            Console.WriteLine("Se ha insertado un cómic en base de datos");

        }

        public void insertarPelicula()
        {
            PeliculaDTO pelicula = new PeliculaDTO();
            pelicula.pedirInformacionPelicula();
          
            PeliculaBiblioteca peliculabbdd = new PeliculaBiblioteca();
            peliculabbdd = Mapeo_PeliculasDTO_Peliculas(pelicula);
            BibliotecaEntities accesoaBD = new BibliotecaEntities();
            peliculabbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = false;
            accesoaBD.PeliculaBiblioteca.Add(peliculabbdd);
            lPeliculaBD.Add(peliculabbdd);
            accesoaBD.SaveChanges();
            listaobras.Add(pelicula);
            Console.WriteLine("Se ha insertado una película en base de datos");
        }

        public void insertarSerie()
        {
            SerieTVDTO serie = new SerieTVDTO();
            serie.pedirInformacionSerie();
           
            SerieTVBiblioteca seriebbdd = new SerieTVBiblioteca();
            seriebbdd = Mapeo_SerieTVDTO_Series(serie);
            BibliotecaEntities accesoaBD = new BibliotecaEntities();
            seriebbdd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AlquiladoObra = false;
            accesoaBD.SerieTVBiblioteca.Add(seriebbdd);
            lSerieBD.Add(seriebbdd);
            accesoaBD.SaveChanges();
            listaobras.Add(serie);
            Console.WriteLine("Se ha insertado una serie de TV en base de datos");
        }



        public void mostrarLibros()
        {
            //    List<ObraCulturalDTO> listalibros = listaobras.Where(x => x.ToString().Contains("LibroDTO")).ToList();
          
            if (lLibrosBD.Count != 0)
            {
                Console.Clear();
                foreach(LibroBiblioteca librobd in lLibrosBD)
                {
                    Console.WriteLine();
                    inicializarlista();
                  LibroDTO libro=  Mapeo_Libros_LibrosDTO(librobd);
                    libro.mostrarInformacion();                   
                }
            }
           /*   if (listalibros.Count != 0)
              {
                  Console.Clear();
                  foreach (LibroDTO libro in listalibros)
                  {
                      Console.WriteLine();
                    inicializarlista();
                      libro.mostrarInformacion();

                      Console.WriteLine();
                  }
              }*/
          
          
        /*    else
            {
                Console.WriteLine("No hay elementos en la lista");
            }

        }*/


     /*   public List<LibroDTO> devolverLibros()
        {
            //    List<ObraCulturalDTO> listalibros = listaobras.Where(x => x.ToString().Contains("LibroDTO")).ToList();
            inicializarlista();
            LibroDTO libros = Mapeo_Libros_LibrosDTO(lLibrosBD.First());
            List<LibroDTO> listaLibros = new List<LibroDTO>();
            listaLibros.Add(libros);
            return  listaLibros;

        }


        public void mostrarLibrosAutor()
        {
            Console.Clear();
           /* listaobras.ForEach(x =>
            {
                if (x.GetType().Name == "LibroDTO")
                {
                    Console.WriteLine();
                    inicializarlista();
                    x.mostrarInformacion();
                    Console.WriteLine();
                }


            });*/

         /*   lLibrosBD.ForEach(x =>
            {            
                    Console.WriteLine();
                    inicializarlista();
                    LibroDTO libro = Mapeo_Libros_LibrosDTO(x);
                    libro.mostrarInformacion();
                    Console.WriteLine();
                
            });
            Console.Write($"Escriba el nombre del autor que quieres buscar: ");
            string autorbuscar = Console.ReadLine();

            if(lLibrosBD.Count!=0 && autorbuscar!=null && autorbuscar != "")
            {
                Console.Clear();
                lLibrosBD.ForEach(x =>
                {
                    if (x.ObraLiterariaBiblioteca.AutorObra == autorbuscar)
                    {
                        Console.WriteLine();
                        LibroDTO libro = Mapeo_Libros_LibrosDTO(x);
                        libro.mostrarInformacion();
                        Console.WriteLine();
                    }
                });
            }
          /*  if (listaobras.Count != 0 && autorbuscar != null && autorbuscar != "" )
            {
                Console.Clear();
                listaobras.ForEach(x =>
                {
                    if (x.GetType().Name == "LibroDTO" && ((LibroDTO)x).autor == autorbuscar)
                    {
                        Console.WriteLine();
                        x.mostrarInformacion();
                        Console.WriteLine();
                    }
                    else
                    {
                        //Console.WriteLine("No existe el autor");
                    }
                });
            }*/
      /*      else
            {
                Console.WriteLine("No se han encontrado libros en la base de datos o no existe el autor");
            }

        }

        public void mostrarPeliculasGenero()
        {
            Console.Clear();
            /*  listaobras.ForEach(x =>
              {
                  if (x.GetType().Name == "PeliculaDTO")
                  {
                      Console.WriteLine();
                      inicializarlista();
                      x.mostrarInformacion();
                      Console.WriteLine();
                  }


              });*/
         /*   lPeliculaBD.ForEach(x =>
            {
                Console.WriteLine();
                inicializarlista();
                PeliculaDTO pelicula = Mapeo_Peliculas_PeliculasDTO(x);
                pelicula.mostrarInformacion();
                Console.WriteLine();

            });

            Console.Write($"Escriba el nombre del género que quieres buscar: ");
            string generobuscar = Console.ReadLine();

            if(lPeliculaBD.Count!=0 && generobuscar !=null && generobuscar != "")
            {
                Console.Clear();
                lPeliculaBD.ForEach(x =>
                {
                    if (x.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra == generobuscar)
                    {
                        Console.WriteLine();
                        PeliculaDTO pelicula = Mapeo_Peliculas_PeliculasDTO(x);
                        pelicula.mostrarInformacion();
                        Console.WriteLine();
                    }
                });
            }

         /*   if (listaobras.Count != 0 && generobuscar != null && generobuscar != ""  )
            {
                Console.Clear();
                listaobras.ForEach(x =>
                {
                    if (x.GetType().Name == "PeliculaDTO" && ((PeliculaDTO)x).genero == generobuscar)
                    {
                        Console.WriteLine();
                        x.mostrarInformacion();
                        Console.WriteLine();
                    }
                    else
                    {
                        //Console.WriteLine("No existe el género");
                    }
                });
            }*/
         /*   else
            {
                Console.WriteLine("No se han encontrado peliculas en la base de datos o no existe el género");
            }

        }

        public void mostrarComicAnyo()
        {
            Console.Clear();
            /* listaobras.ForEach(x =>
             {
                 if (x.GetType().Name == "ComicDTO")
                 {
                     Console.WriteLine();
                     inicializarlista();
                     x.mostrarInformacion();
                     Console.WriteLine();
                 }


             });*/

        /*    lComicsBD.ForEach(x =>
            {
                Console.WriteLine();
                inicializarlista();
                ComicDTO comic = Mapeo_Comics_ComicsDTO(x);
                comic.mostrarInformacion();
                Console.WriteLine();

            });


            Console.Write($"Escriba el número del año que quieres buscar: ");
           int anyobuscar =int.Parse(Console.ReadLine());

            if (lComicsBD.Count != 0 && anyobuscar != 0 )
            {
                Console.Clear();
                lComicsBD.ForEach(x =>
                {
                    if (x.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra == anyobuscar)
                    {
                        Console.WriteLine();
                        ComicDTO comic = Mapeo_Comics_ComicsDTO(x);
                        comic.mostrarInformacion();
                        Console.WriteLine();
                    }
                });
            }
            /* if (listaobras.Count != 0 && anyobuscar != 0)
             {

                 Console.Clear();
                 listaobras.ForEach(x =>
                 {
                     if (x.GetType().Name == "ComicDTO" && ((ComicDTO)x).anyo == anyobuscar)
                     {
                         Console.WriteLine();
                         inicializarlista();
                         x.mostrarInformacion();
                         Console.WriteLine();
                     }
                     else
                     {
                         //Console.WriteLine("El año no es valido");
                     }

                 });
             }*/
         /*   else
            {
                Console.WriteLine("No se ha encontrado comics en la base de datos o el año no es valido");
            }


        }

        public void mostrarSeriesGenero()
        {
            Console.Clear();
            /* listaobras.ForEach(x =>
             {
                 if (x.GetType().Name == "SerieTVDTO")
                 {
                     Console.WriteLine();
                     inicializarlista();
                     x.mostrarInformacion();
                     Console.WriteLine();
                 }

             });*/

          /*  lSerieBD.ForEach(x =>
            {
                Console.WriteLine();
                inicializarlista();
                SerieTVDTO serie = Mapeo_Series_SeriesDTO(x);
                serie.mostrarInformacion();
                Console.WriteLine();
            });
            Console.Write($"Escriba el nombre del género que quieres buscar: ");
            string generobuscar = Console.ReadLine();

            if(lSerieBD.Count!=0 && generobuscar!=null && generobuscar != "")
            {
                Console.Clear();
                lSerieBD.ForEach(x => 
                {
                    if (x.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra == generobuscar)
                    {
                        Console.WriteLine();
                        SerieTVDTO serie = Mapeo_Series_SeriesDTO(x);
                        serie.mostrarInformacion();
                        Console.WriteLine();
                    }
                });
            }

           /* if (listaobras.Count != 0 && generobuscar != null && generobuscar != "" )
            {
                Console.Clear();
                listaobras.ForEach(x =>
                {
                    if (x.GetType().Name == "SerieTVDTO" && ((SerieTVDTO)x).genero == generobuscar)
                    {
                        Console.WriteLine();
                        x.mostrarInformacion();
                        Console.WriteLine();
                    }
                    else
                    {
                        //Console.WriteLine("El género no existe");
                    }
                });
            }*/
         /*   else
            {
                Console.WriteLine("No se han encontrado series en la base de datos o no existe el género");
            }

        }
        public void mostrarComicEditora()
        {
            Console.Clear();
            /* listaobras.ForEach(x =>
             {
                 if (x.GetType().Name == "ComicDTO")
                 {
                     Console.WriteLine();
                     inicializarlista();
                     x.mostrarInformacion();
                     Console.WriteLine();
                 }


             });*/
         /*   lComicsBD.ForEach(x =>
            {
                Console.WriteLine();
                inicializarlista();
                ComicDTO comic = Mapeo_Comics_ComicsDTO(x);
                comic.mostrarInformacion();
                Console.WriteLine();
            });

            Console.Write($"Escriba el nombre de la editora que quieres buscar: ");
            string editorabuscar = Console.ReadLine();

            if (lComicsBD.Count != 0 && editorabuscar!=null && editorabuscar!="")
            {
                Console.Clear();
                lComicsBD.ForEach(x =>
                {
                    if (x.EditoraObra == editorabuscar)
                    {
                        Console.WriteLine();
                        ComicDTO comic = Mapeo_Comics_ComicsDTO(x);
                        comic.mostrarInformacion();
                        Console.WriteLine();
                    }
                });
            }
            /*   if (listaobras.Count != 0 && editorabuscar != null && editorabuscar != ""  )
               {
                   Console.Clear();

                   listaobras.ForEach(x =>
                   {
                       if (x.GetType().Name == "ComicDTO" && ((ComicDTO)x).editora == editorabuscar)
                       {
                           Console.WriteLine();
                           x.mostrarInformacion();
                           Console.WriteLine();
                       }
                       else
                       {
                           //Console.WriteLine("La editora no existe");
                       }

                   });
               }*/
          /*  else
            {
                Console.WriteLine("No se ha encontrado comics en la base de datos o la editora no existe");
            }

        }

        public void mostrarPeliculasDirector()
        {
            Console.Clear();
            /* listaobras.ForEach(x =>
             {
                 if (x.GetType().Name == "PeliculaDTO")
                 {
                     Console.WriteLine();
                     inicializarlista();
                     x.mostrarInformacion();
                     Console.WriteLine();
                 }

             });*/

          /*  lPeliculaBD.ForEach(x =>
            {
                Console.WriteLine();
                inicializarlista();
                PeliculaDTO pelicula = Mapeo_Peliculas_PeliculasDTO(x);
                pelicula.mostrarInformacion();
                Console.WriteLine();
            });

            Console.Write("Escriba el nombre del director que quieres buscar: ");
            string directorbuscar = Console.ReadLine();

            if(lPeliculaBD.Count!=0 && directorbuscar != null && directorbuscar!= "")
            {
                Console.Clear();

                lPeliculaBD.ForEach(x =>
                {
                    if (x.ObraDeVideoBiblioteca.DirectorObra == directorbuscar)
                    {
                        Console.WriteLine();
                        PeliculaDTO pelicula = Mapeo_Peliculas_PeliculasDTO(x);
                        pelicula.mostrarInformacion();
                        Console.WriteLine();
                    }
                });
            }
         /*   if (listaobras.Count != 0 && directorbuscar != null && directorbuscar != "" )
            {
                Console.Clear();

                listaobras.ForEach(x =>
                {
                    if (x.GetType().Name == "PeliculaDTO" && ((PeliculaDTO)x).director == directorbuscar)
                    {
                        Console.WriteLine();
                        x.mostrarInformacion();
                        Console.WriteLine();
                    }
                    else
                    {
                       //Console.WriteLine("El director no existe");

                    }
                            
                });
            }*/
         /*   else
            {
                Console.WriteLine("No se ha encontrado peliculas en la base de datos o el director no existe");
            }

        }

        public void mostrarSeriesTV()
        {
           // List<ObraCulturalDTO> listaSeries = listaobras.Where(x => x.ToString().Contains("SerieTVDTO")).ToList();

            /*  if (listaSeries.Count != 0)
              {
                  Console.Clear();

                  foreach (SerieTVDTO serie in listaSeries)
                  {
                      Console.WriteLine();
                      inicializarlista();
                      serie.mostrarInformacion();
                      Console.WriteLine();
                  }
              }*/
        /*    if (lSerieBD.Count != 0)
            {
                Console.Clear();

                foreach(SerieTVBiblioteca seriebd in lSerieBD)
                {
                    Console.WriteLine();
                    inicializarlista();
                    SerieTVDTO serie = Mapeo_Series_SeriesDTO(seriebd);
                    serie.mostrarInformacion();
                }

            }
            else
            {
                Console.WriteLine("No hay elementos en la lista");
            }


        }

        public ObraCulturalDTO buscarporcodigo()
        {
            int codigoobra = 0;
            Console.Write("Escribe el código de la obra que quieres buscar: ");
            string codigoleidodelusuarioabuscar = Console.ReadLine();
            int.TryParse(codigoleidodelusuarioabuscar, out codigoobra);
            ObraCulturalDTO obraencontrada = listaobras.Find(x => x.codigoobra == codigoobra);
        
            if (obraencontrada == null)
            {
                Console.WriteLine("El código no ha sido encontrado");
            }
            return obraencontrada;
        }

    /*    public ObraCulturalBiblioteca buscarporcodigoBD()
        {
            int codigoobra = 0;
            Console.Write("Escribe el código de la obra que quieres buscar: ");
            string codigoleidodelusuarioabuscar = Console.ReadLine();
            int.TryParse(codigoleidodelusuarioabuscar, out codigoobra);
            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(codigoobra);

            if (obraEncontradaBD == null)
            {
                Console.WriteLine("El código no ha sido encontrado");
            }
            return obraEncontradaBD;
        }*/

      /*  public void alquilarObra()
        {
            Console.Clear();
             listaobras.ForEach(x =>
              {
                  if (x.alquilado == false)
                  {

                      Console.WriteLine();
                      x.mostrarInformacion();
                      Console.WriteLine();
                  }


              });

            ObraCulturalDTO obraencontrada = buscarporcodigo();
           // ObraCulturalBiblioteca obraencontradaBD = buscarporcodigoBD();
                        
            if (obraencontrada != null)
            {
                if (obraencontrada.alquilado != true)
                {
                    Console.Write("Desea alquilar esta obra (s/n): ");
                    string alquilar = Console.ReadLine();
                    if (alquilar.ToLower() == "s")
                    {
                        if (obraencontrada.GetType().Name == "LibroDTO")
                        {
                            LibroDTO libro = (LibroDTO)obraencontrada;
                            obraencontrada.alquilado = true;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                            LibroBiblioteca librobd = Mapeo_LibrosDTO_Libros(libro);
                            obraEncontradaBD.IdObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().AutorObra = librobd.ObraLiterariaBiblioteca.AutorObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().LibroBiblioteca.First().PaginasObra = librobd.PaginasObra;
                            
                            obraEncontradaBD.AlquiladoObra = true;

                            accesoaBDBiblioteca.SaveChanges();

                        }

                        if (obraencontrada.GetType().Name == "ComicDTO")
                        {
                            ComicDTO comic = (ComicDTO)obraencontrada;
                            obraencontrada.alquilado = true;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                            ComicBiblioteca comicbd = Mapeo_ComicsDTO_Comics(comic);
                            obraEncontradaBD.IdObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().AutorObra = comicbd.ObraLiterariaBiblioteca.AutorObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().EditoraObra = comicbd.EditoraObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().NumeroVolumenesObra = comicbd.NumeroVolumenesObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().CapitulosObra = comicbd.CapitulosObra;

                            obraEncontradaBD.AlquiladoObra = true;
                           
                            accesoaBDBiblioteca.SaveChanges();

                        }


                        if (obraencontrada.GetType().Name == "PeliculaDTO")
                        {
                            PeliculaDTO pelicula = (PeliculaDTO)obraencontrada;
                            obraencontrada.alquilado = true;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                            PeliculaBiblioteca peliculabd = Mapeo_PeliculasDTO_Peliculas(pelicula);
                            obraEncontradaBD.IdObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = peliculabd.ObraDeVideoBiblioteca.DirectorObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = peliculabd.ObraDeVideoBiblioteca.RepartoObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().DuracionObra = peliculabd.DuracionObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().ProductoraObra = peliculabd.ProductoraObra;
                            obraEncontradaBD.AlquiladoObra = true;

                            accesoaBDBiblioteca.SaveChanges();

                        }
                        if (obraencontrada.GetType().Name == "SerieTVDTO")
                        {
                            SerieTVDTO serie = (SerieTVDTO)obraencontrada;
                            obraencontrada.alquilado = true;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);
                            SerieTVBiblioteca seriebd = Mapeo_SerieTVDTO_Series(serie);
                            obraEncontradaBD.IdObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = seriebd.ObraDeVideoBiblioteca.DirectorObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = seriebd.ObraDeVideoBiblioteca.RepartoObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().TemporadasObra = seriebd.TemporadasObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CapitulosObra = seriebd.CapitulosObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CanalObra = seriebd.CanalObra;
                            obraEncontradaBD.AlquiladoObra = true;
                            

                            accesoaBDBiblioteca.SaveChanges();

                        }


                        Console.WriteLine("Se ha alquilado una obra");
                    }
                    else
                    {

                    }

                }
                else
                {
                    Console.WriteLine("No se puede alquilar la obra. Ya está alquilada.");
                }
            }
        }

        public void devolverObra()
        {
            Console.Clear();
            listaobras.ForEach(x =>
            {
                if (x.alquilado == true)
                {                 
                    Console.WriteLine();
                    x.mostrarInformacion();
                    Console.WriteLine();
                }


            });
            ObraCulturalDTO obraencontrada = buscarporcodigo();
         //   ObraCulturalBiblioteca obraencontradaBD = buscarporcodigoBD();
            if (obraencontrada != null)
            {
                if (obraencontrada.alquilado != false)
                {
                    Console.Write("Desea devolver esta obra (s/n): ");
                    string devolver = Console.ReadLine();
                    if (devolver.ToLower() == "s")
                    {
                        if (obraencontrada.GetType().Name == "LibroDTO")
                        {
                            LibroDTO libro = (LibroDTO)obraencontrada;
                            obraencontrada.alquilado = false;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                            LibroBiblioteca librobd = Mapeo_LibrosDTO_Libros(libro);
                            obraEncontradaBD.IdObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().AutorObra = librobd.ObraLiterariaBiblioteca.AutorObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().LibroBiblioteca.First().PaginasObra = librobd.PaginasObra;

                            obraEncontradaBD.AlquiladoObra = false;

                            accesoaBDBiblioteca.SaveChanges();

                        }
                        if (obraencontrada.GetType().Name == "ComicDTO")
                        {
                            ComicDTO comic = (ComicDTO)obraencontrada;
                            obraencontrada.alquilado = false;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                            ComicBiblioteca comicbd = Mapeo_ComicsDTO_Comics(comic);
                            obraEncontradaBD.IdObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().AutorObra = comicbd.ObraLiterariaBiblioteca.AutorObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().EditoraObra = comicbd.EditoraObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().NumeroVolumenesObra = comicbd.NumeroVolumenesObra;
                            obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().CapitulosObra = comicbd.CapitulosObra;

                            obraEncontradaBD.AlquiladoObra = false;

                            accesoaBDBiblioteca.SaveChanges();

                        }


                        if (obraencontrada.GetType().Name == "PeliculaDTO")
                        {
                            PeliculaDTO pelicula = (PeliculaDTO)obraencontrada;
                            obraencontrada.alquilado = false;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                            PeliculaBiblioteca peliculabd = Mapeo_PeliculasDTO_Peliculas(pelicula);
                            obraEncontradaBD.IdObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = peliculabd.ObraDeVideoBiblioteca.DirectorObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = peliculabd.ObraDeVideoBiblioteca.RepartoObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().DuracionObra = peliculabd.DuracionObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().ProductoraObra = peliculabd.ProductoraObra;
                            obraEncontradaBD.AlquiladoObra = false;

                            accesoaBDBiblioteca.SaveChanges();

                        }
                        if (obraencontrada.GetType().Name == "SerieTVDTO")
                        {
                            SerieTVDTO serie = (SerieTVDTO)obraencontrada;
                            obraencontrada.alquilado = false;

                            ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);
                            SerieTVBiblioteca seriebd = Mapeo_SerieTVDTO_Series(serie);
                            obraEncontradaBD.IdObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                            obraEncontradaBD.TituloObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                            obraEncontradaBD.AnyoObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                            obraEncontradaBD.GeneroObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = seriebd.ObraDeVideoBiblioteca.DirectorObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = seriebd.ObraDeVideoBiblioteca.RepartoObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().TemporadasObra = seriebd.TemporadasObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CapitulosObra = seriebd.CapitulosObra;
                            obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CanalObra = seriebd.CanalObra;
                            obraEncontradaBD.AlquiladoObra = false;


                            accesoaBDBiblioteca.SaveChanges();

                        }

                        /*    BibliotecaEntities accesoBD = new BibliotecaEntities();
                            ObraCulturalBiblioteca obraaeliminar = accesoBD.ObraCulturalBiblioteca.FirstOrDefault(x => x.TituloObra == obraencontrada.titulo);
                           obraaeliminar.TituloObra = obraencontrada.titulo;
                            accesoBD.SaveChanges();*/
                /*        Console.WriteLine("Se ha devuelto una obra");

                    }
                    else
                    {

                    }
                }
                else
                {
                    Console.WriteLine("No se puede devolver la obra. Ya no está alquilada.");
                }
            }

        }

        public void borrarObra()
        {
            Console.Clear();
            listaobras.ForEach(x =>
            {
              
                Console.WriteLine();
                x.mostrarInformacion();
                    Console.WriteLine();
                


            });
            if (listaobras.Count == 0)
            {
                Console.WriteLine("Error no hay obras para borrar desde la base de datos");
            }
           ObraCulturalDTO obraencontrada = buscarporcodigo();
         //   ObraCulturalBiblioteca obraencontradaBD = buscarporcodigoBD();
            if (obraencontrada != null)
            {
                Console.Write("Desea borrar esta obra (s/n): ");
                string borrar = Console.ReadLine();
                if (borrar.ToLower() == "s")
                {
                    //borrarelemento();
                    if (obraencontrada.GetType().Name == "LibroDTO")
                    {
                        LibroDTO libro = (LibroDTO)obraencontrada;

                        ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                        LibroBiblioteca librobd = Mapeo_LibrosDTO_Libros(libro);
                        obraEncontradaBD.IdObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                        obraEncontradaBD.TituloObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                        obraEncontradaBD.AnyoObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                        obraEncontradaBD.GeneroObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                        obraEncontradaBD.ObraLiterariaBiblioteca.First().AutorObra = librobd.ObraLiterariaBiblioteca.AutorObra;
                        obraEncontradaBD.ObraLiterariaBiblioteca.First().LibroBiblioteca.First().PaginasObra = librobd.PaginasObra;
                        accesoaBDBiblioteca.LibroBiblioteca.Remove(obraEncontradaBD.ObraLiterariaBiblioteca.First().LibroBiblioteca.First());
                        accesoaBDBiblioteca.ObraLiterariaBiblioteca.Remove(obraEncontradaBD.ObraLiterariaBiblioteca.First());
                        accesoaBDBiblioteca.ObraCulturalBiblioteca.Remove(obraEncontradaBD);
                        
                        accesoaBDBiblioteca.SaveChanges();

                    }

                    if (obraencontrada.GetType().Name == "ComicDTO")
                    {
                        ComicDTO comic = (ComicDTO)obraencontrada;

                        ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                        ComicBiblioteca comicbd = Mapeo_ComicsDTO_Comics(comic);
                        obraEncontradaBD.IdObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                        obraEncontradaBD.TituloObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                        obraEncontradaBD.AnyoObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                        obraEncontradaBD.GeneroObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                        obraEncontradaBD.ObraLiterariaBiblioteca.First().AutorObra = comicbd.ObraLiterariaBiblioteca.AutorObra;
                        obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().EditoraObra = comicbd.EditoraObra;
                        obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().NumeroVolumenesObra = comicbd.NumeroVolumenesObra;
                        obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().CapitulosObra = comicbd.CapitulosObra;
                        accesoaBDBiblioteca.ComicBiblioteca.Remove(obraEncontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First());
                        accesoaBDBiblioteca.ObraLiterariaBiblioteca.Remove(obraEncontradaBD.ObraLiterariaBiblioteca.First());
                        accesoaBDBiblioteca.ObraCulturalBiblioteca.Remove(obraEncontradaBD);

                        accesoaBDBiblioteca.SaveChanges();

                    }

                    if (obraencontrada.GetType().Name == "PeliculaDTO")
                    {
                        PeliculaDTO pelicula = (PeliculaDTO)obraencontrada;

                        ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                        PeliculaBiblioteca peliculabd = Mapeo_PeliculasDTO_Peliculas(pelicula);
                        obraEncontradaBD.IdObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                        obraEncontradaBD.TituloObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                        obraEncontradaBD.AnyoObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                        obraEncontradaBD.GeneroObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = peliculabd.ObraDeVideoBiblioteca.DirectorObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = peliculabd.ObraDeVideoBiblioteca.RepartoObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().DuracionObra = peliculabd.DuracionObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().ProductoraObra = peliculabd.ProductoraObra;
                        accesoaBDBiblioteca.PeliculaBiblioteca.Remove(obraEncontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First());
                        accesoaBDBiblioteca.ObraDeVideoBiblioteca.Remove(obraEncontradaBD.ObraDeVideoBiblioteca.First());
                        accesoaBDBiblioteca.ObraCulturalBiblioteca.Remove(obraEncontradaBD);

                        accesoaBDBiblioteca.SaveChanges();

                    }

                    if (obraencontrada.GetType().Name == "SerieTVDTO")
                    {
                        SerieTVDTO serie = (SerieTVDTO)obraencontrada;

                        ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);
                        SerieTVBiblioteca seriebd = Mapeo_SerieTVDTO_Series(serie);
                        obraEncontradaBD.IdObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                        obraEncontradaBD.TituloObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                        obraEncontradaBD.AnyoObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                        obraEncontradaBD.GeneroObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = seriebd.ObraDeVideoBiblioteca.DirectorObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = seriebd.ObraDeVideoBiblioteca.RepartoObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().TemporadasObra = seriebd.TemporadasObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CapitulosObra = seriebd.CapitulosObra;
                        obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CanalObra = seriebd.CanalObra;
                        accesoaBDBiblioteca.SerieTVBiblioteca.Remove(obraEncontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First());
                        accesoaBDBiblioteca.ObraDeVideoBiblioteca.Remove(obraEncontradaBD.ObraDeVideoBiblioteca.First());
                        accesoaBDBiblioteca.ObraCulturalBiblioteca.Remove(obraEncontradaBD);

                        accesoaBDBiblioteca.SaveChanges();

                    }
                        Console.WriteLine("La obra ha sido borrada satisfactoriamente desde la base de datos");               
                }
                else
                {

                }
            }
        }

        public void editarObra()
        {
            Console.Clear();
            listaobras.ForEach(x =>
            {
               
                Console.WriteLine();
                x.mostrarInformacion();
                Console.WriteLine();

            });
            if (listaobras.Count == 0)
            {
                Console.WriteLine("No hay obras para modificar desde la base de datos");
            }
            ObraCulturalDTO obraencontrada = buscarporcodigo();
    //     ObraCulturalBiblioteca obraencontradabd=buscarporcodigoBD();
            if (obraencontrada != null)
            {

                if (obraencontrada.GetType().Name == "LibroDTO")
                {
                            
                    LibroDTO libro = (LibroDTO)obraencontrada;
                    ObraCulturalBiblioteca obraEncontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                    libro.editarInformacionLibro();
                    
                    LibroBiblioteca librobd=Mapeo_LibrosDTO_Libros(libro);
                    obraEncontradaBD.IdObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                    obraEncontradaBD.TituloObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                    obraEncontradaBD.AnyoObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                    obraEncontradaBD.GeneroObra = librobd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                    obraEncontradaBD.ObraLiterariaBiblioteca.First().AutorObra = librobd.ObraLiterariaBiblioteca.AutorObra;
                    obraEncontradaBD.ObraLiterariaBiblioteca.First().LibroBiblioteca.First().PaginasObra = librobd.PaginasObra;
                                                               
                    accesoaBDBiblioteca.SaveChanges();
                                                     
                }

                if (obraencontrada.GetType().Name == "ComicDTO")
                {
                    ComicDTO comic = (ComicDTO)obraencontrada;
                    ObraCulturalBiblioteca obraencontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                    comic.editarInformacionComic();
                    ComicBiblioteca comicbd = Mapeo_ComicsDTO_Comics(comic);
                    obraencontradaBD.IdObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.IdObra;
                    obraencontradaBD.TituloObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.TituloObra;
                    obraencontradaBD.AnyoObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                    obraencontradaBD.GeneroObra = comicbd.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                    obraencontradaBD.ObraLiterariaBiblioteca.First().AutorObra = comicbd.ObraLiterariaBiblioteca.AutorObra;
                    obraencontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().EditoraObra = comicbd.EditoraObra;
                    obraencontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().NumeroVolumenesObra = comicbd.NumeroVolumenesObra;
                    obraencontradaBD.ObraLiterariaBiblioteca.First().ComicBiblioteca.First().CapitulosObra = comicbd.CapitulosObra;

                    accesoaBDBiblioteca.SaveChanges();

                }

                if (obraencontrada.GetType().Name == "PeliculaDTO")
                {
                    PeliculaDTO pelicula = (PeliculaDTO)obraencontrada;
                    ObraCulturalBiblioteca obraencontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);

                    pelicula.editarInformacionPelicula();
                    PeliculaBiblioteca peliculabd = Mapeo_PeliculasDTO_Peliculas(pelicula);
                    obraencontradaBD.IdObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                    obraencontradaBD.TituloObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                    obraencontradaBD.AnyoObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                    obraencontradaBD.GeneroObra = peliculabd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = peliculabd.ObraDeVideoBiblioteca.DirectorObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = peliculabd.ObraDeVideoBiblioteca.RepartoObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().DuracionObra = peliculabd.DuracionObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First().ProductoraObra = peliculabd.ProductoraObra;

                    accesoaBDBiblioteca.SaveChanges();


                }

                if (obraencontrada.GetType().Name == "SerieTVDTO")
                {
                    SerieTVDTO serie = (SerieTVDTO)obraencontrada;
                    ObraCulturalBiblioteca obraencontradaBD = accesoaBDBiblioteca.ObraCulturalBiblioteca.Find(obraencontrada.codigoobra);
                    serie.editarInformacionSerie();
                    SerieTVBiblioteca seriebd = Mapeo_SerieTVDTO_Series(serie);
                    obraencontradaBD.IdObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.IdObra;
                    obraencontradaBD.TituloObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.TituloObra;
                    obraencontradaBD.AnyoObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.AnyoObra;
                    obraencontradaBD.GeneroObra = seriebd.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().DirectorObra = seriebd.ObraDeVideoBiblioteca.DirectorObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().RepartoObra = seriebd.ObraDeVideoBiblioteca.RepartoObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().TemporadasObra = seriebd.TemporadasObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CapitulosObra = seriebd.CapitulosObra;
                    obraencontradaBD.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First().CanalObra = seriebd.CanalObra;

                    accesoaBDBiblioteca.SaveChanges();

                }
                if (obraencontrada.editado == true)
                {
                    Console.WriteLine("Se ha editado la obra en la base de datos");
                }
                if (obraencontrada.editado == false)
                {
                    Console.WriteLine("No se ha editado la obra en la base de datos");
                }
              
            
            }
           

        }

        public void gestionLibros()
        {
            string opcion = "";

            do
            {
                Console.WriteLine(FiggleFonts.Banner3D.Render("Libros"));
                opcion = menu2();
                switch (opcion)
                {

                    case "1":
                        insertarLibros();

                        Console.WriteLine();
                        break;

                    case "2":
                        mostrarLibros();

                        Console.WriteLine();
                        break;
                    case "3":
                        mostrarLibrosAutor();

                        Console.WriteLine();
                        break;

                    case "4":

                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Error en la opción introducida");
                        break;

                }
                if (opcion != "4")
                {
                    salir();
                }
            } while (opcion != "4" && terminar == false);

        }

        public void gestionComic()
        {
            string opcion = "";

            do
            {
                Console.WriteLine(FiggleFonts.Basic.Render("Comics"));
                opcion = menu3();
                switch (opcion)
                {

                    case "1":
                        insertarComic();

                        Console.WriteLine();
                        break;

                    case "2":
                        mostrarComicAnyo();

                        Console.WriteLine();
                        break;
                    case "3":
                        mostrarComicEditora();

                        Console.WriteLine();
                        break;

                    case "4":

                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Error en la opción introducida");
                        break;

                }
                if (opcion != "4")
                {
                    salir();
                }

            } while (opcion != "4" && terminar == false);
        }

        public void gestionPelicula()
        {
            string opcion = "";

            do
            {
                Console.WriteLine(FiggleFonts.Trek.Render("Peliculas"));
                opcion = menu4();
                switch (opcion)
                {

                    case "1":
                        insertarPelicula();

                        Console.WriteLine();
                        break;

                    case "2":
                        mostrarPeliculasGenero();

                        Console.WriteLine();
                        break;
                    case "3":
                        mostrarPeliculasDirector();

                        Console.WriteLine();
                        break;

                    case "4":

                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Error en la opción introducida");
                        break;

                }
                if (opcion != "4")
                {
                    salir();
                }
            } while (opcion != "4" && terminar == false);
        }

        public void gestionSeries()
        {
            string opcion = "";

            do
            {
                Console.WriteLine(FiggleFonts.Colossal.Render("Series"));

                opcion = menu5();
                switch (opcion)
                {

                    case "1":
                        insertarSerie();

                        Console.WriteLine();
                        break;

                    case "2":
                        mostrarSeriesGenero();

                        Console.WriteLine();
                        break;
                    case "3":
                        mostrarSeriesTV();

                        Console.WriteLine();
                        break;

                    case "4":

                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Error en la opción introducida");
                        break;

                }
                if (opcion != "4")
                {
                    salir();
                }

            } while (opcion != "4" && terminar == false);
        }




        public void ejecutar()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string opcion = "";

            creardatosIniciales();
            terminar = false;

            System.Console.ForegroundColor = ConsoleColor.Yellow;

         /*   var audioFile = new AudioFileReader("");
            var outputDevice = new WaveOutEvent();
            
          outputDevice.Init(audioFile);
          outputDevice.Play();*/
           /*while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }*/
            

        /*    do
            {

                inicializarlista();
                Console.WriteLine(FiggleFonts.Univers.Render("Biblioteca"));


                opcion = menu();

                switch (opcion)
                {
                    case "1":
                        System.Console.Clear();

                    

                        gestionLibros();

                        Console.WriteLine();
                        break;
                    case "2":
                        System.Console.Clear();

                 

                        gestionComic();

                        Console.WriteLine();
                        break;
                    case "3":
                        System.Console.Clear();

                  

                        gestionPelicula();

                        Console.WriteLine();
                        break;

                    case "4":
                        System.Console.Clear();

                      
                        gestionSeries();

                        Console.WriteLine();
                        break;

                    case "5":
                        alquilarObra();

                        Console.WriteLine();
                        break;

                    case "6":
                        devolverObra();

                        Console.WriteLine();
                        break;

                    case "7":
                        borrarObra();

                        Console.WriteLine();
                        break;

                    case "8":
                        editarObra();

                        Console.WriteLine();
                        break;

                    case "9":

                        Console.WriteLine();
                        break;


                    default:
                        Console.WriteLine("Error en la opción introducida");
                        break;
                }

                if (opcion != "9")
                {
                    salir();

                }
            } while (opcion != "9" && terminar == false);

            System.Console.WriteLine();


            Console.WriteLine("(Fin del programa. Pulse cualquier tecla para cerrar la consola)");
            Console.ReadKey();

        }*/
    }
}
