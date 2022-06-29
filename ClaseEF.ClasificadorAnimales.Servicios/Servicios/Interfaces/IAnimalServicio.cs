using ClaseEF.ClasificadorAnimales.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEF.ClasificadorAnimales.Servicios.Servicios.Interfaces
{
    public interface IAnimalServicio
    {
        public void Insertar(Animal entidad);

        public List<Animal> ObtenerPorTipo(int idTipoAnimal);


        public List<Animal> ObtenerTodos();

        public Animal ObtenerAnimalPorId(int id);

        public void borrar(int idAnimal);
    }
}
