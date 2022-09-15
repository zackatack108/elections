using election.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Data;

namespace election.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataBaseController : ControllerBase
    {
        private readonly InstantRunoffContext instantRunoffContext;

        public DataBaseController(InstantRunoffContext instantRunoffContext)
        {
            this.instantRunoffContext = instantRunoffContext;
        }

        [HttpGet("[action]")]
        public async Task<int> RowCount()
        {
            var rowCount = await instantRunoffContext.CandidateOies.CountAsync();
            return rowCount;
        }
    }
}
