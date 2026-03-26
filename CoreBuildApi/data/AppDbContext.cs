using CoreBuildApi.models;
using Microsoft.EntityFrameworkCore;

namespace CoreBuildApi.data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cpu> Cpus { get; set; }
    public DbSet<Gpu> Gpus { get; set; }
    public DbSet<Motherboard> Motherboards { get; set; }
    public DbSet<Ram> Rams { get; set; }
    public DbSet<Psu> Psus { get; set; }
}