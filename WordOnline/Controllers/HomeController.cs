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
    public async Task<IActionResult> EditarDocumento(Guid id)
    {
        var documento = await context.Documentos.FindAsync(id);
        return View(documento);
    }

    [HttpPost]
    public async Task<IActionResult> EditarDocumento(Documento documentoEditado)
    {
        if (!ModelState.IsValid) 
            return View();
        
        var documento = await context.Documentos.FindAsync(documentoEditado.Id);

        documento.Titulo = documentoEditado.Titulo;
        documento.Conteudo = documentoEditado.Conteudo;
        documento.DataAlteracao = DateTime.Now;

        context.Update(documento);
        await context.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    public async Task<IActionResult> RemoverDocumento(Guid id)
    {
        var documento = await context.Documentos.FindAsync(id);
        context.Documentos.Remove(documento);
        await context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}