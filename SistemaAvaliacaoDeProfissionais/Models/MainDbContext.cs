using Microsoft.EntityFrameworkCore;

namespace SistemaAvaliacaoDeProfissionais.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<PeriodoAvaliacao> PeriodosAvaliacao { get; set; }
        public DbSet<Periodos> Periodos { get; set; }
        public DbSet<PlanoDeAcao> PlanosDeAcao { get; set; }
        public DbSet<Profissionais> Profissionais { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<RegistroDeAdvertencias> RegistroDeAdvertencias { get; set; }
        public DbSet<ResultadoAvaliacao> ResultadoAvaliacoes { get; set; }
        public DbSet<Setores> Setores { get; set; }
        public DbSet<StatusAvaliacao> StatusAvaliacoes { get; set; }
        public DbSet<TipoCargo> TipoCargos { get; set; }
        public DbSet<UsuariosExclusivos> UsuariosExclusivos { get; set; }
        public DbSet<Gestores> Gestores { get; set; }
    }
}
