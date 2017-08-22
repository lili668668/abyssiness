using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace abyssiness
{
    public partial class abbyssContext : DbContext
    {
        public virtual DbSet<Member> Member { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=abbyss;Username=abbyss;Password=valley");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>(entity =>
                    {
                    entity.ToTable("member");

                    entity.HasIndex(e => e.Account)
                    .HasName("member_account_key")
                    .IsUnique();

                    entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("uuid_generate_v4()");

                    entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnName("account");

                    entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("time")
                    .HasDefaultValueSql("('now'::text)::time with time zone");

                    entity.Property(e => e.Name)
                        .IsRequired()
                        .HasColumnName("name");

                    entity.Property(e => e.Password)
                        .IsRequired()
                        .HasColumnName("password");

                    entity.Property(e => e.Phone).HasColumnName("phone");
                    });
        }
    }
}
