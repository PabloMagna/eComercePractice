using eComerce.Data;
using eComerce.Data.Services;
using eComerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eComerce.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsServices _services;
        public ActorsController(IActorsServices services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _services.getAll();
            return View(data);
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}
