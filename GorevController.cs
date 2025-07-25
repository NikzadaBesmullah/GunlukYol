using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class GorevController : ControllerBase
{
    private readonly GorevContext _context;

    public GorevController(GorevContext context)
    {
        _context = context;
    }

    // Tüm görevleri listele
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Gorev>>> GetGorevler()
    {
        int userId = int.Parse(User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier));
        return await _context.Gorevler.Where(g => g.UserId == userId).ToListAsync();
    }

    // Tek bir görevi getir
    [HttpGet("{id}")]
    public async Task<ActionResult<Gorev>> GetGorev(int id)
    {
        int userId = int.Parse(User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier));
        var gorev = await _context.Gorevler.FirstOrDefaultAsync(g => g.Id == id && g.UserId == userId);
        if (gorev == null)
            return NotFound();
        return gorev;
    }

    // Görev oluştur
    [HttpPost]
    public async Task<ActionResult<Gorev>> PostGorev(Gorev gorev)
    {
        int userId = int.Parse(User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier));
        gorev.UserId = userId;
        _context.Gorevler.Add(gorev);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetGorev), new { id = gorev.Id }, gorev);
    }

    // Görev güncelle
    [HttpPut("{id}")]
    public async Task<IActionResult> PutGorev(int id, Gorev gorev)
    {
        if (id != gorev.Id)
            return BadRequest();
        int userId = int.Parse(User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier));
        var mevcut = await _context.Gorevler.FirstOrDefaultAsync(g => g.Id == id && g.UserId == userId);
        if (mevcut == null) return NotFound();
        mevcut.Baslik = gorev.Baslik;
        mevcut.Aciklama = gorev.Aciklama;
        mevcut.Tarih = gorev.Tarih;
        mevcut.TamamlandiMi = gorev.TamamlandiMi;
        mevcut.SonTarih = gorev.SonTarih;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // Görev sil
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGorev(int id)
    {
        int userId = int.Parse(User.FindFirstValue(System.Security.Claims.ClaimTypes.NameIdentifier));
        var gorev = await _context.Gorevler.FirstOrDefaultAsync(g => g.Id == id && g.UserId == userId);
        if (gorev == null)
            return NotFound();
        _context.Gorevler.Remove(gorev);
        await _context.SaveChangesAsync();
        return NoContent();
    }
} 