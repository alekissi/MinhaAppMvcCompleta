using System;


namespace DevIO.Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorID { get; set; }

        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        
        public string Imagem { get; set; }
        
        public decimal Valor { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        public bool Ativo { get; set; }

        /* EF Ralation */

        public Fornecedor Fornecedor { get; set; }
    }
}
