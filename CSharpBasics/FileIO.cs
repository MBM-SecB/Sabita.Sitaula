using System;
using System.IO;
public class FileIO
{
    public void LearnFileHandling()
    {
        File.Exists()
        var fileContent = File.ReadAllText(@"C:\6th sem\net centric\sabita sitaula\Sabita.Sitaula\README.md");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(fileContent);
    }
}

public void LearnDirectory()
{
    string  folderpath="MBM";
    Directory.CreateDirectory();
}

//create a folder "nepal", with in that create 10 sub folders.
//every subfolders should contain a file text.txt which subfolder name as a content. 
