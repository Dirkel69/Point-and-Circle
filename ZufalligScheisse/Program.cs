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
    }
}