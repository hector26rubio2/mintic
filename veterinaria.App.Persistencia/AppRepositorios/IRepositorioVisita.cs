using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria.App.Persistencia
{
    public interface IRepositorioVsitia
    {
          Visita AddVisita(Visita visita);
        void DeleteVisita(string codigo);
        IEnumerable<Visita> GetAllVisita();

        Visita GetVisita(string codigo);
        Visita UpdateVisita(Visita visita);
    }
}