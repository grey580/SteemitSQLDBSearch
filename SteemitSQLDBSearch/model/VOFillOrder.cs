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
    
    public partial class VOFillOrder
    {
        public int ID { get; set; }
        public int block_num { get; set; }
        public System.DateTime timestamp { get; set; }
        public string current_owner { get; set; }
        public long current_orderid { get; set; }
        public string current_pays { get; set; }
        public string open_owner { get; set; }
        public long open_orderid { get; set; }
        public string open_pays { get; set; }
    
        public virtual Block Block { get; set; }
    }
}