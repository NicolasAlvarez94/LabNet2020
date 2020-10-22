using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos
{
    public interface IDaoTransporte
    {
        void AgregarTransporte(Transporte transporte);
        List<Transporte> ObtenerTransportes();
    }
}
