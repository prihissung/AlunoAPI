using AlunoAPI.Context;
using AlunoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlunoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConcursoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ConcursoController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Concurso>> Get()
        {
            return _context.Concursos.ToList();
        }

        [HttpPost]
        public ActionResult Post(Concurso concurso)
        {
            if (concurso is null)
                return BadRequest();
            _context.Concursos.Add(concurso);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterConcourso",
                new { id = concurso.CodConc }, concurso);
        }
    }
}
