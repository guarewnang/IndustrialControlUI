using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
namespace Tool
{
    public class PLCCommunicate
    {
      
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cpuType"></param>
        /// <param name="ip"></param>
        /// <param name="rack"></param>
        /// <param name="slot"></param>
        public PLCCommunicate()
        {
            plc = new Plc(CpuType.S7200Smart,"192.168.2.10",0,1);
        }
        /// <summary>
        /// 西沟函数
        /// </summary>
        ~PLCCommunicate()
        {
            plc.Close();
        }
        /// <summary>
        /// 单例
        /// </summary>
        /// <returns></returns>
        public static PLCCommunicate Instance
        {
            get
            {
                return Nested.instance;
            }
        }
        private class Nested
        {
            internal static readonly PLCCommunicate instance=null;
            static Nested()
            {
                instance = new PLCCommunicate();
            }
        }
        /// <summary>
        ///私有单例对象
        /// </summary>
        private static Plc plc;
        /// <summary>
        /// 
        /// </summary>
        public bool ConnectToPLC()
        {
            try
            {
                // plc.OpenAsync();
                plc.Open();
                return plc.IsConnected ? true : false;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        public void Disconnect()
        {
            plc.Close();
        }
        /// <summary>
        /// 读取单个地址,按照I Q M D分四类，并提前设定读取是否有小数
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public object ReadSingleData(string address, bool IsDecimal,bool negative)
        {
            string s = address.Substring(0, 1);
            object outvalue = null;
            switch (s)
            {
                case "I":
                    outvalue = ReadSwitchType(address, 1, IsDecimal,negative);
                    break;
                case "Q":
                    outvalue = ReadSwitchType(address, 1, IsDecimal,negative);
                    break;
                case "M":
                    outvalue = ReadSwitchType(address, 1, IsDecimal, negative);
                    break;
                case "V":
                    string replaceAddress = null;
                    if (address.StartsWith("VB") || address.StartsWith("VW") || address.StartsWith("VD"))
                    {
                        replaceAddress = address.Replace("V", "DB1.DB");
                        int n0 = replaceAddress.IndexOf(".");
                        outvalue = ReadSwitchType(replaceAddress, n0 + 3, IsDecimal, negative);
                    }
                    else
                    {
                        replaceAddress = address.Replace("V", "DB1.DBX");
                        int n0 = replaceAddress.IndexOf(".");
                        outvalue = ReadSwitchType(replaceAddress, n0 + 3, IsDecimal, negative);
                    }
                    break;
                case "D":
                    int n = address.IndexOf(".");
                    outvalue = ReadSwitchType(address, n + 3, IsDecimal, negative);
                    break;
            }
            return outvalue;
        }
        /// <summary>
        /// 每种寄存器有分X B W D四种类型
        /// </summary>
        /// <param name="address"></param>
        /// <param name="index"></param>
        /// <param name="IsDecimals"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        private object ReadSwitchType(string address, int index, bool IsDecimals,bool negative)
        {
            object outvalue = null;
            try
            {
                switch (address.Substring(index, 1))
                {
                    case "X"://布尔运算
                        outvalue = (bool)plc.Read(address.ToUpper());
                        break;
                    case "B"://Byte，USInt，SInt
                        outvalue = (byte)plc.Read(address.ToUpper());
                        break;
                    case "W"://Int，Word
                        if (negative)
                        {
                            outvalue = ((ushort)plc.Read(address.ToUpper())).ConvertToShort();
                        }
                        else
                        {
                            outvalue = (ushort)plc.Read(address.ToUpper());
                        }
                        break;
                    case "D"://DInt,DWord,Real 转化工作留给外围
                        if (IsDecimals)
                            outvalue = ((uint)plc.Read(address.ToUpper())).ConvertToFloat();
                        else
                        {
                            if (negative)
                            {
                                outvalue = ((uint)plc.Read(address.ToUpper())).ConvertToInt();
                            }
                            else
                            {
                                outvalue = (uint)plc.Read(address.ToUpper());
                            }
                        }                           
                        break;
                    default://布尔运算
                        outvalue = (bool)plc.Read(address.ToUpper());
                        break;
                }
                #region 无连接PLC测试
                //switch (address.Substring(index, 1))
                //{
                //    case "X"://布尔运算
                //        outvalue = false;
                //        break;
                //    case "B"://Byte，USInt，SInt
                //        outvalue = (byte)0;
                //        break;
                //    case "W"://Int，Word
                //        outvalue = (ushort)0;
                //        break;
                //    case "D"://DInt,DWord,Real 转化工作留给外围
                //        if (IsDecimals)
                //            outvalue = (uint)0;
                //        else
                //            outvalue = (uint)0;
                //        break;
                //    default://布尔运算
                //        outvalue = false;
                //        break;
                //}
                #endregion
                return outvalue;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 写PLC数据块，按照I Q M D字分四类,
        /// </summary>
        /// <param name="address"></param>
        /// <param name="data"></param>
        public void WriteSingleData(string address, string data)
        {
            string s = address.Substring(0, 1);
            switch (s)
            {
                case "I":
                    WriteSwitchType(address, data, 1);
                    break;
                case "Q":
                    WriteSwitchType(address, data, 1);
                    break;
                case "M":
                    WriteSwitchType(address, data, 1);
                    break;
                case "V":
                    string replaceAddress = null;
                    if (address.StartsWith("VB") || address.StartsWith("VW") || address.StartsWith("VD"))
                    {
                        replaceAddress = address.Replace("V", "DB1.DB");
                        int n0 = replaceAddress.IndexOf(".");
                        WriteSwitchType(replaceAddress, data, n0 + 3);
                    }
                    else
                    {
                        replaceAddress = address.Replace("V", "DB1.DBX");
                        int n0 = replaceAddress.IndexOf(".");
                        WriteSwitchType(replaceAddress, data, n0 + 3);
                    }
                    break;
                case "D":
                    int n = address.IndexOf(".");
                    WriteSwitchType(address, data, n + 3);
                    break;
            }
        }
        /// <summary>
        /// 写寄存器也氛围X B W D四种
        /// </summary>
        /// <param name="address"></param>
        /// <param name="data"></param>
        /// <param name="index"></param>
        private void WriteSwitchType(string address, string data, int index)
        {
            try
            {
                switch (address.Substring(index, 1).ToUpper())
                {
                    case "X"://布尔运算
                        plc.Write(address, Convert.ToBoolean(data.ToUpper()));
                        break;
                    case "B"://Byte，USInt，SInt
                        plc.Write(address, Convert.ToByte(data.ToUpper()));
                        break;
                    case "W"://Int，Word
                        if (data.Contains("-"))
                        {
                            plc.Write(address, Convert.ToInt16(data.ToUpper()));
                        }
                        else
                        {
                            plc.Write(address, Convert.ToUInt16(data.ToUpper()));
                        }
                        break;
                    case "D"://DInt,DWord,Real 转化工作留给外围
                        if (!data.Contains("."))
                        {
                            if (data.Contains("-"))
                            {
                                plc.Write(address, Convert.ToInt32(data.ToUpper()));
                            }
                            else
                            {
                                plc.Write(address, Convert.ToUInt32(data.ToUpper()));
                            }
                        }      
                        else
                            plc.Write(address, Conversion.ConvertToUInt((float)Convert.ToDouble(data)));
                        break;
                    default://布尔运算
                        plc.Write(address, Convert.ToBoolean(data.ToUpper()));
                        break;
                }
            }
            catch
            {


            }
        }
        /// <summary>
        /// 连续读取，效率高，但不能读取字符串和宽字符串，可以DB I Q M
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <param name="varType"></param>
        /// <param name="varCount"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public List<T> ReadLotData<T>(DataType dataType, int db, int startByteAdr, VarType varType, int varCount, T t)
        {
            List<T> lt = new List<T>();
            var v = plc.Read(dataType, db, startByteAdr, varType, varCount);
            var s = v as T[];
            lt.AddRange(s);
            return lt;
        }
        /// <summary>
        /// 字符串读取，编码属于ASCII型的
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public string ReadString(DataType dataType, int db, int startByteAdr, int count)
        {
            string str;
            byte[] data = plc.ReadBytes(dataType, db, startByteAdr, count);
            str = Encoding.Default.GetString(data);
            str=str.Remove(0, 1);
            str = str.Replace("\0",String.Empty);
            return str;
        }
        /// <summary>
        /// 宽字符串读取，编码属于Unicode 是国际标准字符集，可译为万国码或统一码等，包含中日韩越汉字和世界上绝大多数语言文字
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public string ReadWString(DataType dataType, int db, int startByteAdr, int count)
        {
            string str;
            byte[] data = plc.ReadBytes(dataType, db, startByteAdr, count);
            str = Encoding.BigEndianUnicode.GetString(data);
            str=str.Remove(0, 2);
            str = str.Replace("\0",String.Empty);
            return str;
        }
        /// <summary>
        /// 写STRING
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <param name="str"></param>
        public void WriteString(DataType dataType, int db, int startByteAdr, string str)
        {
            plc.Write(dataType, db, startByteAdr, GetPLCStringByteArray(str));
        }
        /// <summary>
        /// 写WSTRING
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="startByteAdr"></param>
        /// <param name="wstr"></param>
        public void WriteWString(DataType dataType, int db, int startByteAdr, string wstr)
        {
            plc.Write(dataType, db, startByteAdr, GetPLCWStringByteArray(wstr));
        }
        /// <summary>
        /// 获取西门子PLC字符串数组--String
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private byte[] GetPLCStringByteArray(string str)
        {
            byte[] value = Encoding.Default.GetBytes(str);
            byte[] head = new byte[2];
            head[0] = Convert.ToByte(254);
            head[1] = Convert.ToByte(str.Length);
            value = head.Concat(value).ToArray();
            return value;
        }
        /// <summary>
        /// 获取西门子PLC字符串数组--WString
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private byte[] GetPLCWStringByteArray(string str)
        {
            byte[] value = Encoding.BigEndianUnicode.GetBytes(str);
            byte[] head = BitConverter.GetBytes((short)508);//508转化为16进制应该是1 11111100。对应字节是1 252，但得到的是252 1，所以要翻转
            byte[] length = BitConverter.GetBytes((short)str.Length);
            Array.Reverse(head);
            Array.Reverse(length);
            head = head.Concat(length).ToArray();
            value = head.Concat(value).ToArray();
            return value;
        }
    }
}
