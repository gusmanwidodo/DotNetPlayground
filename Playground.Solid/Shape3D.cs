namespace Playground.Solid
{
    public class Shape3D : IArea, IVolume
    {        
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public double Area()
        {
            return Width * Height;
        }

        public double Volume()
        {
            return Area() * Length;
        }
    }
}