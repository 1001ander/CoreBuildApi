using CoreBuildApi.data;
using CoreBuildApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreBuildApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GpuController : ControllerBase
{
    private readonly AppDbContext _context;

    public GpuController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Gpu>>> GetGpus()
    {
        return await _context.Gpus.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Gpu>> GetGpu(int id)
    {
        var gpu = await _context.Gpus.FindAsync(id);
        if (gpu == null) return NotFound();
        return gpu;
    }

    [HttpPost]
    public async Task<ActionResult<Gpu>> PostGpu(Gpu gpu)
    {
        _context.Gpus.Add(gpu);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetGpu), new { id = gpu.Id }, gpu);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutGpu(int id, Gpu gpu)
    {
        if (id != gpu.Id) return BadRequest();
        _context.Entry(gpu).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGpu(int id)
    {
        var gpu = await _context.Gpus.FindAsync(id);
        if (gpu == null) return NotFound();
        _context.Gpus.Remove(gpu);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}