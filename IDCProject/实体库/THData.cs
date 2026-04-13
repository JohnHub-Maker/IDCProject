using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCProject.实体库
{
    /// <summary>
    /// 温湿度实体类
    /// </summary>
    public class THData
    {
        public int Id { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }
}
