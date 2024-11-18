using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Cls_Config
    {
        //单例模式

        //私有构造函数
        private Cls_Config() { }
        //声明唯一的类的实例
        private static Cls_Config _instance = null;
        //锁
        private static readonly object _instanceLock = new object();
        //获取这个对象的方法
        public static Cls_Config GetInstance()
        {
            if( _instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Cls_Config();
                    }
                }
            }
            return _instance;
        }







        //基准位置信息
        public double refX {  get; set; }

        public double refY { get; set; }

        public double refR { get; set; }

        //路径
        private string path = Directory.GetCurrentDirectory() + "\\config\\config.ini";

        //加载INI信息
        public void loadINI()
        {
            refX = Ini.IniAPI.GetPrivateProfileDouble("reference", "refX", 0, path);
            refY = Ini.IniAPI.GetPrivateProfileDouble("reference", "refY", 0, path);
            refR = Ini.IniAPI.GetPrivateProfileDouble("reference", "refR", 0, path);
        }
    }
}
