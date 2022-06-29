using ClaseEF.ClasificadorAnimales.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEF.ClasificadorAnimales.Data.Repositorios
{
    public abstract class BaseRepositorio
    {
        public _20221CPracticaEFContext _contexto { get; set; }

        public BaseRepositorio(_20221CPracticaEFContext ctx)
        {
            _contexto = ctx;
        }

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }
    }
}
