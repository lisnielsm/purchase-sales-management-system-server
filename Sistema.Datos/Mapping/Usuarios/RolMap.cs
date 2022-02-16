using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistema.Entidades.Usuarios;

namespace Sistema.Datos.Mapping.Usuarios
{
    public class RolMap : IEntityTypeConfiguration <Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("rol").HasKey(r => r.idrol);
            builder.Property(r => r.nombre).HasMaxLength(50);
            builder.Property(r => r.descripcion).HasMaxLength(256);
        }
    }
}
