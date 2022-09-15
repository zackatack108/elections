using System;
using System.Collections.Generic;

namespace shared.Data
{
    public partial class OfficeInElection
    {
        public OfficeInElection()
        {
            CandidateOies = new HashSet<CandidateOie>();
        }

        public int Id { get; set; }
        public int? OfficeId { get; set; }
        public int ElectionId { get; set; }
        public int? Quantity { get; set; }

        public virtual Election Election { get; set; } = null!;
        public virtual Office? Office { get; set; }
        public virtual ICollection<CandidateOie> CandidateOies { get; set; }
    }
}
