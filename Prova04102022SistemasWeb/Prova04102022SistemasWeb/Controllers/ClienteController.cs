using Microsoft.AspNetCore.Mvc;
using Prova04102022SistemasWeb.Models;

namespace Prova04102022SistemasWeb.Controllers
{
    public class ClienteController
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Endereco")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _appCont.Add(cliente);
                await _appCont.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cliente);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var music = await _appCont.clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (music == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var music = await _appCont.musics.FindAsync(id);
            _appCont.clientes.Remove(cliente);
            await _appCont.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
