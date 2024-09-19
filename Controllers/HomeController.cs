using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
