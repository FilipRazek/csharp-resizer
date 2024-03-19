namespace sample1;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;


class Program
{
    static void Main(string[] args)
    {
        ImageResizer.ResizeImages("input", "output", 1, 3);
    }
}
