using System.Collections.Generic;
using veterinaria.App.Dominio;


namespace veterinaria.App.Persistencia
{
    public interface IRepositorioRecomendacion
    {
        Recomendacion AddRecomendacion(Recomendacion recomendacion);
        void DeleteRecomendacion(string codigo);
        IEnumerable<Recomendacion> GetAllRecomendacion();

        Recomendacion GetRecomendacion(string codigo);
        Recomendacion UpdateRecomendacion(Recomendacion recomendacion);
    }

}