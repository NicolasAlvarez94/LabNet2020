using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesExceptionAPI
{
    /// <summary>
    /// Clase Heredada de Exception. Para Lanzamiento y Captura de Errores de Respuesta HTTP. 
    /// </summary>
    public class ErrorRespuestaHttpApiException: Exception
    {
        public override string Message => $"ERROR DE RESPUESTA HTTP. LOS RECURSOS ACTUALMENTE NO ESTAN DISPONIBLE.";


        /// <summary>
        /// Constructor por Defecto.
        /// </summary>
        public ErrorRespuestaHttpApiException() { }

        
        /// <summary>
        /// Recibe un Mensaje Perzonalizado a Traves de su Constructor a la Hora de su Instanciacion. Obtengalo con la Propiedad Message Luego.
        /// </summary>
        /// <param name="mensajeEnClaseCliente"></param>

        public ErrorRespuestaHttpApiException(string mensajeEnClaseCliente):base(mensajeEnClaseCliente) { }                
        
     
    }
}
