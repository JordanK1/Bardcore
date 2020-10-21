using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Bardcore.Models;

namespace Bardcore.Models
{
    public partial class BardcoreContext : DbContext
    {
        public BardcoreContext()
        {
        }

        public BardcoreContext(DbContextOptions<BardcoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserProfile> UserProfile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=Bardcore;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.HasIndex(e => e.UserAccountId)
                    .HasName("UQ__UserProf__1918BBDBEA140974")
                    .IsUnique();

                entity.Property(e => e.Bio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoPath)
                    .HasColumnName("photoPath")
                    .IsUnicode(false);

                entity.Property(e => e.UserAccountId)
                    .HasColumnName("user_account_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }

        public DbSet<Bardcore.Models.SongInfo> SongInfo { get; set; }

        public DbSet<Bardcore.Models.UserPlaylist> UserPlaylist { get; set; }
    }
}
