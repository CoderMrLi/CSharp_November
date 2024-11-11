using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionproDemo
{
    public class CalibNPoint
    {
        /// <summary>
        /// 像素坐标X
        /// </summary>
        public double Pix_X { get; set; }
        /// <summary>
        /// 像素坐标Y
        /// </summary>
        public double Pix_Y { get; set; }
        /// <summary>
        /// 世界坐标X
        /// </summary>
        public double World_X { get; set; }
        /// <summary>
        /// 世界坐标Ｙ
        /// </summary>
        public double World_Y { get; set; }

        public double FitCircleX { get; set; }
        public double FitCircleY { get; set; }

    }
}
