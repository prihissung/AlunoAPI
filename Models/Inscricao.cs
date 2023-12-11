/*namespace AlunoAPI.Models;


public class Inscricao
{
    public int CodInsc { get; set; }
    public string? Nome { get; set; }
    public string? FormaIngresso { get; set; }

    public string? Status { get; set; }

    public int? CodConc { get; set; }
    public Concurso? Concurso { get; set; }

}
*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlunoAPI.Models
{
    public class Inscricao
    {
        [Key]
        public int CodInsc { get; set; }

        public string? Nome { get; set; }
        public string? FormaIngresso { get; set; }
        public string? Status { get; set; }

        public int CodConc { get; set; } // Chave estrangeira

        [ForeignKey("CodConc")]
        public Concurso? Concurso { get; set; }
    }
}

