using System.Collections.Generic;

namespace Playground.Solid
{
    public class CalculateArea
    {
        public double Result(List<IArea> areas)
        {
            double totalArea = 0;

            foreach (var area in areas)
            {
                totalArea += area.Area();
            }

            return totalArea;
        }
    }
}