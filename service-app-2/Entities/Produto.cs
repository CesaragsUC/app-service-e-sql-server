namespace service_app_2.Entities
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set;} 

    }
}
