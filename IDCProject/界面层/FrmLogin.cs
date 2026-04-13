using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDCProject.数据层;
using IDCProject.实体库;

namespace IDCProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //创建用户登录数据类对象
        private SysAdminService adminService = new SysAdminService();

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //输入内容验证
            if (this.txt_Login.Text.Trim().Length == 0 || this.txt_LoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("账号或密码为空", "登录提示");
                return;
            }
            //封装用户信息
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginId = this.txt_Login.Text.Trim(),
                LoginPwd = this.txt_LoginPwd.Text.Trim()
            };
            //调用数据访问类登录
            try
            {
                sysAdmin = adminService.AdminLogin(sysAdmin);
            }
            catch (Exception ex) //如果登录信息不存在，进入异常
            {
                MessageBox.Show(ex.Message, "登录提示");
                return;
            }
            if (sysAdmin == null) //返回null表示账号或密码错误
            {
                MessageBox.Show("账号或密码错误!", "登录提示");
                this.txt_Login.SelectAll(); //选中用户输入的账号
            }
            else
            {
                //账号状态：1=正常、其他数字=停用
                if (sysAdmin.AccountStatus != 1)
                {
                    MessageBox.Show("账号已停用！无法使用！", "登录提示");
                }
                else
                {
                    //返回登录对象数据给主窗体
                    this.Tag = sysAdmin;
                    MessageBox.Show("登陆成功！", "登录提示");
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
