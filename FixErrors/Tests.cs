using fix_errors;

namespace fix;

public class Tests
{
    
    [Test]
    public void should_read_the_content_of_files()
    {
        var reader = new Reader();
        
        var content = reader.ReadContentOf("file.txt");
        
        Assert.AreEqual("Hello, World!", content);
    }
}