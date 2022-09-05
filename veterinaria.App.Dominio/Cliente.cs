using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria.App.Dominio
{
    public class Cliente
    {
        private LinkedList<Mascota> Mascotas { get; set; }
        private string Correo { get; set; }
    }
}