using ApiUserMinimalista.Models;

namespace ApiUserMinimalista.Controllers
{
    public class UsuarioController
    {
        private readonly METEOROLOGIAContext _context;

        public UsuarioController(METEOROLOGIAContext context)
        {
            _context = context;
        }

        public object GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

    }
}
