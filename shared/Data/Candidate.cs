using System;
using System.Collections.Generic;

namespace shared.Data
{
    public partial class Candidate
    {
        public Candidate()
        {
            CandidateOies = new HashSet<CandidateOie>();
        }

        public int Id { get; set; }
        public string CandidateName { get; set; } = null!;
        public string? CandidateEmail { get; set; }
        public string? CandidatePhone { get; set; }
        public byte[]? CandidatePhoto { get; set; }

        public virtual ICollection<CandidateOie> CandidateOies { get; set; }
    }
}
