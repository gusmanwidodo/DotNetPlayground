namespace Playground.Solid
{
    public class Shape : IArea
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double Area()
        {
            return Width * Height;
        }
    }
}