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

                return profissionais;
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }

            return null;
        }

        [HttpGet("id")]
        public Profissionais ObterPorID(int id)
        {
            try
            {
                var profissional = _context.Profissionais.Include(x => x.cargo).Include(x => x.setor).Include(x => x.statusAvaliacao).FirstOrDefault();

                return profissional;
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

                if (profissional.cargo != null)
                {
                    if (profissional.cargo.tipoCargo != null)
                    {
                        _context.TipoCargos.Remove(profissional.cargo.tipoCargo);
                    }

                    _context.Cargos.Remove(profissional.cargo);
                }
                if (profissional.statusAvaliacao != null)
                {
                    _context.StatusAvaliacoes.Remove(profissional.statusAvaliacao);
                }
                if (profissional.setor != null)
                {
                    _context.Setores.Remove(profissional.setor);
                }

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }
           
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Profissionais profissional)
        {
            try
            {
                _context.Profissionais.Update(profissional);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                string erro = e.Message;
            }

            return Ok();
        }
    }
}