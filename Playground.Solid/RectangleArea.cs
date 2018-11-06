namespace Playground.Solid
{
    public class RectangleArea : IArea
    {
        private readonly Rectangle _rectangle;

        public RectangleArea(Rectangle rectangle)
        {
            _rectangle = rectangle;

        }

        public double Area()
        {
            return _rectangle.Width * _rectangle.Height;
        }
    }
}