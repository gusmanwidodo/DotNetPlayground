﻿using System;
using System.Collections.Generic;
using Playground.Solid;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(5, 4);
            Cube cube = new Cube(5, 4, 3);

            Console.WriteLine(rectangle.Area());
            Console.WriteLine(cube.Volume());

            AreaManager areaManager = new AreaManager(new List<IArea> 
            {
                rectangle,
                cube
            });

            Console.WriteLine(areaManager.totalArea());



            // Rectangle rec1 = new Rectangle(4, 3);
            // Rectangle rec2 = new Rectangle(5, 4);
            // Circle cir1 = new Circle(5);

            // CalculateArea calcArea = new CalculateArea();

            // var result = calcArea.Result(new List<IArea> 
            // {
            //     new RectangleArea(rec1), 
            //     new RectangleArea(rec2),
            //     new CircleArea(cir1),
            //     new TriangleArea(new Triangle(10, 4))
            // });

            // Console.WriteLine("Result: " + result);
        }
    }
}