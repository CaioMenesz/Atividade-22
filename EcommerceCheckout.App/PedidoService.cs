public class PedidoService
{
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        return $"{regiao}-{numeroPedido:D4}";
    }

    public decimal CalcularPontosFidelidade(int valorTotal)
    {
        int metaValorPonto = 10;
        decimal resultado = (valorTotal / metaValorPonto) * 2; // nPontos
        return resultado;
    }

    public bool TemFreteGratis(decimal valorCompra)
    {
        if (valorCompra >= 150)
        {
            return true;
        }
        return false;
    }
}