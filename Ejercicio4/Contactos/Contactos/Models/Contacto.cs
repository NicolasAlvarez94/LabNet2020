namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contactos")]
    public partial class Contacto
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(1)]
        public string Genero { get; set; }

        [StringLength(60)]
        public string Empresa { get; set; }
    }
}
