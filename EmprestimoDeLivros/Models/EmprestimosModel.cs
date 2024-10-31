using System.ComponentModel.DataAnnotations;

namespace EmprestimoDeLivros.Models
{
    public class EmprestimosModel
    {

        //Atalho: prop + 2X Tab = criar propriedade
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }
        [Required(ErrorMessage = "Digite o nome do Livro!")]
        public string LivroEmprestado { get; set; }

        // Datetime.now = horario atual
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}
