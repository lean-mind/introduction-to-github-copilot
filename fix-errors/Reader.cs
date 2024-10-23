namespace fix_errors;

public class Reader
{
    public string ReadContentOf(string filePath)
    {
        var file = new File(filePath);
        
        var content  = file.readLines();
        
        return content;
    }
}

/*
 *     public string ReadContentOf(string filePath)
    {
        var file = new File(filePath);
        
        var content  = file.readLines();
        
        return content;
    }
*/