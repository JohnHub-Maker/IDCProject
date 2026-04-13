using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDCProject.实体库;
using IDCProject.数据层;

namespace IDCProject
{
    public partial class FrmConfig : Form
    {
        //创建通信配置数据类对象
        ConfigDataService cDataService = new ConfigDataService();
        public FrmConfig()
        {
            InitializeComponent();

            #region 配置下拉框初始化
            this.cbb_ParityBits.Items.AddRange(Enum.GetNames(typeof(Parity)));
            this.cbb_ParityBits.SelectedIndex = 0;
            this.cbb_StopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            this.cbb_StopBits.SelectedIndex = 1;
            this.cbb_BaudRate.Items.AddRange(new string[]
            {
                "4800",
                "9600",
                "19200",
                "38400",
                "115200"
            });
            this.cbb_BaudRate.SelectedIndex = 1;
            this.cbb_DataBits.Items.AddRange(new string[]
            {
                "7",
                "8"
            });
            this.cbb_DataBits.SelectedIndex = 1;
            this.cbb_PortNames.Items.AddRange(SerialPort.GetPortNames());
            this.cbb_PortNames.SelectedIndex = this.cbb_PortNames.Items.Count - 1;
            #endregion

            //加载保存的配置
            ReadConfig();
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        private void ReadConfig()
        {
            ConfigData cdata = cDataService.ReadConfigData();
            if (cdata != null )
            {
                //显示配置的串口数据
                this.txt_SlaveId.Text = cdata.SlaveId.ToString();
                this.cbb_BaudRate.Text = cdata.BaudRate.ToString();
                this.cbb_DataBits.Text = cdata.DataBits.ToString();
                this.cbb_ParityBits.Text = cdata.Parity.ToString();
                this.cbb_PortNames.Text = cdata.PortName;
                this.cbb_StopBits.Text = cdata.StopBits.ToString();
            }
        }

        //保存串口通信配置
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //站地址类型转换并检查内容
            byte slaveId = 0;
            try
            {
                slaveId = Convert.ToByte(this.txt_SlaveId.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("站地址必须是1-254之间的整数！错误原因：" + ex.Message, "错误提示");
                return;
            }
            //创建配置对象，封装配置数据
            ConfigData cData = new ConfigData()
            {
                SlaveId = slaveId,
                PortName = this.cbb_PortNames.Text,
                BaudRate = Convert.ToUInt32(this.cbb_BaudRate.Text),
                Parity = this.cbb_ParityBits.Text,
                DataBits = Convert.ToByte(this.cbb_DataBits.Text),
                StopBits = this.cbb_StopBits.Text
            };
            //保存配置
            try
            {
                cDataService.SaveConfigData(cData);
                MessageBox.Show("配置保存成功！","提示信息");

                this.Tag = cData; //通过窗体的Tag属性，返回新的配置对象给主窗体
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show("配置保存失败！错误原因：" + ex.Message, "提示信息");
            }
        }
    }
}
