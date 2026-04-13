using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IDCProject.实体库;

namespace IDCProject.数据层
{
    /// <summary>
    /// 管理员数据访问类
    /// </summary>
    public class SysAdminService
    {
        public SysAdmin AdminLogin(SysAdmin admin)
        {
            if (!File.Exists("sysadmin.conf"))
            {
                throw new Exception("用户信息不存在！");
            }
            FileStream fs = new FileStream("sysadmin.conf", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string loginId = sr.ReadLine();
            string loginpwd = sr.ReadLine();
            //判断账号密码是否正确
            if (admin.LoginId ==  loginId && admin.LoginPwd == loginpwd)
            {
                admin.AdminName = sr.ReadLine().Trim(); //管理员名称
                admin.AccountStatus = Convert.ToInt32(sr.ReadLine()); //账号状态
            } 
            else
            {
                admin = null;
            }
            sr.Close();
            fs.Close();

            return admin;
        }
    }
}
