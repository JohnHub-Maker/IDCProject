using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCProject.实体库
{
    /// <summary>
    /// 系统管理员实体类
    /// </summary>
    public class SysAdmin
    {
        public string LoginId { get; set; } //登录账号
        public string LoginPwd { get; set; } //登录密码
        public string AdminName { get; set; } //管理员名称
        public int AccountStatus { get; set; } //账号状态
    }
}
