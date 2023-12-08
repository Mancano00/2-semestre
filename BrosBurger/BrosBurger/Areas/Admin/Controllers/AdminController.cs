using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BrosBurger.Context;
using App.Filters;

namespace BrosBurger.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AdminAuthorize]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Produtos.Include(p => p.Categoria);
            return View(await appDbContext.ToListAsync());
        }
    }
}