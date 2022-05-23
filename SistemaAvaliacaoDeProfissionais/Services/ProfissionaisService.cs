using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaAvaliacaoDeProfissionais.Models;

namespace SistemaAvaliacaoDeProfissionais.Services
{
    public class ProfissionaisService
    {

        private readonly MainDbContext _context;

        public ProfissionaisService(MainDbContext context)
        {
            _context = context;
        }

        public List<Profissionais> obterProfissionais()
        {
            List<Profissionais> profissionais = _context.Profissionais.ToList();

            return profissionais;   
        }

        //Criar método para definir cargo
        public string obterCargoProfissional(Profissionais profissional)
        {


            return "";
        }
        //Criar método para definir gestor
        //Criar método para definir setor
        //Criar método para definir status

        //Acho que criando as respectivas controllers de cada modelo eu terei estas informações


    }
}
