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
    
    public partial class RPC_FotoXTelaio
    {
        public int ID { get; set; }
        public int IDTelaio { get; set; }
        public string NomeFile { get; set; }
        public System.DateTime InsertDate { get; set; }
    
        public virtual RPC_Telai RPC_Telai { get; set; }
    }
}