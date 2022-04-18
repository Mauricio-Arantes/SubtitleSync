using System;
using System.IO;
using NUnit.Framework;
using SubtitleSync;

namespace TestSubtitleSync;

public class Tests
{
    private const string FilePath = @"C:\Users\noob-\RiderProjects\SubtitleSync\SubtitleSync\temp\example.srt";

    [Test]
    public void Test1()
    {
        Console.Write(Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.WorkDirectory)));
        
        SyncTime.Main(FilePath, 1000);
        
        Assert.Pass();
    }
}