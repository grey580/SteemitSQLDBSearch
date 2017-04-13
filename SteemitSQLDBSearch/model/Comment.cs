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
    
    public partial class Comment
    {
        public int ID { get; set; }
        public string author { get; set; }
        public string permlink { get; set; }
        public string category { get; set; }
        public string parent_author { get; set; }
        public string parent_permlink { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public string json_metadata { get; set; }
        public System.DateTime last_update { get; set; }
        public System.DateTime created { get; set; }
        public System.DateTime active { get; set; }
        public System.DateTime last_payout { get; set; }
        public int depth { get; set; }
        public int children { get; set; }
        public double children_rshares2 { get; set; }
        public long net_rshares { get; set; }
        public long abs_rshares { get; set; }
        public long vote_rshares { get; set; }
        public long children_abs_rshares { get; set; }
        public System.DateTime cashout_time { get; set; }
        public System.DateTime max_cashout_time { get; set; }
        public double total_vote_weight { get; set; }
        public int reward_weight { get; set; }
        public decimal total_payout_value { get; set; }
        public decimal curator_payout_value { get; set; }
        public decimal author_rewards { get; set; }
        public int net_votes { get; set; }
        public string root_comment { get; set; }
        public string mode { get; set; }
        public decimal max_accepted_payout { get; set; }
        public int percent_steem_dollars { get; set; }
        public bool allow_replies { get; set; }
        public bool allow_votes { get; set; }
        public bool allow_curation_rewards { get; set; }
        public string beneficiaries { get; set; }
        public string url { get; set; }
        public string root_title { get; set; }
        public decimal pending_payout_value { get; set; }
        public decimal total_pending_payout_value { get; set; }
        public string active_votes { get; set; }
        public string replies { get; set; }
        public long author_reputation { get; set; }
        public string promoted { get; set; }
        public int body_length { get; set; }
        public string reblogged_by { get; set; }
        public string body_language { get; set; }
        public Nullable<bool> dirty { get; set; }
    }
}
