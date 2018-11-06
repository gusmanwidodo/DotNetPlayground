using System.Collections.Generic;

namespace Playground.Solid
{
    public class AreaManager
    {
        private readonly List<IArea> _areas;

        public AreaManager(List<IArea> areas)
        {
            _areas = areas;
        }

        public double totalArea()
        {
            CalculateArea calculate = new CalculateArea();

            return calculate.Result(_areas);
        }
    }
}