using ApiUserMinimalista.Models;

namespace ApiUserMinimalista.Controllers
{
    public class ClimasControllers
    {
        private readonly METEOROLOGIAContext _context;

        public ClimasControllers(METEOROLOGIAContext context)
        {
            _context = context;
        }

    }
}
