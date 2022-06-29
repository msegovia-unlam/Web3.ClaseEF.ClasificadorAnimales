using ClaseEF.ClasificadorAnimales.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEF.ClasificadorAnimales.Data.Repositorios
{
    public class AnimalRepositorio : BaseRepositorio, IAnimalRepositorio
    {
        public AnimalRepositorio(_20221CPracticaEFContext ctx) : base(ctx)
        {

        }


        public void Insertar(Animal entidad)
        {
            _contexto.Animals.Add(entidad);
        }

        public List<Animal> ObtenerPorTipo(int idTipoAnimal)
        {
            return _contexto.Animals.Include(o=> o.IdTipoAnimalNavigation)
                .Where(o=>o.IdTipoAnimal == idTipoAnimal).ToList();

        }

        public List<Animal> ObtenerTodos()
        {
            return _contexto.Animals.Include(o=> o.IdTipoAnimalNavigation).ToList();
        }

        public Animal ObtenerAnimalPorId(int id)
        {
            return _contexto.Animals.Find(id);
        }

        public void Borrar(Animal animal)
        {
            _contexto.Animals.Remove(animal);
        }
    }
}
