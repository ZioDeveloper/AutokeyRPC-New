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
    
    public partial class AUK_cantieri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUK_cantieri()
        {
            this.RPC_Cantieri = new HashSet<RPC_Cantieri>();
        }
    
        public int ID { get; set; }
        public string Codice { get; set; }
        public string ragioneSociale { get; set; }
        public Nullable<int> ID_localita { get; set; }
        public Nullable<int> ID_cap { get; set; }
        public string indirizzo { get; set; }
        public Nullable<int> ID_nazione { get; set; }
        public Nullable<int> ID_maps { get; set; }
        public Nullable<int> ID_valutazioneCantiere { get; set; }
        public string piva_cantiere { get; set; }
        public string tel1_cantiere { get; set; }
        public string tel2_cantiere { get; set; }
        public string tel3_cantiere { get; set; }
        public string mail1_cantiere { get; set; }
        public string mail2_cantiere { get; set; }
        public string mail3_cantiere { get; set; }
        public string fax1_cantiere { get; set; }
        public string sitoWeb_cantiere { get; set; }
        public string referente { get; set; }
        public Nullable<int> id_reteCantiere_BUTTARE { get; set; }
        public int id_tipoCantiere { get; set; }
        public Nullable<int> id_contratto { get; set; }
        public Nullable<System.DateTime> dataInizioAttivitaCantiere { get; set; }
        public string dataFineAttivitaCantiere { get; set; }
        public bool is_presenzaLavaggio { get; set; }
        public bool is_vetturaSostitutiva { get; set; }
        public Nullable<double> costoVetturaSostitutiva { get; set; }
        public Nullable<double> costoHosting { get; set; }
        public Nullable<double> costoManoDopera { get; set; }
        public Nullable<double> costoMaterialeDiConsumo { get; set; }
        public bool is_CompAss_Generali { get; set; }
        public bool is_reteAutokey { get; set; }
        public bool is_CompAss_Cattolica { get; set; }
        public Nullable<int> ID_sconto { get; set; }
        public string nota { get; set; }
        public bool is_cantiereAttivo { get; set; }
        public Nullable<System.DateTime> insertTime { get; set; }
        public string Regione { get; set; }
        public string Pv { get; set; }
        public string Citta { get; set; }
        public Nullable<double> Cap { get; set; }
        public Nullable<int> ID_metodoPagamentoCantiere { get; set; }
        public Nullable<int> ID_giorniPagamentoCantiere { get; set; }
        public string coordinateBancarieCantiere { get; set; }
        public bool is_inviataProceduraModulistica { get; set; }
        public bool is_attesaContrattoCantiere { get; set; }
        public bool is_inviataRichiestaFidelizzazione { get; set; }
        public Nullable<double> latitudine { get; set; }
        public Nullable<double> longitudine { get; set; }
        public string insertUser { get; set; }
        public string CodiceCliente { get; set; }
        public string Codice_SAP { get; set; }
        public Nullable<int> ID_tecnicoReferente { get; set; }
        public bool is_privacy_GDPR { get; set; }
    
        public virtual AUK_cantieri AUK_cantieri1 { get; set; }
        public virtual AUK_cantieri AUK_cantieri2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RPC_Cantieri> RPC_Cantieri { get; set; }
        public virtual AUK_tecnici AUK_tecnici { get; set; }
    }
}
