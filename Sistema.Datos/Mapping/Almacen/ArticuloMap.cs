﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Almacen;

namespace Sistema.Datos.Mapping.Almacen
{
    public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("articulo").HasKey(a => a.idarticulo);
            builder.HasOne(a => a.categoria)
                    .WithMany(c => c.articulos)
                    .HasForeignKey(a => a.idcategoria);
        }
    }
}
