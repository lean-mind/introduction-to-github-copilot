using simplificatation_of_code;

namespace TestsForFilteroToSimplify;

public class FilterToSimplifyTests
{
    [Fact]
    public void FiltrarListaCompleja_ListaVacia_RetornaListaVacia()
    {
        // Arrange
        var artifact = new Filter();
        var lista = new List<int>();

        // Act
        var resultado = artifact.FilterComplexList(lista);

        // Assert
        Assert.Empty(resultado);
    }

    [Fact]
    public void FiltrarListaCompleja_ListaSinElementosValidos_RetornaListaVacia()
    {
        // Arrange
        var artifact = new Filter();
        var lista = new List<int> { 1, 3, 5, 7, 9 };

        // Act
        var resultado = artifact.FilterComplexList(lista);

        // Assert
        Assert.Empty(resultado);
    }

    [Fact]
    public void FiltrarListaCompleja_ListaConElementosValidos_RetornaListaFiltrada()
    {
        // Arrange
        var artifact = new Filter();
        var lista = new List<int> { 12, 15, 30, 45, 60 };

        // Act
        var resultado = artifact.FilterComplexList(lista);

        // Assert
        var esperado = new List<int> { 30 };
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void FiltrarListaCompleja_ListaConElementosMixtos_RetornaListaFiltrada()
    {
        // Arrange
        var artifact = new Filter();
        var lista = new List<int> { 5, 12, 18, 25, 30, 50, 55 };

        // Act
        var resultado = artifact.FilterComplexList(lista);

        // Assert
        var esperado = new List<int> { 30 };
        Assert.Equal(esperado, resultado);
    }
}