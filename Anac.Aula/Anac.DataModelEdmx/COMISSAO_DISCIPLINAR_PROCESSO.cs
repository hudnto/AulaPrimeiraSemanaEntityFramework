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
    
    public partial class COMISSAO_DISCIPLINAR_PROCESSO
    {
        public int ID_COMISSAO_DISCIPLINAR_PROCESSO { get; set; }
        public int ID_COMISSAO_DISCIPLINAR { get; set; }
        public int ID_PROCESSO { get; set; }
        public Nullable<int> ID_ORGAO_EXTERNO { get; set; }
        public System.DateTime DT_INSTAURACAO { get; set; }
        public string SN_REGISTRO_ATIVO { get; set; }
        public Nullable<System.DateTime> DT_EXCLUSAO_REGISTRO { get; set; }
        public Nullable<int> ID_USUARIO_EXCLUSAO { get; set; }
    
        public virtual COMISSAO_DISCIPLINAR COMISSAO_DISCIPLINAR { get; set; }
        public virtual ORGAO_EXTERNO ORGAO_EXTERNO { get; set; }
        public virtual PROCESSO PROCESSO { get; set; }
    }
}
