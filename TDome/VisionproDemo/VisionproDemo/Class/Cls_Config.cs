using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionproDemo
{
    public class Cls_Config
    {
        //私有变量保存类的实例
        private static Cls_Config _instance = null;
        //私有化构造函数
        private Cls_Config() { }
        //定义标识符，确保多线程访问安全
        private static readonly object Locker = new object();
        //返回类的实例
        public static Cls_Config GetInstance()
        {
            if (_instance == null)
            {
                lock (Locker)
                {
                    if (_instance == null)
                        _instance = new Cls_Config();
                }
            }
            return _instance;
        }


        private string _cfgPath = Directory.GetCurrentDirectory() + "\\Configuration\\Config.ini";
        #region 串口属性
        /// <summary>
        /// 0 不启用串口， 1启用串口
        /// </summary>
        public int ComAvailable { get; set; } = 0;
        /// <summary>
        /// 串口号
        /// </summary>
        public string ComName { get; set; }
        /// <summary>
        /// 波特率
        /// </summary>
        public int ComBoundrate { get; set; }
        /// <summary>
        /// 校验位
        /// </summary>
        public int ComParity { get; set; }
        /// <summary>
        /// 数据位
        /// </summary>
        public int ComDataBits { get; set; }
        /// <summary>
        /// 停止位
        /// </summary>
        public int ComStopBits { get; set; }

        #endregion

        #region TCP属性
        /// <summary>
        /// 0 不启用 1启用
        /// </summary>
        public int TcpAvailable { get; set; } = 0;
        /// <summary>
        /// IP地址
        /// </summary>
        public string TcpIP { get; set; }
        /// <summary>
        /// 端口号
        /// </summary>
        public int TcpPort { get; set; }

        #endregion

        #region 生产数据属性
        /// <summary>
        /// 产品总数
        /// </summary>
        public int ProductTotal { get; set; }
        /// <summary>
        /// 良品数
        /// </summary>
        public int ProductOkNum { get; set; }
        #endregion

        #region 路径属性
     
        
        public string ImageSavePath { get; set; }
        public string DataSavePath { get; set; }
        #endregion

        #region 贴合基准点位和offset
        /// <summary>
        /// 补偿值X
        /// </summary>
        public double OffsetX { get; set; }
        /// <summary>
        /// 补偿值Y
        /// </summary>
        public double OffsetY { get; set; }
        /// <summary>
        /// 补偿值角度
        /// </summary>
        public double OffsetA { get; set; }
        /// <summary>
        /// 下相机拍照点位X
        /// </summary>
        public double DownPZX { get; set; }
        /// <summary>
        /// 下相机拍照点位Y
        /// </summary>
        public double DownPZY { get; set; }
        /// <summary>
        /// 下相机拍照点位角度
        /// </summary>
        public double DownPZA { get; set; }

        /// <summary>
        /// 最终贴合点位X
        /// </summary>
        public double TieHeX { get; set; }
        /// <summary>
        /// 最终贴合点位Y
        /// </summary>
        public double TieHeY { get; set; }
        /// <summary>
        /// 最终贴合点位角度
        /// </summary>
        public double TieHeA { get; set; }

        /// <summary>
        /// 最终贴合点位X
        /// </summary>
        public double BaseX { get; set; }
        /// <summary>
        /// 最终贴合点位Y
        /// </summary>
        public double BaseY { get; set; }
        /// <summary>
        /// 最终贴合点位角度
        /// </summary>
        public double BaseA { get; set; }

        /// <summary>
        /// 旋转中心X坐标
        /// </summary>
        public double OrgX { get; set; }
        /// <summary>
        /// 旋转中心Y坐标
        /// </summary>
        public double OrgY { get; set; }
        #endregion


        /// <summary>
        /// 加载配置文件
        /// </summary>
        public void LoadConfig()
        {
            //串口
            ComAvailable = Ini.IniAPI.GetPrivateProfileInt("串口", "ComAvailable", 0, _cfgPath);
            ComName = Ini.IniAPI.GetPrivateProfileString("串口", "ComName", "COM1", _cfgPath);
            ComBoundrate = Ini.IniAPI.GetPrivateProfileInt("串口", "ComBoundrate", 9600, _cfgPath);
            ComParity = Ini.IniAPI.GetPrivateProfileInt("串口", "ComParity", 0, _cfgPath);
            ComDataBits = Ini.IniAPI.GetPrivateProfileInt("串口", "ComDataBits", 8, _cfgPath);
            ComStopBits = Ini.IniAPI.GetPrivateProfileInt("串口", "ComStopBits", 1, _cfgPath);
            
            //网口
            TcpAvailable = Ini.IniAPI.GetPrivateProfileInt("网口参数", "TcpAvailable", 0, _cfgPath);
            TcpIP = Ini.IniAPI.GetPrivateProfileString("网口参数", "TcpIP", "127.0.0.1", _cfgPath);
            TcpPort = Ini.IniAPI.GetPrivateProfileInt("网口参数", "TcpPort", 6000, _cfgPath);
            
            //生产数据
            ProductTotal = Ini.IniAPI.GetPrivateProfileInt("生产数据", "ProductTotal", 0, _cfgPath);
            ProductOkNum = Ini.IniAPI.GetPrivateProfileInt("生产数据", "ProductOkNum", 0, _cfgPath);
            
            //路径
            ImageSavePath = Ini.IniAPI.GetPrivateProfileString("路径", "ImageSavePath", @"D:\Image", _cfgPath);
            DataSavePath = Ini.IniAPI.GetPrivateProfileString("路径", "DataSavePath", @"D:\Data", _cfgPath);

            //贴合基准点位和offset
            OffsetX = Ini.IniAPI.GetPrivateProfileDouble("点位", "OffsetX", 0, _cfgPath);
            OffsetY = Ini.IniAPI.GetPrivateProfileDouble("点位", "OffsetY", 0, _cfgPath);
            OffsetA = Ini.IniAPI.GetPrivateProfileDouble("点位", "OffsetA", 0, _cfgPath);
            
            DownPZX = Ini.IniAPI.GetPrivateProfileDouble("点位", "DownPZX", 0, _cfgPath);
            DownPZY = Ini.IniAPI.GetPrivateProfileDouble("点位", "DownPZY", 0, _cfgPath);
            DownPZA = Ini.IniAPI.GetPrivateProfileDouble("点位", "DownPZA", 0, _cfgPath);
            
            TieHeX = Ini.IniAPI.GetPrivateProfileDouble("点位", "TieHeX", 0, _cfgPath);
            TieHeY = Ini.IniAPI.GetPrivateProfileDouble("点位", "TieHeY", 0, _cfgPath);
            TieHeA = Ini.IniAPI.GetPrivateProfileDouble("点位", "TieHeA", 0, _cfgPath);
            
            BaseX = Ini.IniAPI.GetPrivateProfileDouble("点位", "BaseX", 0, _cfgPath);
            BaseY = Ini.IniAPI.GetPrivateProfileDouble("点位", "BaseY", 0, _cfgPath);
            BaseA = Ini.IniAPI.GetPrivateProfileDouble("点位", "BaseA", 0, _cfgPath);

            OrgX = Ini.IniAPI.GetPrivateProfileDouble("点位", "OrgX", 0, _cfgPath);
            OrgY = Ini.IniAPI.GetPrivateProfileDouble("点位", "OrgY", 0, _cfgPath);
        }
        /// <summary>
        /// 写入ini文件
        /// </summary>
        /// <param name="section">节点</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        public void WriteConfig(string section, string key,string value)
        {
            Ini.IniAPI.INIWriteValue(_cfgPath, section, key, value);
        }

    }
}
