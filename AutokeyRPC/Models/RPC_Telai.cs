//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutokeyRPC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RPC_Telai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RPC_Telai()
        {
            this.RPC_FotoXTelaio = new HashSet<RPC_FotoXTelaio>();
        }
    
        public int ID { get; set; }
        public int IDCantiere { get; set; }
        public string IDOperatore { get; set; }
        public int IDLotto { get; set; }
        public bool IsFinished { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string Telaio { get; set; }
        public string Descr { get; set; }
    
        public virtual AUK_cantieri AUK_cantieri { get; set; }
        public virtual RPC_Lotti RPC_Lotti { get; set; }
        public virtual RPC_Telai RPC_Telai1 { get; set; }
        public virtual RPC_Telai RPC_Telai2 { get; set; }
        public virtual PKT_Operatori PKT_Operatori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RPC_FotoXTelaio> RPC_FotoXTelaio { get; set; }
    }
}
