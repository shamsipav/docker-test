using DockerWebApplication.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DockerWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly DockerDBContext _context;

        public List<User> Users { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DockerDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Users = _context.Users.ToList();
        }
    }
}