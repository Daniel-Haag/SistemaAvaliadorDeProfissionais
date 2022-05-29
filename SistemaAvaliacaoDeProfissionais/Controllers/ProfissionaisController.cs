using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaAvaliacaoDeProfissionais.Models;

namespace SistemaAvaliacaoDeProfissionais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfissionaisController : ControllerBase
    {

        private readonly MainDbContext _context;

        public ProfissionaisController(MainDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Profissionais> Obter()
        {
            try
            {
                List<Profissionais> profissionais = _context.Profissionais.Include(x => x.cargo).Include(x => x.setor).Include(x => x.statusAvaliacao).ToList();

                //List<object> profissionaisObject = new List<object>();

                //foreach (var item in profissionais)
                //{
                //    object profissional = new
                //    {
                //        ProfissionalID = item.profissionalID,
                //        Nome = item.nome,
                //        UserName = item.userName,
                //        Senha = item.senha,
                //        Matricula = item.matricula,
                //        Setor = item.setor.nomeSetor ?? "",
                //        Cargo = item.cargo.nomeCargo ?? "",
                //        Admissao = item.admissao/*.ToString("dd/MM/yyyy")*/,
                //        Gestor = item.gestor,
                //        StatusAvaliacao = item.statusAvaliacao.nomeStatusAvaliacao ?? ""
                //    };

                //    profissionaisObject.Add(profissional);
                //}

                return profissionais;
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }

            return null;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Profissionais profissional)
        {
            try
            {
                _context.Profissionais.Add(profissional);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }
           
            return Ok();
        }

        [HttpGet("{id}")]
        public IEnumerable<object> ObterPorID(int id)
        {
            List<Profissionais> profissionais = _context.Profissionais.Where(x => x.profissionalID == id).Include(x => x.cargo).Include(x => x.setor).Include(x => x.statusAvaliacao).ToList();

            List<object> profissionaisObject = new List<object>();

            foreach (var item in profissionais)
            {
                object profissional = new
                {
                    ProfissionalID = item.profissionalID,
                    Nome = item.nome,
                    UserName = item.userName,
                    Senha = item.senha,
                    Matricula = item.matricula,
                    Setor = item.setor.nomeSetor ?? "",
                    Cargo = item.cargo.nomeCargo ?? "",
                    Admissao = item.admissao/*.ToString("dd/MM/yyyy")*/,
                    Gestor = item.gestor,
                    StatusAvaliacao = item.statusAvaliacao.nomeStatusAvaliacao ?? ""
                };

                profissionaisObject.Add(profissional);
            }

            return profissionaisObject;
        }

        


    }
}