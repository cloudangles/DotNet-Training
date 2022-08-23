using System;

interface IFigure
{
int Dimension { get; set; } 
double Area();
double Perimeter();
}
class Circle : IFigure
{
    private int _Radius;
    public int Dimension
    {
        get
        {
            return _Radius;
        }
        set
        {
            _Radius = value;
        }
    }
    public double Area()
    {
        return Math.PI * _Radius * _Radius;
    }
    public double Perimeter()
    {
        return 2 * Math.PI * _Radius;
    }
    class Square : IFigure
    {
        private int _Side;
        public int Dimension
        {
            get
            {
                return _Side;
            }
            set
            {
                _Side = value;
            }
        }
        public double Area()
        {
            return _Side * _Side;
        }
        public double Perimeter()
        {
            return 4 * _Side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            if (args[0] == "S")
                fig = new Square();
            if (args[0] == "C")
                fig = new Circle();
            fig.Dimension = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());
        }
    }
}
