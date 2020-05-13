using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Restaurante.Domain;

namespace Restaurante.Data.Map
{
    public class AgendaCardapioMap : IEntityTypeConfiguration<AgendaCardapio>
    {
        public void Configure(EntityTypeBuilder<AgendaCardapio> builder)
        {
            builder.ToTable("AgendaCardapio");

            builder.HasKey(k => new { k.IdAgenda, k.IdCardapio });

            builder.HasOne(a => a.Agenda)
                .WithMany(ac => ac.AgendaCardapios)
                .HasForeignKey(a => a.IdAgenda);

            builder.HasOne(c => c.Cardapio)
                .WithMany(ca => ca.agendaCardapios)
                .HasForeignKey(c => c.IdCardapio);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
