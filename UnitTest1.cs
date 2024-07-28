namespace atividade_imc_xunit;

public class UnitTest1
{
    [Fact]
    public void TesteCalculoIMC()
    {
        double imc_previsto = 31.25;
        IMC i = new IMC
        {
            peso = 80,
            altura = 1.60
        };
        i.Calcular_IMC();
        Assert.Equal(imc_previsto, i.imc);
    }

    [Fact]
    public void TesteCategoria1()
    {
        IMC i = new IMC
        {
            peso = 40,
            altura = 1.60
        };
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal("Abaixo do peso", i.categoria);
    }

    [Fact]
    public void TesteCategoria2()
    {
        IMC i = new IMC
        {
            peso = 55,
            altura = 1.60
        };
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal("Peso normal", i.categoria);
    }

    [Fact]
    public void TesteCategoria3()
    {
        IMC i = new IMC
        {
            peso = 70,
            altura = 1.60
        };
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal("Sobrepeso", i.categoria);
    }

    [Fact]
    public void TesteCategoria4()
    {
        IMC i = new IMC
        {
            peso = 80,
            altura = 1.60
        };
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal("Obesidade Grau I", i.categoria);
    }

    [Fact]
    public void TesteCategoria5()
    {
        IMC i = new IMC
        {
            peso = 100,
            altura = 1.60
        };
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal("Obesidade Grau II", i.categoria);
    }
}
