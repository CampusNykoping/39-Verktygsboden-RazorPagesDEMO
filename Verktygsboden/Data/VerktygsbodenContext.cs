#nullable disable
using Microsoft.EntityFrameworkCore;
using Verktygsboden.Models;

namespace Verktygsboden.Data;

public class VerktygsbodenContext : DbContext
{
    public VerktygsbodenContext (DbContextOptions<VerktygsbodenContext> options)
        : base(options)
    {
    }

    public DbSet<Verktygsboden.Models.Asset> Asset { get; set; }

    public DbSet<Verktygsboden.Models.User> User { get; set; }

    public DbSet<Verktygsboden.Models.Booking> Booking { get; set; }
}
