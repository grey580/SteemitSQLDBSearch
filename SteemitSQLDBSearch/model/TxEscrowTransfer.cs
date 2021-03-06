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
    
    public partial class TxEscrowTransfer
    {
        public int ID { get; set; }
        public int tx_id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public decimal sdb_amount { get; set; }
        public decimal steem_amount { get; set; }
        public int escrow_id { get; set; }
        public string agent { get; set; }
        public decimal fee { get; set; }
        public string fee_symbol { get; set; }
        public string json_meta { get; set; }
        public System.DateTime ratification_deadline { get; set; }
        public System.DateTime escrow_expiration { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
