namespace Playground.Solid
{
    public class CircleArea : IArea
    {
        private readonly Circle _circle;

        public CircleArea(Circle circle)
        {
            _circle = circle;
        }

        public double Area()
        {
            return _circle.Radius * _circle.Radius * _circle.Phi;
        }
    }
}
