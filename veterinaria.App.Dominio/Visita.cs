using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria.App.Dominio
{
    public class Visita
    {
        private float temperatura {get; set;}

        private float peso {get; set;}
        private int frecuenciaRespratoria {get; set;}
        private int frecuenciaCardiaca {get; set;}
        private String estadoDeAnimo {get; set;}
        private DateTime fechaVisita {get; set;}
        private Veterinario veterinario {get; set;}
        private LinkedList< Recomendacion > recomendaiones {get; set;}

      
    }
}