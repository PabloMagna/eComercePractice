using eComerce.Data;
using eComerce.Data.Services;
using eComerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePicture,Bio")] Actor actor)
        {
            Console.WriteLine(actor.FullName);
            Console.WriteLine(actor.ProfilePicture);
            Console.WriteLine(actor.Bio);
             
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var error in errors)
            {
                var errorMessage = error.ErrorMessage;
                // Hacer algo con el mensaje de error...
            }

            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _services.getByIdAsync(id);
            if (actorDetails == null) return View(nameof(Index));
            return View(actorDetails);
        }
    }
}
