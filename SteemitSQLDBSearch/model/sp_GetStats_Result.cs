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
    
    public partial class sp_GetStats_Result
    {
        public string name { get; set; }
        public Nullable<double> reputation { get; set; }
        public Nullable<decimal> Shares { get; set; }
        public int Post { get; set; }
        public int Comment { get; set; }
        public long Payout { get; set; }
        public int postvotes { get; set; }
        public int commentvotes { get; set; }
        public int Voted { get; set; }
    }
}
