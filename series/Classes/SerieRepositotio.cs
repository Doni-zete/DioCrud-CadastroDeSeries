using System;
using System.Collections.Generic;
using series.Interfaces;


namespace series
{
  public class SerieRepositotio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();
    public void Atualiza(int id, Serie objeto)
    {
      listaSerie[id] = objeto;
    }

    public void Exclui(int id)
    {
      listaSerie[id].Excluir();
      //
    }
    public void Isere(Serie objeto)
    {
      listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      return listaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
      return listaSerie[id];
    }
  }
}