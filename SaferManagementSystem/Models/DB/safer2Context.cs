using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SaferManagementSystem.Models.DB
{
    public partial class safer2Context : DbContext
    {
        

        public safer2Context()
        {
        }

        public safer2Context(DbContextOptions<safer2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Aspecto> Aspectos { get; set; }
        public virtual DbSet<Comportamiento> Comportamientos { get; set; }
        public virtual DbSet<Criticidad> Criticidads { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Historial> Historials { get; set; }
        public virtual DbSet<Puesto> Puestos { get; set; }
        public virtual DbSet<RObservacion> RObservacions { get; set; }
        public virtual DbSet<Sexo> Sexos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-PMTQBSN\\SQLEXPRESS; Database=safer2; Trusted_Connection=True;");
            }
        }

        internal Task ToListAsync()
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("area");

                entity.Property(e => e.AreaId).HasColumnName("areaId");

                entity.Property(e => e.NomArea)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Aspecto>(entity =>
            {
                entity.ToTable("aspecto");

                entity.Property(e => e.AspectoId).HasColumnName("aspectoId");

                entity.Property(e => e.NomAspec)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom_aspec");
            });

            modelBuilder.Entity<Comportamiento>(entity =>
            {
                entity.ToTable("comportamiento");

                entity.Property(e => e.ComportamientoId).HasColumnName("comportamientoId");

                entity.Property(e => e.NombreCom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre_com");
            });

            modelBuilder.Entity<Criticidad>(entity =>
            {
                entity.ToTable("criticidad");

                entity.Property(e => e.CriticidadId).HasColumnName("criticidadId");

                entity.Property(e => e.NomCri)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom_cri");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("departamento");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.NomDeartamento)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Historial>(entity =>
            {
                entity.ToTable("historial");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccionRealizada)
                    .IsRequired()
                    .HasColumnName("accion_realizada");

                entity.Property(e => e.AreaId).HasColumnName("areaId");

                entity.Property(e => e.AspectoId).HasColumnName("aspectoId");

                entity.Property(e => e.ComportamientoId).HasColumnName("comportamientoId");

                entity.Property(e => e.Criticidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("criticidad");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("estatus");

                entity.Property(e => e.FechaRe)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_re");

                entity.Property(e => e.ObseA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("obse_a");

                entity.Property(e => e.PersonasRetro).HasColumnName("personas_retro");

                entity.Property(e => e.ResponsableSeguimiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("responsable_seguimiento");

                entity.Property(e => e.TipoObservacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tipo_observacion");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.Idpuesto);

                entity.ToTable("puesto");

                entity.Property(e => e.Puesto1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("puesto")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RObservacion>(entity =>
            {
                entity.ToTable("r_Observacion");

                entity.HasIndex(e => e.DepartamentoId, "IX_r_Observacion_departamentoId")
                    .IsUnique();

                entity.Property(e => e.AccionRealizada)
                    .IsRequired()
                    .HasColumnName("accion_realizada");

                entity.Property(e => e.AreaId).HasColumnName("areaId");

                entity.Property(e => e.AspectoId).HasColumnName("aspectoId");

                entity.Property(e => e.ComportamientoId).HasColumnName("comportamientoId");

                entity.Property(e => e.Criticidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("criticidad");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("estatus");

                entity.Property(e => e.FechaRe).HasColumnName("fecha_re");

                entity.Property(e => e.ObseA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("obse_a");

                entity.Property(e => e.PersonasRetro).HasColumnName("personas_retro");

                entity.Property(e => e.ResponsableSeguimiento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("responsable_seguimiento");

                entity.Property(e => e.TipoObservacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tipo_observacion");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Departamento)
                    .WithOne(p => p.RObservacion)
                    .HasForeignKey<RObservacion>(d => d.DepartamentoId);
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.ToTable("sexo");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("genero");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuario");

                entity.HasIndex(e => e.DepartamentoId, "IX_usuario_departamentoId")
                    .IsUnique();

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnName("contraseña");

                entity.Property(e => e.DepartamentoId).HasColumnName("departamentoId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Numeroempleado).HasColumnName("numeroempleado");

                entity.Property(e => e.Privilegio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("privilegio");

                entity.Property(e => e.Puesto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("puesto");

                entity.Property(e => e.SexoId).HasColumnName("sexoId");

                entity.HasOne(d => d.Departamento)
                    .WithOne(p => p.Usuario)
                    .HasForeignKey<Usuario>(d => d.DepartamentoId)
                    .HasConstraintName("FK_usuario_departamento_departamentoId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
