namespace ColorRoomManager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<CrushRaw> CrushRaws { get; set; }
        public virtual DbSet<Label> Labels { get; set; }
        public virtual DbSet<LossType> LossTypes { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MixingOut> MixingOuts { get; set; }
        public virtual DbSet<MixRaw> MixRaws { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductColor> ProductColors { get; set; }
        public virtual DbSet<Step> Steps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
