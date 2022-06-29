namespace CadNotas
{
    public class NotasPadrao
    {
        public long numNota { get; set; }
        public string cnpj { get; set; }
        public string canalCompra { get; set; }
        public string dataCompra { get; set; }
        public List<ProdutosComprados> produtos { get; set; }
        public decimal valorTotalNota { get; set; }
    }
}
