using System;
namespace veterinaria.App.Dominio;
public class Historial
{
    public LinkedList<Visita> visitas { get; set; }
    public DateTime feacha_creacion { get; set; }

}