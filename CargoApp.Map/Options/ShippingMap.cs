using CargoApp.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CargoApp.Map.Options;

public class ShippingMap : IEntityTypeConfiguration<Shipping>
{
    public virtual void Configure(EntityTypeBuilder<Shipping> builder)
    {
       

    }
}