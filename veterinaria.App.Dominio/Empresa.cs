using System.Collections.Generic;
using System;

namespace veterinaria.App.Dominio
{
    public class Empresa
    {   

        private string IdEmpresa {get;set;}
        private LinkedList<Veterinario> veterinarios { get; set; }

        private LinkedList<Cliente> clientes { get; set; }

        

    }

}