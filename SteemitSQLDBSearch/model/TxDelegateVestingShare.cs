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
    
    public partial class TxDelegateVestingShare
    {
        public int ID { get; set; }
        public int tx_id { get; set; }
        public string delegator { get; set; }
        public string delegatee { get; set; }
        public decimal vesting_shares { get; set; }
    
        public virtual Transaction Transaction { get; set; }
    }
}
