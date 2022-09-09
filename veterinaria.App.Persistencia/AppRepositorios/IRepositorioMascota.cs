using System.Collections.Generic;
using veterinaria.App.Dominio;


namespace veterinaria.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascota();

        Mascota AddMascota(Mascota mascota);

        Mascota UpdateMascota(Mascota mascota);

        Void DeleteMascota(string NombreMascota);

        Mascota GetMascota(string NombreMascota);
    }
}