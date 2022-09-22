using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWeb.App.Fronted.Pages
{
    public class Lista_MascotasModel : PageModel
    {
        private string[] Mascotas={"sasha","bruno","firulais"};
        public List<string> ListaMascotas{get;set;}
        public void OnGet()
        {
            ListaMascotas= new List<string>();
            ListaMascotas.AddRange(Mascotas);
        }
    }
}
