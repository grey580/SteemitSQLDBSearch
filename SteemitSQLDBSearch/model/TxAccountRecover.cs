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
    
    public partial class TxAccountRecover
    {
        public int ID { get; set; }
        public int tx_id { get; set; }
        public string recovery_account { get; set; }
        public string account_to_recover { get; set; }
        public bool recovered { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
