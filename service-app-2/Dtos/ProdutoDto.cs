using System.ComponentModel.DataAnnotations;

namespace service_app_2.Dtos
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Preco é obrigatorio")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "O campo Quantidade é obrigatorio")]
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}
