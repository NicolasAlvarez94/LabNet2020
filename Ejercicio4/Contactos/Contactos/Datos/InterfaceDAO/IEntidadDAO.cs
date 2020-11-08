using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.InterfaceDAO
{
    interface IEntidadDAO <T>
    {
        void Registrar(T registro);
        List<T> ListarDatos();
    }
}
