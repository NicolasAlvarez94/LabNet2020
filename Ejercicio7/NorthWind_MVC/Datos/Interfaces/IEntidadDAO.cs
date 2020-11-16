using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IEntidadDAO <T>
    {
        // Contratos.
        void RegistrarEntidad(T entidad);
        List<T> TraerDatos();
        void ModificarEntidad(T entidad);
        void EliminarEntidad(int id);
    }
}
