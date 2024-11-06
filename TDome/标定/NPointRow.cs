using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 标定
{
    internal class NPointRow
    {
        public double PixX {  get; set; }

        public double PixY { get; set; } 

        public double WorldX { get; set; }
        public double WorldY { get; set; }

        public NPointRow(double pixX, double pixY, double worldX, double worldY)
        {
            this.PixX = pixX;
            this.PixY = pixY;
            this.WorldX = worldX;
            this.WorldY = worldY;
        }
    }
}
