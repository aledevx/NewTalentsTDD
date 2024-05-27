namespace NewTalents.Tests;

public class CalculadoraTests
{
    public Calculadora PrepararCalc() 
    {
        return new Calculadora();
    }

    [Fact]
    public void Somar_5E4_Retornar9()
    {
        var calc = PrepararCalc();

        int result = calc.Somar(5, 4);

        Assert.Equal(9, result);
    }
    [Theory]
    [InlineData (1, 2, 3)]
    public void Somar_DoisNumerosInteiros_RetornaASomaDeles(int val1, int val2, int resultCalculadora)
    {
        var calc = PrepararCalc();

        int result = calc.Somar(val1, val2);

        Assert.Equal(result, resultCalculadora);
    }
    [Theory]
    [InlineData(3, 2, 1)]
    public void Subtrair_DoisNumerosInteiros_RetornaASubtracaoDeles(int val1, int val2, int resultCalculadora)
    {
        var calc = PrepararCalc();

        int result = calc.Subtrair(val1, val2);

        Assert.Equal(result, resultCalculadora);
    }
    [Theory]
    [InlineData(2, 2, 4)]
    public void Multiplicar_DoisNumerosInteiros_RetornaAMultiplicacaoDeles(int val1, int val2, int resultCalculadora)
    {
        var calc = PrepararCalc();

        int result = calc.Multiplicar(val1, val2);

        Assert.Equal(result, resultCalculadora);
    }
    [Theory]
    [InlineData(10, 2, 5)]
    public void Dividir_DoisNumerosInteiros_RetornaADivisaoDeles(int val1, int val2, int resultCalculadora)
    {
        var calc = PrepararCalc();

        int result = calc.Dividir(val1, val2);

        Assert.Equal(result, resultCalculadora);
    }
    [Fact]
    public void Dividir_DezPorZero_RetornaException()
    {
        var calc = PrepararCalc();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
    }
    [Fact]
    public void Listar_OperacoesFeitas_RetornaHistorico()
    {
        var calc = PrepararCalc();

        calc.Somar(5, 5);
        calc.Multiplicar(5, 5);
        calc.Subtrair(5, 5);
        calc.Dividir(15, 5);

        Assert.NotEmpty(calc.HistoricoOperacoes());
        Assert.Equal(3, calc.HistoricoOperacoes().Count);
    }
}