namespace artifactWithoutNaming;

public class ArtifactTests
{
    [Fact]
    public void happy_path()
    {
        var artifact = new Artifact();
        
        Assert.Equal(new List<string>() {"e,o,o"}, artifact.process("hello world"));
    }
    
    [Fact]
    public void edge_case()
    {
        var artifact = new Artifact();

        Assert.Equal(new List<string>() {}, artifact.process("thnks!"));
    }
}