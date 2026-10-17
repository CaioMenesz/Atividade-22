namespace EcommerceCheckout.Tests;

public class UnitTest1
{
    [Fact]
    public void GerarCodigoRastreio()
    {
        var resultado = new PedidoService().GerarCodigoRastreio("SP", 42);
        Assert.Equal("SP-0042", resultado);
    }

    [Fact]
    public void CalcularPontosFidelidade()
    {
        var resultado = new PedidoService().CalcularPontosFidelidade(150);
        Assert.Equal(30, resultado);
    }

    [Fact]
    public void TemFreteGratis()
    {
        var resultado = new PedidoService().TemFreteGratis(200);
        Assert.True(resultado);
    }
}
