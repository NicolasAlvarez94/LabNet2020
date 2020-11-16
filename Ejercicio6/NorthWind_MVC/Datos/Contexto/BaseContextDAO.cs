using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contexto
{
    public abstract class BaseContextDAO
    {
        protected readonly NorthWindContext bdContext;

        public BaseContextDAO() {
            this.bdContext = NorthWindContext.GetContext();
        }

       
    }
}
