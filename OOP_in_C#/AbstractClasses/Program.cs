using System;

namespace AbstractClasses
{
    abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }
        // abstract classes can content normal methods
        public int CalculateArea()
        {
            return this.Width * this.Height;
        }

        public abstract void Draw();
    }

    class Square : Shape
    {
        public Square(int w, int h) : base(w, h)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Square");
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int w, int h) : base(w, h)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new Shape[3];
            shapes[0] = new Rectangle(10, 15);
            shapes[1] = new Square(15, 15);
            shapes[2] = new Rectangle(15, 18);

            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine($"Area : {shape.CalculateArea()}");
            }
        }

        
    }
}
