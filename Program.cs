namespace sample1;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;


class Program
{
    static void Main(string[] args)
    {
        using (Image image = Image.Load(@"input\img1.jpg"))
        {
            image.Mutate(x => x.Resize(image.Width / 2, image.Height / 2));
            image.Save(@"output\img1.jpg");
        }
    }
}
