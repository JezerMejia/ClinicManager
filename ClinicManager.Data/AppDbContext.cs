using ClinicManager.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=192.168.0.4;Database=ClinicManager;User Id=sa;Password=Usuario123.;TrustServerCertificate=True;");
        }
    }

    public DbSet<User> Users { get; set; }
    public DbSet<RegisteredUser> RegisteredUsers { get; set; }
    public DbSet<Medic> Medics { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Admin> Admins { get; set; }

    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Example 2: Seed data
        modelBuilder.Entity<Medic>().HasData(
            new Medic {
                Id = 1, FirstName = "Juan", LastName = "Pérez",
                Email = "juan.perez@gmail.com", Password = "Usuario123.",
                Identifier = "0010101010001A", Phone = "81211855", Sex = 1
            },
            new Medic {
                Id = 2, FirstName = "María", LastName = "Hernández",
                Email = "maria.hernandez@gmail.com", Password = "Usuario123.",
                Identifier = "0010101010001B", Phone = "12121212", Sex = 0
            }
        );
    }
}

