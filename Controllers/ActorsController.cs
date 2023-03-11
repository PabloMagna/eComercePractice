using eComerce.Data;
using eComerce.Data.Services;
using eComerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Transactions;

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
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _services.getByIdAsync(id);
            if (actor == null) return View("NotFound");
            return View(actor);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePicture,Bio")] Actor actor)
        {
            if (id != actor.Id) return View("NotFound");
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            var updatedActor = await _services.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task <IActionResult> Delete(int id)
        {
            var actor = await _services.getByIdAsync(id);
            if (actor == null) return View("NotFound");
            return View(actor);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var actor = await _services.getByIdAsync(id);
            if (actor == null) return View("NotFound");
            if (!ModelState.IsValid)
            {
                return View("NotFound");
            }
            await _services.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        
    }
}
