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
        public IEnumerable<Profissionais> Get()
        {
            List<Profissionais> profissionais = _context.Profissionais.ToList();

            return _context.Profissionais.ToList();
        }
















        //[HttpGet]
        //public IEnumerable<Profissionais> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new Profissionais
        //    {
        //        //Date = DateTime.Now.AddDays(index),
        //        //TemperatureC = Random.Shared.Next(-20, 55),
        //        //Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}