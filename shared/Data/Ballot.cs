using System;
using System.Collections.Generic;

namespace shared.Data
{
    public partial class Ballot
    {
        public Ballot()
        {
            BallotPrefs = new HashSet<BallotPref>();
        }

        public int Id { get; set; }
        public int? VoterId { get; set; }
        public string? Precinctinfo { get; set; }
        public DateTime? CastTimestamp { get; set; }

        public virtual ICollection<BallotPref> BallotPrefs { get; set; }
    }
}
