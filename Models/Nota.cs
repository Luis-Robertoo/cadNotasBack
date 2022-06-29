using System.ComponentModel.DataAnnotations;

namespace CadNotas.Models
{
    public class Nota
    {
        /*
        public Nota()
        {

        }
        */
        [Key]
        public long numCupom { get; set; }
        public string CNPJ { get; set; }
        public string canalCompra { get; set; }
        public string dataCompra { get; set; }
        public string produtosComprados { get; set; }
        public decimal valorNotaProdutos { get; set; }
        
    }
}


