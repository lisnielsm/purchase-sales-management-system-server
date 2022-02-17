using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Usuarios;
using System;

namespace Sistema.Datos.Mapping.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario").HasKey(u => u.idusuario);
            builder.HasOne(u => u.rol)
                    .WithMany(r => r.usuarios)
                    .HasForeignKey(u => u.idrol);
        }
    }
}
