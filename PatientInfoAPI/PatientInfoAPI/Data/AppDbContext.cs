using Microsoft.EntityFrameworkCore;
using PatientInfoAPI.Model;

namespace PatientInfoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<NCD> NCDs { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Allergies_Details> Allergies_Details { get; set; }
        public DbSet<NCD_Details> NCD_Details { get; set; }
        public DbSet<DiseaseInfo> DiseaseInfo { get; set; }
    }
}
