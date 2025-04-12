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
        modelBuilder.Entity<Specialty>().HasData(
            new Specialty { Name = "general", Description = "Médico General" },
            new Specialty { Name = "pediatria", Description = "Pediatría" },
            new Specialty { Name = "derma", Description = "Dermatología" },
            new Specialty { Name = "odonto", Description = "Odontología" },
            new Specialty { Name = "oftalmo", Description = "Oftalmología" }
        );

        modelBuilder.Entity<Medic>().HasData(
            new Medic {
                Id = 1, FirstName = "Juan", LastName = "Pérez",
                Email = "juan.perez@gmail.com", Password = "Usuario123.",
                Identifier = "0010101010001A", Phone = "12121212", Sex = 1
            },
            new Medic {
                Id = 2, FirstName = "María", LastName = "Hernández",
                Email = "maria.hernandez@gmail.com", Password = "Usuario123.",
                Identifier = "0010101010001B", Phone = "14141414", Sex = 0
            }
        );

        modelBuilder.Entity<Medic>()
        .HasMany(m => m.Specialties)
        .WithMany(s => s.Medics)
        .UsingEntity(j => j.HasData(
            new { MedicsId = 1, SpecialtiesName = "general" },
            new { MedicsId = 1, SpecialtiesName = "odonto" },
            new { MedicsId = 2, SpecialtiesName = "derma" }
        ));

        modelBuilder.Entity<Patient>().HasData(
            new Patient {
                Id = 3, FirstName = "Jezer", LastName = "Mejía",
                Email = "jezer.mejia@gmail.com", Birthday = new DateTime(2003, 11, 05),
                Identifier = "2010511031000Y", Phone = "81211855", Sex = 1
            }
        );

    }
}

