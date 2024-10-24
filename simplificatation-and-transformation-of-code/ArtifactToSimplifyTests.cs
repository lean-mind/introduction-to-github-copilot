namespace simplificatation_of_code;

class Artifact
{
    public List<int> FiltrarListaCompleja(List<int> lista)
    {
        List<int> resultado = new List<int>();
        foreach (var item in lista)
        {
            if (item % 2 == 0)
            {
                if (item > 10)
                {
                    if (item < 50)
                    {
                        resultado.Add(item);
                    }
                }
            }
        }

        List<int> resultadoFinal = new List<int>();
        foreach (var item in resultado)
        {
            if (item % 3 == 0)
            {
                resultadoFinal.Add(item);
            }
        }

        List<int> resultadoFinalFinal = new List<int>();
        foreach (var item in resultadoFinal)
        {
            if (item % 5 == 0)
            {
                resultadoFinalFinal.Add(item);
            }
        }

        return resultadoFinalFinal;
    }
}

public class ArtifactToSimplifyTests
{
    [Fact]
    public void FiltrarListaCompleja_ListaVacia_RetornaListaVacia()
    {
        // Arrange
        var artifact = new Artifact();
        var lista = new List<int>();

        // Act
        var resultado = artifact.FiltrarListaCompleja(lista);

        // Assert
        Assert.Empty(resultado);
    }

    [Fact]
    public void FiltrarListaCompleja_ListaSinElementosValidos_RetornaListaVacia()
    {
        // Arrange
        var artifact = new Artifact();
        var lista = new List<int> { 1, 3, 5, 7, 9 };

        // Act
        var resultado = artifact.FiltrarListaCompleja(lista);

        // Assert
        Assert.Empty(resultado);
    }

    [Fact]
    public void FiltrarListaCompleja_ListaConElementosValidos_RetornaListaFiltrada()
    {
        // Arrange
        var artifact = new Artifact();
        var lista = new List<int> { 12, 15, 30, 45, 60 };

        // Act
        var resultado = artifact.FiltrarListaCompleja(lista);

        // Assert
        var esperado = new List<int> { 30 };
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void FiltrarListaCompleja_ListaConElementosMixtos_RetornaListaFiltrada()
    {
        // Arrange
        var artifact = new Artifact();
        var lista = new List<int> { 5, 12, 18, 25, 30, 50, 55 };

        // Act
        var resultado = artifact.FiltrarListaCompleja(lista);

        // Assert
        var esperado = new List<int> { 30 };
        Assert.Equal(esperado, resultado);
    }
}