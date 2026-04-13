using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCProject.实体库
{
    /// <summary>
    /// 通信配置类
    /// </summary>
    [Serializable] //序列化特性
    public class ConfigData
    {
        public byte SlaveId { get; set; }
        public string PortName { get; set; }
        public uint BaudRate { get; set; }
        public string Parity { get; set; } //为了方便存储，所以用字符串格式
        public byte DataBits { get; set; }
        public string StopBits { get; set; }
    }
}
