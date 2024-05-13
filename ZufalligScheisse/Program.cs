using System.Reflection.Metadata.Ecma335;

namespace ZufalligScheisse
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Point
            Point point1 = new Point(3, 4);
            Console.WriteLine(point1.Disctance());
            point1.SetY(-2);
            Print(point1);//(3, 4)
            Point point2 = new Point(7, -2);
            Print(point2);//(7, 0)
            Console.WriteLine(point1.IsBigger(point2));//true
            


            //Circle
            point1 = null;
            point2 = null;
            Point point1 = new Point(3, 4);
            Circle c1 = new Circle(point1, 5);
            Console.WriteLine(c1.Distance());
            c1.SetY(-2);
            c1.Print();//(3, 2), radius = 5
            Circle c2 = new Circle(new Point(7, -2), 3);
            c2.Print();//(7, 0), radius = 3
            Console.WriteLine(c1.IsBigger(c2));//true


        }


        //Point functions
        public static void Print(Point p) => Console.WriteLine($"({p.GetX()},{p.GetY()})");
        public static void Swap(Point p1)
        {
            int temp = p1.GetX();
            p1.SetX(p1.GetY());
            p1.SetY(temp > 0 ? temp : 0);
        }
        public static void Subtract(Point p1, int num)
        {
            p1.SetX(p1.GetX() - num);
            if(num>p1.GetY())
                p1.SetY(0);
            else
                p1.SetY(p1.GetY() - num);
        }
        public static void Swap(Point p1, Point p2)
        {
            int temp = p1.GetX();
            p1.SetX(p2.GetX());
            p2.SetX(temp);
            temp = p1.GetY();
            p1.SetY(p2.GetY());
            p2.SetY(temp);
        }
        public static Point CreateRandomPoint() => new Point(new Random().Next(-100, 100), new Random().Next(0, 100));
        public static Point[] CreateArrayOfPoints(int size)
        {
            Point[] arrPoint = new Point[size];
            Enumerable.Range(0,size).ToList().ForEach(i => arrPoint[i] = CreateRandomPoint());
            return arrPoint;
        }
        public static void Print(Point[] arr) => arr.ToList().ForEach(p => Console.WriteLine($"({p.GetX()},{p.GetY()})"));
        public static Point Highest(Point[] arr)
        {
            Point res = arr[0];
            arr.ToList().ForEach(p => { if (p.IsBigger(res)) res = p; });
            return res;
        }
        public static Point FarFarAway(Point[] arr)
        {
            Point res = arr[0];
            arr.ToList().ForEach(p => { if (p.Disctance() > res.Disctance()) res = p; });
            return res;
        }


        //Circle functions
        public static void Print(Circle c) => Console.WriteLine($"({c.GetCenter().GetX()},{c.GetCenter().GetY()}), radius = {c.GetRadius()}");
        public static double Area(Circle c) => Math.PI * c.GetRadius() * c.GetRadius();
        public static void Subtract(Circle c1, int num)
        {
            c1.SetX(c1.GetX() - num);
            if(num <= c1.GetY())
                c1.SetY(c1.GetY() - num);
        }
        public static void Swap(Circle c1, Circle c2)
        {
            Point temp = c1.GetCenter();
            c1.SetCenter(c2.GetCenter());
            c2.SetCenter(temp);
        }
        public static bool Inside(Circle c1) => c1.GetR() >= c1.Distance();
        public static Circle[] CreateArrayOfCircles(int size)
        {
            Circle[] arrCircle = new Circle[size];
            Enumerable.Range(0,size).ToList().ForEach(i => arrCircle[i] = new Circle(CreateRandomPoint(), new Random().Next(0, 100)));
            return arrCircle;
        }
        public static void printBiggest(Circle[] arr)
        {
            Circle res = arr[0];
            arr.ToList().ForEach(c => { if (c.IsBigger(res)) res = c; });
            Print(res);
        }
        public static void DeleteCircles(Circle[] arr)
        {
            Circle[] res = arr.Where(c => c.GetR() < c.Distance()).ToArray();
            Console.WriteLine($"Deleted: {arr.Length=res.Length}");
            arr = res;
        }
        public static void BringDown(Circle[] arr) => Enumerable.Range(0,arr.Length).ToList().ForEach(i => arr[i].SetY(arr[i].GetY() >=5 ? arr[i].GetY() - 5 : arr[i].GetY()));
    }
}