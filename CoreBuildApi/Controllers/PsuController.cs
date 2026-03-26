using CoreBuildApi.data;
using CoreBuildApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreBuildApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PsuController : ControllerBase
{
    private readonly AppDbContext _context;

    public PsuController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Psu>>> GetPsus()
    {
        return await _context.Psus.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Psu>> GetPsu(int id)
    {
        var psu = await _context.Psus.FindAsync(id);
        if (psu == null) return NotFound();
        return psu;
    }

    [HttpPost]
    public async Task<ActionResult<Psu>> PostPsu(Psu psu)
    {
        _context.Psus.Add(psu);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPsu), new { id = psu.Id }, psu);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutPsu(int id, Psu psu)
    {
        if (id != psu.Id) return BadRequest();
        _context.Entry(psu).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePsu(int id)
    {
        var psu = await _context.Psus.FindAsync(id);
        if (psu == null) return NotFound();
        _context.Psus.Remove(psu);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}