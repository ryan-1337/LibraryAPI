using Bibliotheque.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> entity)
    {
        entity.ToTable("Clients", "bibliotheque");

        entity.Property(e => e.Id)
            .IsRequired();
        entity.Property(e => e.FirstName)
            .HasMaxLength(30)
            .IsRequired();
        entity.Property(e => e.Name)
            .HasMaxLength(30)
            .IsRequired();
        entity.Property(e => e.Mail)
            .HasMaxLength(255)
            .HasColumnType("VARCHAR(255)")
            .IsRequired();
        entity.Property(e => e.Phone)
            .HasMaxLength(10)
            .IsRequired();
        entity.Property(e => e.Password)
            .HasMaxLength(10)
            .IsRequired();
        
        entity.HasIndex(e => e.Id).IsUnique();
        entity.HasIndex(e => e.Phone).IsUnique();
    }
}