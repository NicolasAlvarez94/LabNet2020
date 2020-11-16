using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contexto
{
    public abstract class BaseContextDAO
    {
        protected static NorthWindContext bdContext;

        public BaseContextDAO() {
            bdContext = NorthWindContext.GetContext();
        }

    }
}
