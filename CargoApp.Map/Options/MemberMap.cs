using CargoApp.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.Bson;

namespace CargoApp.Map.Options;

public class MemberMap : IEntityTypeConfiguration<Member>
{
    public virtual void Configure(EntityTypeBuilder<Member> builder)
    {
        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(25);
        
        builder
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(25);

    }
}