﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LinkHide.Entities
{
    public partial class LinkHideContext : DbContext
    {
        public LinkHideContext()
        {
        }

        public LinkHideContext(DbContextOptions<LinkHideContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HiddenLink> HiddenLinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=linkhidesqldev.database.windows.net;Initial Catalog=linkhidesqldev;Persist Security Info=True;User ID=linkhideadmin;Password=7WEQL83GoSme");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HiddenLink>(entity =>
            {
                entity.ToTable("HiddenLinks", "LinkHide");

                entity.HasIndex(e => new { e.TokenHash, e.Token }, "IX_HiddenLinks_TokenHash_Token");

                entity.HasIndex(e => new { e.Token, e.TokenHash }, "IX_HiddenLinks_Token_TokenHash");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}