using System;
using System.Collections.Generic;

namespace shared.Data
{
    public partial class Veffectiveballot
    {
        public int? ElectionId { get; set; }
        public int? CoieId { get; set; }
        public int? OieId { get; set; }
        public int? CandidateId { get; set; }
        public long? Numvotes { get; set; }
        public decimal? Pcteffectiveballots { get; set; }
        public long? OfficeTotalVotes { get; set; }
    }
}
