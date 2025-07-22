using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EcommProj.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RevaCartMst> RevaCartMst { get; set; }
        public virtual DbSet<RevaCategoryMst> RevaCategoryMst { get; set; }
        public virtual DbSet<RevaProductMst> RevaProductMst { get; set; }
        public virtual DbSet<RevaTransactionMst> RevaTransactionMst { get; set; }
        public virtual DbSet<RevaUserMst> RevaUserMst { get; set; }
        public virtual DbSet<RevaWishlistMst> RevaWishlistMst { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle(" ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RevaCartMst>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.Status });

                entity.ToTable("REVA_CART_MST", "IUSF");

                entity.HasIndex(e => new { e.Email, e.Status })
                    .HasName("REVA_CART_MST_PK")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID");
                    

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID");
                   

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            });

            modelBuilder.Entity<RevaCategoryMst>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.Status });

                entity.ToTable("REVA_CATEGORY_MST", "IUSF");

                entity.HasIndex(e => new { e.CategoryId, e.Status })
                    .HasName("REVA_CATEGORY_MST_PK")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID");


                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY");
                   
            });

            modelBuilder.Entity<RevaProductMst>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.Status });

                entity.ToTable("REVA_PRODUCT_MST", "IUSF");

                entity.HasIndex(e => new { e.CategoryId, e.Status })
                    .HasName("REVA_PRODUCT_MST_PK")
                    .IsUnique();

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID");
                    

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID");


                entity.Property(e => e.ProductName)
                    .HasColumnName("PRODUCT_NAME");
                   

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            });

            modelBuilder.Entity<RevaTransactionMst>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.Status });

                entity.ToTable("REVA_TRANSACTION_MST", "IUSF");

                entity.HasIndex(e => new { e.Email, e.Status })
                    .HasName("REVA_TRANSACTION_MST_PK")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL");
                    

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID");
                    

                entity.Property(e => e.Price).HasColumnName("PRICE");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID");
                    
                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.TansactionDate)
                    .HasColumnName("TANSACTION_DATE");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TRANSACTION_ID");
                    
            });

            modelBuilder.Entity<RevaUserMst>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.RoleId });

                entity.ToTable("REVA_USER_MST", "IUSF");

                entity.HasIndex(e => new { e.Email, e.RoleId })
                    .HasName("REVA_USER_MST_PK")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL");
                    

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.FullName)
                    .HasColumnName("FULL_NAME");


                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD");
                    
            });

            modelBuilder.Entity<RevaWishlistMst>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.Status });

                entity.ToTable("REVA_WISHLIST_MST", "IUSF");

                entity.HasIndex(e => new { e.Email, e.Status })
                    .HasName("REVA_WISHLIST_MST_PK")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL");
                   

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CATEGORY_ID");


                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID");
                    
            });
        }
    }
}
