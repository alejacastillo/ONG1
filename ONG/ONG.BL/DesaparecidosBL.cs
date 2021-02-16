using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.BL
{
    public class DesaparecidosBL
    {
            Contexto _contexto;

        public List<Desaparecidos> listaDesaparecidos { get; set; }

    public DesaparecidosBL()
        {
            _contexto = new Contexto();
            listaDesaparecidos = new List<Desaparecidos>();
        }
      
        public List<Desaparecidos> ObtenerDesaparecidos()
        {
            listaDesaparecidos = _contexto.Desaparecido.ToList();
          

            return listaDesaparecidos;
          }
    }
}
