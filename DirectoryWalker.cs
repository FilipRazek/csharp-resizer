namespace sample1;

class DirectoryWalker
{
    public void Walk(string inputDir, Action<string> processFile)
    {
        string[] fileEntries = Directory.GetFiles(inputDir);
        foreach (string fileName in fileEntries)
            processFile(fileName);

    }
}