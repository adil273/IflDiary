using Microsoft.EntityFrameworkCore;

namespace IflDiary.Models
{
    public class IflDiaryContext : DbContext

    {
        //CONSTRUCTOR 21-3-25
        public IflDiaryContext(DbContextOptions options) : base(options) { }

        //OVERRIDE METHOD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relation in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys()))
            {
                relation.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        //DBSETS
        public DbSet <User> Users {get; set;}
        public DbSet<Role> Roles { get; set; }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<Followup> Followups { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Ogp> Ogps { get; set; }
        public DbSet<Demand> Demands { get; set; }
        public DbSet<Purchaser> Purchasers { get; set; }
        public DbSet<DemandCategory> DemandCategories { get; set; }
        public DbSet<ElectricalDepartment> ElectricalDepartments { get; set; }

    }
}
