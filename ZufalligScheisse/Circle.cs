using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZufalligScheisse
{
    internal class Circle
    {
        Point center;
        int radius;
        public Circle() => (this.center , this.radius) = (new Point(), 0);
        public Circle(Point center, int radius) => (this.center, this.radius) = (radius >= 0) ? (center, radius) : (center, 0);
        public void SetR(int r) => this.radius = Math.Abs(r);
        public void SetX(int x) => this.center.SetX(x);
        public void SetY(int y)
        {
            if(y >= 0)
                this.center.SetY(y);
            else
                Console.WriteLine("Unallowed y value.");
        }
        public int GetR() => this.radius;
        public int GetX() => this.center.GetX();
        public int GetY() => this.center.GetY();
        public bool IsBigger(Circle otherCircle) => this.radius > otherCircle.radius;
    }
}
