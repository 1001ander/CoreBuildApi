using CoreBuildApi.data;
using CoreBuildApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreBuildApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RamController : ControllerBase
{
    private readonly AppDbContext _context;

    public RamController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ram>>> GetRams()
    {
        return await _context.Rams.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Ram>> GetRam(int id)
    {
        var ram = await _context.Rams.FindAsync(id);
        if (ram == null) return NotFound();
        return ram;
    }

    [HttpPost]
    public async Task<ActionResult<Ram>> PostRam(Ram ram)
    {
        _context.Rams.Add(ram);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetRam), new { id = ram.Id }, ram);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutRam(int id, Ram ram)
    {
        if (id != ram.Id) return BadRequest();
        _context.Entry(ram).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRam(int id)
    {
        var ram = await _context.Rams.FindAsync(id);
        if (ram == null) return NotFound();
        _context.Rams.Remove(ram);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}