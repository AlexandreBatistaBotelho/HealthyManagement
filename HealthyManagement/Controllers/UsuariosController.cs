using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthyManagement.Data;
using HealthyManagement.Models;
using Microsoft.AspNetCore.Routing;

namespace HealthyManagement.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly HealthyManagementContext _context;

        public UsuariosController(HealthyManagementContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuario.ToListAsync());
        }

        public async Task<IActionResult> ChecarLogin(string login, string senha)
        {
            bool usuario = await _context.Usuario.AnyAsync(e => e.Login == login && e.Senha == senha);
            if (usuario)
            {
                //return await clientesController.Index();
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Clientes", action = "Index" }));
            }
            else
            {
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Usuarios", action = "Index" }));
            }
        }
    }
}
