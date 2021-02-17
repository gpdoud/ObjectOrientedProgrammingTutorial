﻿using System;

namespace ObjectOrientedProgrammingTutorial {
    class Program {

        static void Main(string[] args) {

            Quad X = new Sqr(3);

            var sqr1 = new Sqr(7);
            Console.WriteLine($"SQR: Perimeter is {sqr1.Perimeter()}");
            Console.WriteLine($"SQR: Area is {sqr1.Area()}");
            Console.WriteLine($"SQR: Print is {sqr1.Print()}");

            var rect1 = new Rect(5, 7);
            Console.WriteLine($"RECT: Perimeter is {rect1.Perimeter()}");
            Console.WriteLine($"RECT: Area is {rect1.Area()}");
            //Console.WriteLine($"About is {rect1.About}");

            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"QUAD: Perimeter is {quad1.Perimeter()}");

            var shapes = new Quad[] { sqr1, rect1, quad1 };
            foreach(var shape in shapes) {
                Console.WriteLine($"shape is a {shape.Print()}");
                //Console.WriteLine($"shape's area is {shape.Area()}");
                var rect = shape as Rect;
                if(rect != null) {
                    Console.WriteLine($"shape's area is {rect.Area()}");
                } else {
                    Console.WriteLine("The shape is a quad");
                }
            }
        }
    }
}
