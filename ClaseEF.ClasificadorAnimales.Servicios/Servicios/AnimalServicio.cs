using ClaseEF.ClasificadorAnimales.Data.EF;
using ClaseEF.ClasificadorAnimales.Data.Repositorios;
using ClaseEF.ClasificadorAnimales.Servicios.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEF.ClasificadorAnimales.Servicios.Servicios
{
    public class AnimalServicio : IAnimalServicio
    {
        IAnimalRepositorio _animalRepositorio;

        public AnimalServicio(IAnimalRepositorio animalRepositorio)
        {
            _animalRepositorio = animalRepositorio;
        }
               

        public void Insertar(Animal entidad)
        {
            _animalRepositorio.Insertar(entidad);
            _animalRepositorio.SaveChanges();
        }

        public Animal ObtenerAnimalPorId(int id)
        {
            return _animalRepositorio.ObtenerAnimalPorId(id);
        }

        public void borrar(int idAnimal)
        {
            Animal animal = _animalRepositorio.ObtenerAnimalPorId(idAnimal);
            if(animal == null)
                throw new ArgumentException("No se puede borrar el local, ya que no se encuentra disponible.");

            _animalRepositorio.Borrar(animal);
            _animalRepositorio.SaveChanges();
        }

        public List<Animal> ObtenerPorTipo(int idTipoAnimal)
        {
            return _animalRepositorio.ObtenerPorTipo(idTipoAnimal);
        }

        public List<Animal> ObtenerTodos()
        {
            return _animalRepositorio.ObtenerTodos();
        }
    }
}
