using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle figure = new Circle(30, 50, 60);

            //Circle clonedFigure = figure.Clone() as Circle;
            Circle clonedFigure = figure.DeepCopy() as Circle;
            figure.Point.X = 100; // изменяем координаты начальной фигуры
            figure.GetInfo(); // figure.Point.X = 100
            clonedFigure.GetInfo(); // clonedFigure.Point.X = 100
            //Console.ReadKey();
        }
    }
    [Serializable]
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    [Serializable]
    class Circle : IFigure
    {
        int radius;
        
        public Point Point { get; set; }
        public Circle(int r, int x, int y)
        {
            radius = r;
            this.Point = new Point { X = x, Y = y };
        }

        public IFigure Clone()
        {
            return this.MemberwiseClone() as IFigure;
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Point.X, Point.Y);
        }

        internal object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
                binaryFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binaryFormatter.Deserialize(tempStream);
            }
            return figure;
        }
    }
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
