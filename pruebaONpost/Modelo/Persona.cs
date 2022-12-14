using Microsoft.AspNetCore.Mvc;

namespace pruebaONpost.Modelo
{
    public class Persona
    {

        [BindProperty]
        public string nombre { get; set; }

        [BindProperty]
        public string apellidos { get; set; }
    }
}
