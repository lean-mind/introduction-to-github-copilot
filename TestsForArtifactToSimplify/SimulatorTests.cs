using Moq;
using simplificatation_of_code;


namespace TestsForArtifactToSimplify;

public class SimulatorTests
{

    [Fact]
    public void SimWeather_AllRain_AllDays()
    {
        var randomGeneratorMock = new Mock<IRandomGenerator>();
        var consoleOutputMock = new Mock<IConsoleOutput>();
        randomGeneratorMock.SetupSequence(r => r.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(20).Returns(20)
            .Returns(20);
        var simulator = new Simulator(randomGeneratorMock.Object, consoleOutputMock.Object);

        simulator.SimWeather(20, 100, 3);

        consoleOutputMock.Verify(c => c.WriteLine(It.Is<string>(s => s.Contains("It will rain"))), Times.Exactly(3));
    }

    [Fact]
    public void SimWeather_TemperatureAbove25_RainPercentageIncreases()
    {
        var randomGeneratorMock = new Mock<IRandomGenerator>();
        var consoleOutputMock = new Mock<IConsoleOutput>();
        randomGeneratorMock.SetupSequence(r => r.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(20);
        var simulator = new Simulator(randomGeneratorMock.Object, consoleOutputMock.Object);

        simulator.SimWeather(26, 50, 1);

        consoleOutputMock.Verify(c => c.WriteLine(It.Is<string>(s => s.Contains("It will rain"))), Times.Once);
    }

    [Fact]
    public void SimWeather_TemperatureDecreaseByFive_RainPercentageDecreases()
    {
        var randomGeneratorMock = new Mock<IRandomGenerator>();
        var consoleOutputMock = new Mock<IConsoleOutput>();
        randomGeneratorMock.SetupSequence(r => r.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(80).Returns(80);
        var simulator = new Simulator(randomGeneratorMock.Object, consoleOutputMock.Object);

        simulator.SimWeather(30, 50, 2);

        consoleOutputMock.Verify(c => c.WriteLine(It.Is<string>(s => s.Contains("It won't rain"))), Times.Once);
    }

    [Fact]
    public void SimWeather_TemperatureFluctuates_MinMaxTemperatureRecorded()
    {
        var randomGeneratorMock = new Mock<IRandomGenerator>();
        var consoleOutputMock = new Mock<IConsoleOutput>();
        randomGeneratorMock.SetupSequence(r => r.Next(It.IsAny<int>(), It.IsAny<int>())).Returns(50).Returns(50)
            .Returns(50).Returns(50).Returns(50).Returns(50).Returns(50);
        var simulator = new Simulator(randomGeneratorMock.Object, consoleOutputMock.Object);

        simulator.SimWeather(20, 50, 7);

        consoleOutputMock.Verify(c => c.WriteLine(It.Is<string>(s => s.Contains("Max temperature expected"))),
            Times.Once);
        consoleOutputMock.Verify(c => c.WriteLine(It.Is<string>(s => s.Contains("min temperature expected"))),
            Times.Once);
    }
}