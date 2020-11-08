using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datos.Contexto
{
    public abstract class BaseContext
    {
        protected static EmpresaContactoContext bdContext = null;

        public BaseContext() {
            bdContext = this.getContexto();
        }

        private EmpresaContactoContext getContexto() {
            bool unicaInstancia = bdContext == null;
            if (unicaInstancia) {
                bdContext = new EmpresaContactoContext();
            }
            return bdContext;
        }


    }
}