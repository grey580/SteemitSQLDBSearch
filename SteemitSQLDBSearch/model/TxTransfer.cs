//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SteemitSQLDBSearch.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TxTransfer
    {
        public int ID { get; set; }
        public int tx_id { get; set; }
        public string type { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public decimal amount { get; set; }
        public string amount_symbol { get; set; }
        public string memo { get; set; }
        public int request_id { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}