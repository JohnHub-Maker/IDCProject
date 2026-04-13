using IDCProject.实体库;
using IDCProject.工具库;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCProject.数据层
{
    /// <summary>
    /// 通信配置数据类
    /// </summary>
    public class ConfigDataService
    {
        FileHelper fileHelper = new FileHelper();

        /// <summary>
        /// 配置信息对象进行序列化保存
        /// </summary>
        /// <param name="model"></param>
        public void SaveConfigData(ConfigData model)
        {
            fileHelper.SaveConfigDataLize(model);
        }

        /// <summary>
        /// 配置信息对象反序列化读取
        /// </summary>
        /// <returns></returns>
        public ConfigData ReadConfigData()
        {
            return fileHelper.ReadConfigLize();
        }
    }
}
