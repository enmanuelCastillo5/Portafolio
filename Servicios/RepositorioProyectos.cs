using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "web develoment",
                Descripcion = "desarrollo de entornos web",
                Link = "www.google.com",
                ImageURL = "imagenes/node.png"
            },
            new Proyecto
                {
                    Titulo = "web develoment",
                    Descripcion = "desarrollo de entornos web",
                    Link = "www.google.com",
                    ImageURL = "/imagenes/asp.png"
                },
            new Proyecto
                {
                    Titulo = "web develoment",
                    Descripcion = "desarrollo de entornos web",
                    Link = "www.google.com",
                    ImageURL = "/imagenes/rails.png"
                },
            new Proyecto
                {
                    Titulo = "web develoment",
                    Descripcion = "desarrollo de entornos web",
                    Link = "www.google.com",
                    ImageURL = "/imagenes/react.svg"
            }
        };
        }
    }
}
