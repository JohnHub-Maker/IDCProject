using IDCProject.实体库;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace IDCProject.工具库
{
    public class FileHelper
    {
        /// <summary>
        /// 通信配置文本写入
        /// </summary>
        /// <param name="configModel">要写入的数据的ConfigData实体对象</param>
        public void SaveConfig(ConfigData configModel)
        {
            //创建文件流对象
            FileStream fs = new FileStream("config.conf", FileMode.Create);
            //创建写入器对象
            StreamWriter sw = new StreamWriter(fs);
            //写入数据到文件
            sw.WriteLine(configModel.SlaveId);
            sw.WriteLine(configModel.PortName);
            sw.WriteLine(configModel.BaudRate);
            sw.WriteLine(configModel.Parity);
            sw.WriteLine(configModel.DataBits);
            sw.WriteLine(configModel.StopBits);
            //关闭写入器
            sw.Close();
            //关闭文件流
            fs.Close();
        }
        /// <summary>
        /// 通信配置文本读取
        /// </summary>
        /// <returns>返回保存读取数据的实体对象</returns>
        public ConfigData LoadConfig()
        {
            //创建文件流对象
            FileStream fs = new FileStream("config.conf", FileMode.Open);
            //创建读取器对象
            StreamReader sr = new StreamReader(fs);
            //从文件读取数据，并封装到实体对象
            ConfigData configData = new ConfigData();
            configData.SlaveId = byte.Parse(sr.ReadLine());
            configData.PortName = sr.ReadLine();
            configData.BaudRate = uint.Parse(sr.ReadLine());
            configData.Parity = sr.ReadLine();
            configData.DataBits = byte.Parse(sr.ReadLine());
            configData.StopBits = sr.ReadLine();
            //关闭读取器
            sr.Close();
            //关闭文件流
            fs.Close();
            //返回实体对象
            return configData;
        }


        public void SaveConfigDataLize(ConfigData configModel)
        {
            //创建文件流对象
            FileStream fs = new FileStream("config.conf", FileMode.Create);
            //创建二进制格式化器
            BinaryFormatter formatter = new BinaryFormatter();
            //执行对象序列化
            formatter.Serialize(fs, configModel); //将configModel实体对象序列化到fs文件流
            //关闭文件流
            fs.Close();
        }

        public ConfigData ReadConfigLize()
        {
            //先判断文件是否存在
            if (!File.Exists("config.conf"))
            {
                return null;
            }
            //创建文件流对象
            FileStream fs = new FileStream("config.conf", FileMode.Open);
            if (fs.Length == 0)
            {
                return null;
            }
            //创建二进制格式化器
            BinaryFormatter formatter = new BinaryFormatter();
            //执行对象反序列化
            ConfigData configModel = (ConfigData)formatter.Deserialize(fs);
            //关闭文件流
            fs.Close();
            //返回实体对象
            return configModel;
        }
    }
}
