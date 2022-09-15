using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using shared.Data;

namespace web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration config;
        private readonly HttpClient http;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config, HttpClient http)
        {
            _logger = logger;
            this.config = config;
            this.http = http;
        }

        public IEnumerable<Ballot>? Ballots { get; private set; }
        public async Task OnGet()
        {
            string apihost = config["apiAddress"];
            string url = $"{apihost}/api/ballots";
            Ballots = await http.GetFromJsonAsync<IEnumerable<Ballot>>(url);
        }
    }
}