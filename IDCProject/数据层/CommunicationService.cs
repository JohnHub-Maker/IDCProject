using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using STHProject.DAL;
using IDCProject.实体库;

namespace IDCProject.数据层
{
    /// <summary>
    /// 设备通信数据采集类
    /// </summary>
    public class CommunicationService
    {
        //创建通信库对象
        private NModbusRTU nRTU = new NModbusRTU();

        #region 打开与关闭连接
        //打开连接
        public bool OpenConnect(string portName, uint baudRate = 9600, Parity parity = Parity.None, byte dataBits = 8, StopBits stopBits = StopBits.One)
        {
            return nRTU.OpenConnect(portName, (int)baudRate, parity, dataBits, stopBits);
        }

        //关闭连接
        public void DisConnect()
        {
            nRTU.DisConnect();
        }
        #endregion

        #region 读取温湿度数据
        /// <summary>
        /// 读取温湿度数据
        /// </summary>
        /// <param name="slaveId">站地址</param>
        /// <returns>带有温湿度数据对象的字典集合</returns>
        public Dictionary<string,THData> ReadTHData(byte slaveId)
        {
            //调用通信库读取数据
            byte[] dataBytes = nRTU.ReadOutputRegister(slaveId,0,4);
            if (dataBytes == null)
            {
                return null;
            }
            //数据转换
            int tem1 = BitConverter.ToInt16(new byte[] { dataBytes[0], dataBytes[1] }, 0);
            int tem2 = BitConverter.ToInt16(new byte[] { dataBytes[4], dataBytes[5] }, 0);
            int hum1 = BitConverter.ToInt16(new byte[] { dataBytes[2], dataBytes[3] }, 0);
            int hum2 = BitConverter.ToInt16(new byte[] { dataBytes[6], dataBytes[7] }, 0);
            //封装数据到实体对象
            THData data1 = new THData()
            {
                Id = 1,
                Temperature = tem1 * 0.1,
                Humidity = hum1 * 0.1
            };
            THData data2 = new THData()
            {
                Id = 2,
                Temperature = tem2 * 0.1,
                Humidity = hum2 * 0.1
            };
            //封装对象到集合
            Dictionary<string,THData> dataDic = new Dictionary<string,THData>()
            {
                ["1号机房"] = data1,
                ["2号机房"] = data2
            };
            //返回集合
            return dataDic;
        }
        #endregion

        #region 根据读取到的模拟量寄存器值，计算出对应的仪表数据
        /// <summary>
        /// 根据读取到的模拟量寄存器值，计算出对应的仪表数据
        /// </summary>
        /// <param name="eVmin">模拟量工程值低限(如变送器4ma对应的值)</param>
        /// <param name="eVmax">模拟量工程值高限(如变送器20ma对应的值)</param>
        /// <param name="registerData">寄存器中工程量实际值</param>
        /// <param name="sensorMin">变送器量程低限</param>
        /// <param name="sensorMax">变送器量程高限</param>
        /// <returns></returns>
        private float CalculateReadAIValue(ushort eVmin, ushort eVmax, ushort registerData, short sensorMin, short sensorMax)
        {
            //例1，按照分辨率为12计算，就是2的12次方=4096（最大值20ma所对应的值）比例20：4096
            //所以0-20ma=>0(eVmin)-4096(eVmax)、4-20ma=>819(eVmin)-4096(eVmax)
            //例2，分辨率扩大同样的倍数，按照扩大后的计算，
            //ushort eVmin = 4000; 变送器4ma时所对应寄存器的值
            //ushort eVman = 20000; 变送器20ma时所对应寄存器的值
            //通用计算公式：(寄存器值-eVmin) / eVmax-eVmin=(x - sensorMin) / (sensorMax - sensorMin)
            //则x的计算公式如下：
            float x = (registerData - eVmin) * (sensorMax - sensorMin) * 1.0f / ((eVmax - eVmin) * 1.0f) + sensorMin * 1.0f;
            return x;
        }

        public List<float> ReadPressureData(byte slaveId)
        {
            //1.读取寄存器中的压力数据
            byte[] dataArray = nRTU.ReadInputRegister(slaveId, 0, 2);
            //2.将2个字节的数据转为ushort类型
            ushort data1 = BitConverter.ToUInt16(dataArray, 0); //压力1
            ushort data2 = BitConverter.ToUInt16(dataArray, 2); //压力1
            //3.转换数值为仪表数据
            float value1 = CalculateReadAIValue(4000, 20000, data1, 0, 30);
            float value2 = CalculateReadAIValue(4000, 20000, data2, 0, 30);
            //4.返回封装仪表数据的泛型集合
            List<float> result = new List<float>()
            {
                value1,
                value2
            };
            return result;
        }
        #endregion

        #region 读取水泵运行状态
        /// <summary>
        /// 读取4个水泵的运行状态（读取4个输出线圈的值）
        /// </summary>
        /// <param name="slaveId">采集卡地址</param>
        /// <returns>水泵的运行状态</returns>
        public bool[] ReadPumpStatus(byte slaveId)
        {
            return nRTU.ReadOutputCoils(slaveId, 0, 4);
        }
        #endregion

        #region 控制设备启停（写入单线圈）
        /// <summary>
        /// 控制设备启停（写入单线圈）
        /// </summary>
        /// <param name="slaveId">站地址</param>
        /// <param name="pumpAddress">水泵线圈地址</param>
        /// <param name="isRun">启停bool值</param>
        /// <returns></returns>
        public bool StartOrStopDevice(byte slaveId, ushort pumpAddress, bool isRun)
        {
            return nRTU.PreSetSingleCoil(slaveId, pumpAddress, isRun);
        }
        #endregion
    }
}
