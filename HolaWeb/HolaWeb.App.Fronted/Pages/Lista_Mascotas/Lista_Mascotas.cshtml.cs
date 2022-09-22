using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWeb.App.Fronted.Pages
{
    public class Lista_MascotasModel : PageModel
    {
        private string[] Mascotas={"sasha","olo","bruno dias","firulais"};
        public List<string> Listamascotas{get;set;}
        public void OnGet()
        {
        }
    }
}
