using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contexto
{
    public abstract class BaseContextDAO: NorthWindContext
    {
        protected static NorthWindContext bdContext;

        public BaseContextDAO() {
            bdContext = base.GetContext();
        }

        public NorthWindContext GetBaseContext() {
            return bdContext;
        }
    }
}
