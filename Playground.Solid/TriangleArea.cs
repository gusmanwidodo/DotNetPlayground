namespace Playground.Solid
{
    public class TriangleArea : IArea
    {
        private readonly Triangle _triangle;

        public TriangleArea(Triangle triangle)
        {
            _triangle = triangle;
        }

        public double Result()
        {
            return _triangle.Width * _triangle.Height * 0.5;
        }
    }
}