using System.Collections.Generic;

namespace veterinaria.App.Persistence.AppRepositorios
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinario();

        Veterinario AddVeterinario(Veterinario veterinario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
    void DeleteVeterinario(int idVeterinario);
        Usuario GetVeterinario(int idVeterinario);

    }

}