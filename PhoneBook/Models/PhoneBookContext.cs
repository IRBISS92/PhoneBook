namespace PhoneBook.Models
{
    using System.Data.Entity;

    public partial class PhoneBookContext : DbContext
    {
        public PhoneBookContext()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>().ToTable("dbo.AspNetUsers");
            base.OnModelCreating(modelBuilder);
        }
    }
}
