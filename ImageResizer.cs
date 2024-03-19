namespace sample1;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

class ImageResizer
{
    private static DirectoryWalker _directoryWalker = new();

    public static void ResizeImages(string inputDir, string outputDir, int widthFactor, int heightFactor)
    {
        _directoryWalker.Walk(inputDir, (inputPath) => ResizeImageToDirectory(inputPath, outputDir, widthFactor, heightFactor));
    }

    private static void ResizeImageToDirectory(string inputPath, string outputDir, int widthFactor, int heightFactor)
    {
        string outputPath = $"{outputDir}/{Path.GetFileName(inputPath)}";
        ResizeImage(inputPath, outputPath, widthFactor, heightFactor);
    }

    private static void ResizeImage(string inputPath, string outputPath, int widthFactor, int heightFactor)
    {
        using (Image image = Image.Load(inputPath))
        {
            image.Mutate(x => x.Resize(image.Width / widthFactor, image.Height / heightFactor));
            image.Save(outputPath);
        }
    }
}