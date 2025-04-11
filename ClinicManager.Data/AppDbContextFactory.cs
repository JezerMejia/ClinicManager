using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=192.168.0.4;Database=ClinicManager;User Id=sa;Password=Usuario123.;TrustServerCertificate=True;");

        return new AppDbContext(optionsBuilder.Options);
    }
}
