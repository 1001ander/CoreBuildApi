using CoreBuildApi.data;
using CoreBuildApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreBuildApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CpuController : ControllerBase
{
    private readonly AppDbContext _context;

    public CpuController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cpu>>> GetCpus()
    {
        return await _context.Cpus.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cpu>> GetCpu(int id)
    {
        var cpu = await _context.Cpus.FindAsync(id);
        if (cpu == null) return NotFound();
        return cpu;
    }

    [HttpPost]
    public async Task<ActionResult<Cpu>> PostCpu(Cpu cpu)
    {
        _context.Cpus.Add(cpu);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetCpu), new { id = cpu.Id }, cpu);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutCpu(int id, Cpu cpu)
    {
        if (id != cpu.Id) return BadRequest();
        _context.Entry(cpu).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCpu(int id)
    {
        var cpu = await _context.Cpus.FindAsync(id);
        if (cpu == null) return NotFound();
        _context.Cpus.Remove(cpu);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}