namespace EntidadesAPI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("TEST.EMPLOYEES")]
    public partial class EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE()
        {
            EMPLOYEES1 = new HashSet<EMPLOYEE>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LAST_NAME { get; set; }

        public decimal? SALARY { get; set; }

        public int? DEPARTMENT_ID { get; set; }

        [StringLength(6)]
        public string JOB_ID { get; set; }

        public DateTime HIRE_DATE { get; set; }

        public int? MANAGER_ID { get; set; }

        public virtual DEPARTMENT DEPARTMENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE> EMPLOYEES1 { get; set; }

        public virtual EMPLOYEE EMPLOYEE1 { get; set; }

        public virtual JOB JOB { get; set; }
    }
}
