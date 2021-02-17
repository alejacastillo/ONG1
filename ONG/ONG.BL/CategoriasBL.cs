using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONG.BL
{
    public class CategoriasBL
    {
        Contexto _contexto;
        public List<Categorias>ListadeCategorias { get; set; }

        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListadeCategorias = new List<Categorias>();
        }




        public List<Categorias> ObtenerCategorias()
        {
            ListadeCategorias = _contexto.Categorias.ToList();
                return ListadeCategorias;
        }


        public void GuardarCategoria(Categorias Categorias)
        {
            if (Categorias.Id == 0)
            {
                _contexto.Categorias.Add(Categorias);

            }
            else
            {
                var CategoriaExistente = _contexto.Categorias.Find(Categorias.Id);
                CategoriaExistente.Evento = Categorias.Evento;

            }

            _contexto.SaveChanges();
        }

        public Categorias ObtenerCategorias(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            return categoria;
        }


        public void EliminarCategoria(int id)
        {
            var Categoria = _contexto.Categorias.Find(id);

            _contexto.Categorias.Remove(Categoria);
            _contexto.SaveChanges();
        }


    }

}
