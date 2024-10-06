public class Tests
{
    
    [Fact]
    public void happy_path()
    {
        var vowelExtractor = new Artifact();
        //var vowelExtractor = new VowelExtractor();
        
        Assert.Equal(new List<string>() {"e,o,o"}, vowelExtractor.extractFrom("hello world"));
    }
    
    [Fact]
    public void edge_case()
    {
        var vowelExtractor = new Artifact();
        // var vowelExtractor = new VowelExtractor();

        Assert.Equal(new List<string>() {}, vowelExtractor.extractFrom("thnks!"));
    }
}