using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAPI.Interface
{
    public interface IEntidadApiDAO <T>
    {
        void Registrar(T modelo);
        void Eliminar(int id);
        List<T> TraerDatos();
        void Modificar(T modelo);
        T TraerPorID(int modelo);
    }
}
