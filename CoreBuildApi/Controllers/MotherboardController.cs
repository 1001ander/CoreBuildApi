using CoreBuildApi.data;
using CoreBuildApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreBuildApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MotherboardController : ControllerBase
{
    private readonly AppDbContext _context;

    public MotherboardController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Motherboard>>> GetMotherboards()
    {
        return await _context.Motherboards.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Motherboard>> GetMotherboard(int id)
    {
        var motherboard = await _context.Motherboards.FindAsync(id);
        if (motherboard == null) return NotFound();
        return motherboard;
    }

    [HttpPost]
    public async Task<ActionResult<Motherboard>> PostMotherboard(Motherboard motherboard)
    {
        _context.Motherboards.Add(motherboard);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMotherboard), new { id = motherboard.Id }, motherboard);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutMotherboard(int id, Motherboard motherboard)
    {
        if (id != motherboard.Id) return BadRequest();
        _context.Entry(motherboard).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMotherboard(int id)
    {
        var motherboard = await _context.Motherboards.FindAsync(id);
        if (motherboard == null) return NotFound();
        _context.Motherboards.Remove(motherboard);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}