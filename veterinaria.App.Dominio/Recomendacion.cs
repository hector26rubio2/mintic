using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria.App.Dominio
{
    public class Recomendacion
    {   
        
                private string codigo {get;set;}
                private Veterinario Veterinario {get; set;}
                private string NotasRecomendacion {get;set;}
                private LinkedList<string> Medicamentos {get;set;}
        
    }
}