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
    
    public partial class Block
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Block()
        {
            this.Transactions = new HashSet<Transaction>();
            this.VOAuthorRewards = new HashSet<VOAuthorReward>();
            this.VOCurationRewards = new HashSet<VOCurationReward>();
            this.VOFillConvertRequests = new HashSet<VOFillConvertRequest>();
            this.VOFillOrders = new HashSet<VOFillOrder>();
            this.VOFillVestingWithdraws = new HashSet<VOFillVestingWithdraw>();
            this.VOInterests = new HashSet<VOInterest>();
            this.VOShutdownWitnesses = new HashSet<VOShutdownWitness>();
        }
    
        public int block_num { get; set; }
        public string previous { get; set; }
        public System.DateTime timestamp { get; set; }
        public string witness { get; set; }
        public string witness_signature { get; set; }
        public string transaction_merkle_root { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction> Transactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOAuthorReward> VOAuthorRewards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOCurationReward> VOCurationRewards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOFillConvertRequest> VOFillConvertRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOFillOrder> VOFillOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOFillVestingWithdraw> VOFillVestingWithdraws { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOInterest> VOInterests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VOShutdownWitness> VOShutdownWitnesses { get; set; }
    }
}
