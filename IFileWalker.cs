interface IFileWalker {
    void Walk(string inputDir, Action<string> processFile);
}