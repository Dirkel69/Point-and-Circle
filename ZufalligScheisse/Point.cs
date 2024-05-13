using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ZufalligScheisse
{
    internal class Point
    {
        int x, y;
        public Point() => this.x = this.y = 0;
        public Point(int x, int y) => (this.x, this.y) = y < 0 ? (x, 0) : (x, y);
        public void SetX(int x) => this.x = x;
        public void SetY(int y)
        { if (y > 0) this.y = y; else Console.WriteLine("Unallowed y value."); }
        public int GetX() => this.x;
        public int GetY() => this.y;
        public double Disctance() => Math.Sqrt(this.x * this.x + this.y * this.y);
        public bool IsBigger(Point p) => this.y > p.y;

    }
}
