using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace VisionproDemo
{ 
    public class SiemensPLC
    {
        public Plc plc = null;

        CpuType plcType;
        string ip;
        short rack;
        short slot;
        // CpuType: PLC的cpu型号。我这里是1200/1212C。
        // IP: PLC的IP地址。
        // rack: 机台号的位置，这个也是PLC的知识点。
        // slot: 插槽号的位置，也是PLC的知识点
        public SiemensPLC(CpuType type, string ip, short rack, short slot)
        {
            this.plcType = type;
            this.ip = ip;
            this.rack = rack;
            this.slot = slot;
            try
            {
                plc = new Plc(plcType, ip, rack, slot);
            }
            catch (Exception ex)
            {

                
            }
            
           
        }

        /// <summary>
        /// 连接Plc
        /// </summary>
        public string ConnectPlc()
        { 
            string res = string.Empty;
            try
            {
                plc.Open();//连接plc
                res = "ConnectOK";
            }
            catch (Exception ex)
            {
                res = $"ConnectFail {ex.Message}";
            }
            return res;
        }
        /// <summary>
        /// 判断PLC是否已连接
        /// </summary>
        /// <returns></returns>
        public bool PlcIsConn()
        {
            return plc != null && plc.IsConnected;
        }
        /// <summary>
        /// 向PLC写入数据
        /// </summary>
        /// <param name="add">地址</param>
        /// <param name="value">数据</param>
        public void Write(string add, object value)
        {
            plc.Write(add, value);
        }
        /// <summary>
        /// 读取某个地址的内容
        /// </summary>
        /// <param name="add">地址</param>
        /// <returns></returns>
        public object Read(string add)
        {
                return plc.Read(add);
           
           
        }
        /// <summary>
        /// 读取字符串
        /// </summary>
        /// <param name="dataType">数据类型，可选择从DB块或者Memory中读取</param>
        /// <param name="db">DataBlock=1,Memory=0</param>
        /// <param name="startByteStr">起始地址，即DB块的起始偏移量</param>
        /// <returns></returns>
        public string ReadString(DataType dataType,int db,int startByteStr)
        {
            //读字符串分两步操作：
            //1、获取字符串的长度；
            //2、从指定地址开始，读取字符串长度；
            var count = (byte)plc.Read(dataType, db, startByteStr, VarType.Byte, 1);//获取字符串长度
            string str = (string)plc.Read(dataType, db, startByteStr + 1, VarType.String, count);//获取对应长度的字符串
            return str;
        }

        /// <summary>
        /// 读取批量数据块
        /// </summary>
        /// <param name="dataType">数据类型，可选择从DB块或者Memory中读取</param>
        /// <param name="db">1：DataBlock=1,Memory=0</param>
        /// <param name="startByteAdr">起始地址，即DB块的起始偏移量；</param>
        /// <param name="count">读取大小，该大小由读取的DB块的最后一个数据的偏移量和大小决定，这里最后一个字节WordVariable偏移量为16，数据类型为word，2个字节，因此此次读取为16+2=18个字节</param>
        /// <returns>Byte[],这里Byte[]的大小必然和count的大小是相同的</returns>
        public byte[] ReadBytes(DataType dataType, int db, int startByteAdr, int count)
        {
            return plc.ReadBytes(dataType, db, startByteAdr, count);
        }
        /// <summary>
        /// 写入多个数据
        /// </summary>
        /// <param name="dataType">数据类型，可选择从DB块或者Memory中读取</param>
        /// <param name="db">1：DataBlock=1,Memory=0</param>
        /// <param name="startByteAdr">>起始地址，即DB块的起始偏移量</param>
        /// <param name="value"></param>
        public void WriteBytes(DataType dataType, int db, int startByteAdr, byte[] value)
        {
            plc.WriteBytes(dataType, db, startByteAdr, value);
        }
        /// <summary>
        /// 断开连接
        /// </summary>
        public void DisconnectPlc()
        {
            plc.Close();
        }
    }
}
