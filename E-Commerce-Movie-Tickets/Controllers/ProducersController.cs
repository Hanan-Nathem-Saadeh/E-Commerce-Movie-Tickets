using E_Commerce_Movie_Tickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace E_Commerce_Movie_Tickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            var allProducer = _context.Producers.ToList();
            return View();
        }
    }
}
