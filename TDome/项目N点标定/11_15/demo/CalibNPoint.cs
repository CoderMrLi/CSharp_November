using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    /// <summary>
    /// 用来保存标定用的数据
    /// </summary>
    internal class CalibNPoint
    {
        public double pixX {  get; set; }

        public double pixY { get; set; }

        public double worldX { get; set; }
        public double worldY { get; set; }
    }
}
