using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pets.Models;

namespace Pets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private PetsDbContext _context;

    public HomeController(ILogger<HomeController> logger, PetsDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        List<Pet> pets = _context.Pets.ToList();
        foreach (Pet pet in pets)
        {
            Console.WriteLine(pet.Name);
        }
        return View(pets);
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
