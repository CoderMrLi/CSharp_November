using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionproDemo
{
    /// <summary>
    /// 文件操作类
    /// </summary>
    public class FileOperator
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="data">数据</param>
        public void SaveData(string data)
        {
            string path = Cls_Config.GetInstance().DataSavePath;
            IsExistsOrCreateFolder(path);
            string fileName = path + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "Data.csv";
            if (!File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName,FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw =new StreamWriter(fs,Encoding.Default))
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("时间,数据1，结果");
                        sw.WriteLine(sb);
                    }
                }
            }
            using (StreamWriter sw =new StreamWriter(fileName,true,Encoding.Default))
            {
                sw.WriteLine(data);
            }
        }

        /// <summary>
       /// 保存log文档
       /// </summary>
       /// <param name="logInfo"></param>
        public void SaveLog(string logInfo)
        {
            //例： "D:\Log\";
            string _logPath = Directory.GetCurrentDirectory() + "\\Log";
            IsExistsOrCreateFolder(_logPath);
            //例： "D:\Log\2023-05-31_log.txt";
            string fileName = _logPath + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "_log.txt";
            logInfo = DateTime.Now.ToString("HH:mm:ss:fff") + ": " + logInfo;
            if (!File.Exists(fileName))//判断是否存在文件
            {
                //FileStream创建文件
                using (FileStream fs =new FileStream(fileName, FileMode.Create,FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(logInfo); //SreamWriter 写入信息
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(fileName,true))
                {
                    sw.WriteLine(logInfo);
                }
            }
        }

        /// <summary>
        /// 保存原始图片
        /// </summary>
        /// <param name="image">图片</param>
        /// <param name="name">图片名称，一般是产品的二维码</param>
        public void SaveRawImage(ICogImage image,string name)
        {
            Bitmap bmp = image.ToBitmap();
            // D:\Image\2023-05-31\RawImage\
            string path = Cls_Config.GetInstance().ImageSavePath + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\RawImage";
            IsExistsOrCreateFolder(path);
            // D:\Image\2023-05-31\RawImage\112233.bmp
            string fileName = path + "\\" + name + ".bmp";
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }
        /// <summary>
        /// 保存处理完成带结果的图片
        /// </summary>
        /// <param name="display"></param>
        /// <param name="name">图片名称，一般是产品的二维码</param>
        public void SaveDealImage(CogRecordDisplay display,string name)
        {
            Bitmap bmp = display.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Image) as Bitmap;
            // D:\Image\2023-05-31\DealImage\
            string path = Cls_Config.GetInstance().ImageSavePath + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "\\DealImage";
            IsExistsOrCreateFolder(path);
            // D:\Image\2023-05-31\DealImage\112233.jpg
            string fileName = path + "\\" + name + ".jpg";
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        /// <summary>
        /// 判断路径，如果不存在则创建路径
        /// </summary>
        /// <param name="path"></param>
        private void IsExistsOrCreateFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
