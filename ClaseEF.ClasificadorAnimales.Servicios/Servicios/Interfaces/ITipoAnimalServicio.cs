using ClaseEF.ClasificadorAnimales.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEF.ClasificadorAnimales.Servicios.Servicios.Interfaces
{
    public interface ITipoAnimalServicio
    {
        List<TipoAnimal> ObtenerTodos();

        //OPCIONAL, PARA AGREGAR UN TIPO DE ANIMAL QUE NO ESTE EN LA TABLA
       void Insertar(TipoAnimal entidad);

    }
}
