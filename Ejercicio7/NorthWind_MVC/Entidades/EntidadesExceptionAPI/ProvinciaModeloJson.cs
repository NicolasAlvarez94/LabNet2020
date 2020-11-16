using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesExceptionAPI
{

    public class ProvinciaModeloJson
    {
        public int cantidad { get; set; }
        public int inicio { get; set; }
        public Parametros parametros { get; set; }
        public IList<Provincia> provincias { get; set; }
        public int total { get; set; }
    }

    public class Parametros
    {
        public string nombre { get; set; }
    }

    public class Centroide
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Provincia
    {
        public Centroide centroide { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }





}
