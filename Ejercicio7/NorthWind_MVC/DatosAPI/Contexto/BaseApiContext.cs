using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAPI.Contexto
{
    public abstract class BaseApiContext
    {
        protected readonly ApiContextDb dbContext;

        public BaseApiContext() {         
            this.dbContext = ApiContextDb.ObtenerContextoBD();
        }
    }
}
