using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


[ApiController]
[Route("api/[controller]")]
[Authorize]
public class HedefController : ControllerBase
{
    private readonly GorevContext _context;
    public HedefController(GorevContext context)
    {
        _context = context;
    }

    // Kullanıcının tüm hedeflerini getir
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hedef>>> GetHedefler()
    {
        int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        return await _context.Hedefler.Where(h => h.UserId == userId).ToListAsync();
    }

    // Hedef ekle
    [HttpPost]
    public async Task<ActionResult<Hedef>> PostHedef(Hedef hedef)
    {
        int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        hedef.UserId = userId;
        hedef.CreatedAt = DateTime.UtcNow;
        _context.Hedefler.Add(hedef);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetHedefler), new { id = hedef.Id }, hedef);
    }

    // Hedef güncelle
    [HttpPut("{id}")]
    public async Task<IActionResult> PutHedef(int id, Hedef hedef)
    {
        if (id != hedef.Id)
            return BadRequest();
        int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var mevcut = await _context.Hedefler.FirstOrDefaultAsync(h => h.Id == id && h.UserId == userId);
        if (mevcut == null) return NotFound();
        mevcut.Text = hedef.Text;
        mevcut.Type = hedef.Type;
        mevcut.Done = hedef.Done;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // Hedef sil
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHedef(int id)
    {
        int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        var hedef = await _context.Hedefler.FirstOrDefaultAsync(h => h.Id == id && h.UserId == userId);
        if (hedef == null) return NotFound();
        _context.Hedefler.Remove(hedef);
        await _context.SaveChangesAsync();
        return NoContent();
    }
} 