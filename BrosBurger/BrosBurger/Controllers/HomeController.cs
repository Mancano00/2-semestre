using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BrosBurger.Models;
using BrosBurger.Context;

namespace BrosBurger.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

  public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Produtos.Include(p => p.Categoria);
            return View(await appDbContext.ToListAsync());
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
