using System.Collections.ObjectModel;

/*namespace AlunoAPI.Models;

  public class Concurso
  {
    public Concurso()
    {
        Inscricoes = new Collection<Inscricao>();
    }
    public int CodConc { get; set; }
    public string? Nome { get; set; }

    public ICollection<Inscricao>? Inscricoes { get; set; }
  }
*/


using System.ComponentModel.DataAnnotations;

namespace AlunoAPI.Models
{
    public class Concurso
    {
        public Concurso()
        {
            Inscricoes = new Collection<Inscricao>();
        }

        [Key]
        public int CodConc { get; set; }
        public string? Nome { get; set; }

        public ICollection<Inscricao>? Inscricoes { get; set; }
    }
}
