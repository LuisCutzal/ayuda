//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPC2_201700841.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalle_torneo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detalle_torneo()
        {
            this.Partido = new HashSet<Partido>();
        }
    
        public int id_detalle_torneo { get; set; }
        public Nullable<int> id_torneo { get; set; }
        public Nullable<int> id_us { get; set; }
    
        public virtual Torneo Torneo { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partido> Partido { get; set; }
    }
}
