using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria.App.Dominio
{
    public class Visita
    {
           private string cogido {get;set;}
        private float Temperatura { get; set; }

        private float Peso { get; set; }
        private int FrecuenciaRespratoria { get; set; }
        private int FrecuenciaCardiaca { get; set; }
        private String EstadoDeAnimo { get; set; }
        private DateTime FechaVisita { get; set; }
        private Veterinario Veterinario { get; set; }
        private LinkedList<Recomendacion> Recomendaiones { get; set; }


    }
}