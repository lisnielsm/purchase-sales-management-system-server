using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos;
using Sistema.Web.Models.Usuarios.Rol;

namespace Sistema.Web.Controllers
{
    [Authorize(Roles = "Administrador")]
    [Route("api/roles")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly DbContextSistema _context;

        public RolesController(DbContextSistema context)
        {
            _context = context;
        }

        // GET: api/roles/Listar
        [HttpGet("[action]")]
        public async Task<IEnumerable<RolViewModel>> Listar()
        {
            var roles = await _context.Roles.ToListAsync();

            return roles.Select(r => new RolViewModel
            {
                idrol = r.idrol,
                nombre = r.nombre,
                descripcion = r.descripcion,
                condicion = r.condicion
            });
        }

        // GET: api/roles/Select
        [HttpGet("[action]")]
        public async Task<IEnumerable<SelectViewModel>> Select()
        {
            var roles = await _context.Roles.Where(r => r.condicion == true).ToListAsync();

            return roles.Select(r => new SelectViewModel
            {
                idrol= r.idrol,
                nombre = r.nombre
            });
        }

        private bool CategoriaExists(int id)
        {
            return _context.Roles.Any(e => e.idrol == id);
        }
    }
}