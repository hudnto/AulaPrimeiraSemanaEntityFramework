//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anac.DataModelEdmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class ESPECIE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESPECIE()
        {
            this.PROCESSOes = new HashSet<PROCESSO>();
        }
    
        public int ID_ESPECIE { get; set; }
        public string DS_ESPECIE { get; set; }
        public System.DateTime DT_INICIO_VIGENCIA { get; set; }
        public Nullable<System.DateTime> DT_FIM_VIGENCIA { get; set; }
        public string SN_REGISTRO_ATIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO> PROCESSOes { get; set; }
    }
}
