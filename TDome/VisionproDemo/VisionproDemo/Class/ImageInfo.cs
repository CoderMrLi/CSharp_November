using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionproDemo
{
    public class ImageInfo
    {
        /// <summary>
        /// 原始图像
        /// </summary>
        public CogImage8Grey Image8Grey { get; set; }
        /// <summary>
        /// 图像名称
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// CogRecordDisplay
        /// </summary>
        public CogRecordDisplay ImageDisplay { get; set; }
    }
}
