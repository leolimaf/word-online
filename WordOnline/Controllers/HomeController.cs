using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WordOnline.Data;
using WordOnline.Models;

namespace WordOnline.Controllers;

public class HomeController(AppDbContext context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var documentos = await context.Documentos.ToListAsync();
        
        return View(documentos);
    }

    public IActionResult CriarDocumento()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CriarDocumento(Documento documento)
    {
        if (!ModelState.IsValid) 
            return View(documento);
        
        await context.AddAsync(documento);
        await context.SaveChangesAsync();

        return RedirectToAction("Index");

    }
}