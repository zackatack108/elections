using System;
using System.Collections.Generic;

namespace shared.Data
{
    public partial class Party
    {
        public Party()
        {
            CandidateOies = new HashSet<CandidateOie>();
        }

        public int Id { get; set; }
        public string PartyName { get; set; } = null!;
        public string PartyBallotLabel { get; set; } = null!;

        public virtual ICollection<CandidateOie> CandidateOies { get; set; }
    }
}
