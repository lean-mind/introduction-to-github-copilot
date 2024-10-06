namespace Conversiones;


public class MultidisciplinarTeamCreatorTests
{
    [Fact]
    public void _1()
    {
        object zeben = new
        {
            name = "Zeben",
            age = 18,
            bachellor = "Computer Science",
        };
        var multiDisciplinarTeamCreator = new MultiDisciplinarTeamCreator();

        var teams = multiDisciplinarTeamCreator.createWith(new List<object> { zeben });
        
        bool isZebenInOnlyOneSublist = teams.Count(sublist => sublist.Any(item => item == zeben)) == 1;
        Assert.True(isZebenInOnlyOneSublist, "Zeben should be in only one sublist");
    }
    
    
    [Fact]
    public void _2()
    {
        object zeben = new
        {
            name = "Zeben",
            age = 18,
            bachellor = "Computer Science",
        };
        object agoney = new
        {
            name = "Agoney",
            age = 20,
            bachellor = "Philosophy",
        };
        
        var multiDisciplinarTeamCreator = new MultiDisciplinarTeamCreator();

        var teams = multiDisciplinarTeamCreator.createWith(new List<object> { zeben, agoney });
        
        bool isZebenInOnlyOneSublist = teams.Count(sublist => sublist.Any(item => item == zeben)) == 1;
        bool isAgoneyInOnlyOneSublist = teams.Count(sublist => sublist.Any(item => item == agoney)) == 1;
        Assert.True(isZebenInOnlyOneSublist, "Zeben should be in only one sublist");
        Assert.True(isAgoneyInOnlyOneSublist, "Agoney should be in only one sublist");
        
    }
    
    [Fact]
    public void _3()
    {
        object zeben = new { name = "Zeben", bachellor = "Biochemistry", };
        object agoney = new { name = "Agoney", bachellor = "Philosophy", };
        object marta = new { name = "Marta", bachellor = "Computer Science"};
        var multiDisciplinarTeamCreator = new MultiDisciplinarTeamCreator();

        var teams = multiDisciplinarTeamCreator.createWith(new List<object> { zeben, agoney, marta });
        
        Assert.Single(teams);
    }
    
    [Fact]
    public void _4()
    {
        object zeben = new { name = "Zeben", bachellor = "Computer Science", };
        object agoney = new { name = "Agoney", bachellor = "Philosophy"};
        object marta = new { name = "Marta", bachellor = "Computer Science"};
        var multiDisciplinarTeamCreator = new MultiDisciplinarTeamCreator();

        var teams = multiDisciplinarTeamCreator.createWith(new List<object> { zeben, agoney, marta });
        
        bool isAgoneyWithMartaOrZeben = teams.Any(sublist => sublist.Contains(agoney) && (sublist.Contains(marta) || sublist.Contains(zeben)));
        bool isMartaOrZebenAlone = teams.Any(sublist => sublist.Contains(marta) && !sublist.Contains(zeben)) || teams.Any(sublist => sublist.Contains(zeben) && !sublist.Contains(marta));
        Assert.True(isAgoneyWithMartaOrZeben, "Agoney should be with Marta or Zeben");
        Assert.True(isMartaOrZebenAlone, "Marta or Zeben should be alone");
    }
    
    [Fact]
    public void _5()
    {
        object zeben = new { name = "Zeben", bachellor = "Computer Science", };
        object agoney = new { name = "Agoney", bachellor = "Philosophy", };
        object marta = new { name = "Marta", age = 20, bachellor = "Computer Science", };
        object lucia = new { name = "Marta", age = 20, bachellor = "Law"};
        var multiDisciplinarTeamCreator = new MultiDisciplinarTeamCreator();

        var teams = multiDisciplinarTeamCreator.createWith(new List<object> { zeben, agoney, marta, lucia });
        
        var thereIsOneComputerSciencePerTeam = teams.All(sublist => sublist.Count(student => student.GetType().GetProperty("bachellor").GetValue(student, null) == "Computer Science") == 1);
        Assert.Equal(2, teams.Count);
        Assert.True(thereIsOneComputerSciencePerTeam);
        Assert.All(teams, sublist => Assert.Equal(2, sublist.Count));
    }
}