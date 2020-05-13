using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Domain;

namespace Restaurante.Data.Map
{
    public class TipoPratoMap : IEntityTypeConfiguration<TipoPrato>
    {
        public void Configure(EntityTypeBuilder<TipoPrato> builder)
        {
            builder.ToTable("TipoPrato");

            builder.HasKey(k => k.Id);

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasMany<Prato>(p => p.Pratos)
                .WithOne(tp => tp.TipoPrato)
                .HasForeignKey(p => p.IdTipoPrato);
        }
    }
}
