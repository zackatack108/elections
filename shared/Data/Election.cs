using System;
using System.Collections.Generic;

namespace shared.Data
{
    public partial class Election
    {
        public Election()
        {
            OfficeInElections = new HashSet<OfficeInElection>();
        }

        public int Id { get; set; }
        public DateOnly? Earlyvotingbegin { get; set; }
        public DateOnly? Earlyvotingend { get; set; }
        public DateOnly? PollDate { get; set; }
        public bool Ballotingclosed { get; set; }

        public virtual ICollection<OfficeInElection> OfficeInElections { get; set; }
    }
}
