using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCProject.实体库
{
    /// <summary>
    /// 压力和水泵数据
    /// </summary>
    public class PressureData
    {
        public string CollectionTime { get; set; } //采集时间
        public double PressureIn {  get; set; } //进水压力
        public double PressureOut { get; set; } //出水压力
        public string PressureStatus { get; set; } //压力状态
    }
}
