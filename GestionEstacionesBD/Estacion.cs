//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionEstacionesBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estacion()
        {
            this.PuntoCarga = new HashSet<PuntoCarga>();
        }
    
        public int idEstacion { get; set; }
        public int capacidadMax { get; set; }
        public string horario { get; set; }
        public int idDireccion { get; set; }
        public int idRegion { get; set; }
    
        public virtual Direccion Direccion { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PuntoCarga> PuntoCarga { get; set; }
    }
}