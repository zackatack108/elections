using System;
using System.Collections.Generic;

namespace shared.Data
{
    public partial class Office
    {
        public Office()
        {
            OfficeInElections = new HashSet<OfficeInElection>();
        }

        public int Id { get; set; }
        public string? OfficeName { get; set; }
        public int? CountyId { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? PositionsNum { get; set; }
        public int? ElectionId { get; set; }

        public virtual City? City { get; set; }
        public virtual County? County { get; set; }
        public virtual State? State { get; set; }
        public virtual ICollection<OfficeInElection> OfficeInElections { get; set; }
    }
}
