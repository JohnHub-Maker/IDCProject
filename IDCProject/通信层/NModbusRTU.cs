using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using Modbus.Device;

namespace STHProject.DAL
{
    /// <summary>
    /// 基于NModbus4开源库二次封装
    /// </summary>
    public class NModbusRTU
    {
        //声明串口对象
        private SerialPort serialPort;

        //声明Modbus协议串口主设备对象
        private ModbusSerialMaster serialMaster;



        #region 串口的打开与关闭
        #region 串口打开


        public bool OpenConnect(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            //如果是打开状态，先关闭一下
            if (this.serialPort != null && serialPort.IsOpen)
            {
                this.serialPort.Close();
            }
            try
            {
                //初始化串口对象实例
                this.serialPort = new SerialPort(portName,baudRate,parity,dataBits,stopBits);

                //打开串口
                this.serialPort.Open();

                //使用Modbus串口工厂方法创建主站对象
                this.serialMaster = ModbusSerialMaster.CreateRtu(serialPort);
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("异常，串口打开失败：" + ex.Message);
            }
        }
        #endregion

        #region 串口关闭
        public void DisConnect()
        {
            if (this.serialPort != null && this.serialPort.IsOpen)
            {
                //关闭串口
                this.serialPort.Close();
                //释放资源
                this.serialMaster.Dispose();
            }
        }
        #endregion
        #endregion

        #region 01功能码：读取输出线圈
        /// <summary>
        /// 01功能码：读取输出线圈
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始线圈地址</param>
        /// <param name="length">读取线圈数量</param>
        /// <returns>所读线圈状态的bool数组</returns>
        /// <exception cref="Exception"></exception>
        public bool[] ReadOutputCoils(byte slaveId, ushort start, ushort length)
        {
            try
            {
                return this.serialMaster.ReadCoils(slaveId, start, length);
            }
            catch (Exception ex)
            {
                throw new Exception("读取输出线圈失败：" + ex.Message);
            }
        }
        #endregion

        #region 02功能码：读取输入线圈
        /// <summary>
        /// 02功能码：读取输入线圈
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始线圈地址</param>
        /// <param name="length">读取线圈数量</param>
        /// <returns>所读线圈状态的bool数组</returns>
        /// <exception cref="Exception"></exception>
        public bool[] ReadInputCoils(byte slaveId, ushort start, ushort length)
        {
            try
            {
                return this.serialMaster.ReadInputs(slaveId, start, length);
            }
            catch (Exception ex)
            {
                throw new Exception("读取输入线圈失败：" + ex.Message);
            }
        }
        #endregion

        #region 03功能码：读取输出寄存器
        /// <summary>
        /// 03功能码：读取输出寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="length">读取寄存器数量</param>
        /// <returns>所读寄存器状态的byte数组</returns>
        /// <exception cref="Exception"></exception>
        public byte[] ReadOutputRegister(byte slaveId, ushort start, ushort length)
        {
            try
            {
                //获取寄存器数据数组
                ushort[] registerData = this.serialMaster.ReadHoldingRegisters(slaveId, start, length);
                
                //把ushort数组，转成byte集合
                List<byte> result = new List<byte>();
                foreach(var item in registerData)
                {
                    //BitConverter.GetBytes(item) 会将 item（一个 ushort，即无符号 16 位整数）转换成一个长度为 2 的 byte[] 数组。
                    //原理：它会将数值在内存中的二进制数据拆分成两个字节直接复制到一个新的 byte 数组中。
                    result.AddRange(BitConverter.GetBytes(item));
                }
                return result.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception("读取输出寄存器失败：" + ex.Message);
            }
        }
        #endregion

        #region 04功能码：读取输入寄存器
        /// <summary>
        /// 04功能码：读取输入寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="length">读取寄存器数量</param>
        /// <returns>所读寄存器状态的byte数组</returns>
        /// <exception cref="Exception"></exception>
        public byte[] ReadInputRegister(byte slaveId, ushort start, ushort length)
        {
            try
            {
                //获取寄存器数据数组
                ushort[] registerData = this.serialMaster.ReadInputRegisters(slaveId, start, length);

                //把ushort数组，转成byte集合
                List<byte> result = new List<byte>();
                foreach (var item in registerData)
                {
                    //BitConverter.GetBytes(item) 会将 item（一个 ushort，即无符号 16 位整数）转换成一个长度为 2 的 byte[] 数组。
                    //原理：它会将数值在内存中的二进制数据拆分成两个字节直接复制到一个新的 byte 数组中。
                    result.AddRange(BitConverter.GetBytes(item));
                }
                return result.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception("读取输入寄存器失败：" + ex.Message);
            }
        }
        #endregion

