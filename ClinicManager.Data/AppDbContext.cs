using ClinicManager.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<RegisteredUser> RegisteredUsers { get; set; }
    public DbSet<Medic> Medics { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Admin> Admins { get; set; }

    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
}

