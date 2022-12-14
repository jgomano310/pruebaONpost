using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pruebaONpost.Modelo;

namespace pruebaONpost.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string name { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPostSubmit(Persona persona)
        {

            this.name = string.Format("nombre: " + persona.nombre + " " + persona.apellidos);

        }
    }
}