        #region 05功能码：预制单线圈
        /// <summary>
        /// 05功能码：预制单线圈
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">线圈地址</param>
        /// <param name="value">线圈的值</param>
        /// <returns>是否成功</returns>
        /// <exception cref="Exception"></exception>
        public bool PreSetSingleCoil(byte slaveId,ushort start, bool value)
        {
            try
            {
                this.serialMaster.WriteSingleCoil(slaveId,start, value);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("预制单线圈失败：" + ex.Message);
            }
        }
        #endregion

        #region 06功能码：预制单寄存器（方法重载）
        /// <summary>
        /// 06功能码：预制单寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">寄存器地址</param>
        /// <param name="value">寄存器的值</param>
        /// <returns>是否成功</returns>
        /// <exception cref="Exception"></exception>
        public bool PreSetSingleRegister(byte slaveId, ushort start, ushort value)
        {
            try
            {
                this.serialMaster.WriteSingleRegister(slaveId,start,value);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("预制单寄存器失败：" + ex.Message);
            }
        }
        /// <summary>
        /// 06功能码：预制单寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">寄存器地址</param>
        /// <param name="value">寄存器的值</param>
        /// <returns>是否成功</returns>
        public bool PreSetSingleRegister(byte slaveId, ushort start, byte[] value)
        {
            try
            {
                //使用 BitConverter 类将字节数组转换为无符号 16 位整数
                ushort values = BitConverter.ToUInt16(value, 0);

                this.serialMaster.WriteSingleRegister(slaveId, start, values);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("预制单寄存器失败：" + ex.Message);
            }
        }
        /// <summary>
        /// 06功能码：预制单寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">寄存器地址</param>
        /// <param name="value">寄存器的值</param>
        /// <returns>是否成功</returns>
        /// <exception cref="Exception"></exception>
        public bool PreSetSingleRegister(byte slaveId, ushort start, short value)
        {
            try
            {
                //调用方法重载
                return PreSetSingleRegister(slaveId, start, BitConverter.GetBytes(value));
            }
            catch (Exception ex)
            {

                throw new Exception("预制单寄存器失败：" + ex.Message);
            }
        }
        #endregion

        #region 0F功能码：预制多线圈
        /// <summary>
        /// 0F功能码：预制多线圈
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始线圈地址</param>
        /// <param name="value">布尔数组</param>
        /// <returns>是否成功</returns>
        /// <exception cref="Exception"></exception>
        public bool PreSetMultipleCoils(byte slaveId,ushort start, bool[] value)
        {
            try
            {
                //return this.serialMaster.PreSetMultipleCoils(slaveId, start, value);
                this.serialMaster.WriteMultipleCoils(slaveId, start, value);
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("预制多线圈失败：" + ex.Message);
            }
        }
        #endregion

        #region 10功能码：预制多寄存器（方法重载）
        /// <summary>
        /// 10功能码：预制多寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="value">ushort数组</param>
        /// <returns>是否成功</returns>
        /// <exception cref="Exception"></exception>
        public bool PreSetMultipleRegister(byte slaveId, ushort start, ushort[] value)
        {
            try
            {
                return PreSetMultipleRegister(slaveId,start,value);
            }
            catch (Exception ex)
            {
                throw new Exception("预制多寄存器失败：" + ex.Message);
            }
        }

        /// <summary>
        /// 10功能码：预制多寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="value">short数组</param>
        /// <returns>是否成功</returns>
        /// <exception cref="Exception"></exception>
        public bool PreSetMultipleRegister(byte slaveId, ushort start, short[] value)
        {
            try
            {
                return PreSetMultipleRegister(slaveId, start, value);
            }
            catch (Exception ex)
            {
                throw new Exception("预制多寄存器失败：" + ex.Message);
            }
        }

        /// <summary>
        /// 10功能码：预制多寄存器
        /// </summary>
        /// <param name="slaveId">从站地址</param>
        /// <param name="start">起始寄存器地址</param>
        /// <param name="value">字节数组</param>
        /// <returns>是否成功</returns>
        /// <exception cref="Exception"></exception>
        public bool PreSetMultipleRegister(byte slaveId, ushort start, byte[] value)
            //浮点数、整数等都可以转换成字节数组，这样的话这个方法的通用性就很强
        {
            //字节数必须是偶数（一个寄存器占用两个字节）
            if (value == null || value.Length == 0 || value.Length % 2 == 1)
            {
                return false;
            
            }
            //将字节数组中的每两个字节转换成一个ushort类型数据到ushort数组中
            ushort[] data = new ushort[value.Length / 2];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = BitConverter.ToUInt16(value, i*2);
            }

            try
            {
                return PreSetMultipleRegister(slaveId, start, data);
            }
            catch (Exception ex)
            {
                throw new Exception("预制多寄存器失败：" + ex.Message);
            }
        }
        #endregion
    }
}
