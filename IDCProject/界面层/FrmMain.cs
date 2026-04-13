using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
    public partial class FrmMain : Form
    {
        //配置数据类对象
        private ConfigDataService cDataService = new ConfigDataService();
        //用于保存通信配置的对象
        private ConfigData configData = null;

        //通信数据类对象
        private CommunicationService commService = new CommunicationService();
        //用来表示是否需要同步显示泵的运行状态
        private bool isShowPumpStatus = false;

        public FrmMain()
        {
            InitializeComponent();

            //自定义初始化
            this.dgv_DataList.AutoGenerateColumns = false; //禁止dgv自动生成列
            this.btn_TurnOff.Enabled = false; //禁用“打开设备”按钮
            EnableBtn(false); //禁用4个泵的开关
            AddEventToSwitch(); //将btnWPump_click与switch按钮事件进行关联
        }

        /// <summary>
        /// 将设备启停按钮与事件进行关联
        /// </summary>
        private void AddEventToSwitch()
        {
            foreach (Control item in this.uiPanel3.Controls)
            {
                if (item.Tag != null && item.Tag.ToString().Contains("swi_"))
                {
                    item.Click += new System.EventHandler(this.btnWPump_click);
                }
            }
        }

        #region 允许或禁用4个泵的开关
        //允许或禁用4个泵的开关
        public void EnableBtn(bool isEnable)
        {
            this.btn_WPump1.Enabled = isEnable;
            this.btn_WPump2.Enabled = isEnable;
            this.btn_WPump3.Enabled = isEnable;
            this.btn_WPump4.Enabled = isEnable;
        }
        #endregion

        #region 数据和仪表复位
        public void ResetData()
        {
            //仪表和按钮的显示复位
            this.btn_TurnOff.Tag = "0";
            this.btn_TurnOff.Text = "实时监控";
            this.meter1.Value = 0;
            this.wave1.Value = 0;
            this.meter2.Value = 0;
            this.wave2.Value = 0;
            this.lbl_Tem1.Value = 0;
            this.lbl_Hum1.Value = 0;
            this.lbl_Tem2.Value = 0;
            this.lbl_Hum2.Value = 0;
            this.dp1.Value = 0;
            this.dp2.Value = 0;
            //dgv列表内容清空
            this.dgv_DataList.DataSource = null;
            //系统状态复位
            this.lbl_ConnectStatus.Text = "未连接";
            this.lbl_PreStatus.Text = "暂无数据";
            this.lbl_THStatus.Text = "暂无数据";
            this.led_Connect.State = Sunny.UI.UILightState.Off;
            this.led_PreData.State = Sunny.UI.UILightState.Off;
            this.led_THData.State = Sunny.UI.UILightState.Off;
            //泵的运行状态复位
            this.wPump1.IsRun = this.wPump2.IsRun = this.wPump3.IsRun = this.wPump4.IsRun = false;
            this.btn_WPump1.Active = this.btn_WPump2.Active = this.btn_WPump3.Active = this.btn_WPump4.Active = false;
        }
        #endregion

        #region 无边框拖动
        private Point mPoint;
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X,
                    this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        #region 退出确认
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认关闭系统！","关闭确认", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK) 
            {
                this.Close();
            }
        }

        #endregion

        #region 通信配置
        //通信配置
        private void btn_Config_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            DialogResult result = frmConfig.ShowDialog();
            //保存当前配置到配置对象
            if (result == DialogResult.OK)
            {
                this.configData = (ConfigData)frmConfig.Tag;
            }
        }
        #endregion

        #region "用户登录"按钮事件
        private SysAdmin currentAdmin = null; //用于保存当前登录用户的对象
        private void btn_UserLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK && frmLogin.Tag != null)
            {
                //显示登录用户名
                this.lbl_CurrentUser.Text = ((SysAdmin)frmLogin.Tag).AdminName;
                this.currentAdmin = (SysAdmin)frmLogin.Tag; //保存所登录的对象
            }
        }

        #endregion

        #region "连接设备"按钮事件
        

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (this.btn_Connect.Tag.ToString() == "0") //连接设备
            {
                this.configData = cDataService.ReadConfigData(); //从通信配置文件中读取配置信息
                if (configData != null)
                {
                    try
                    {
                        commService.OpenConnect(configData.PortName, configData.BaudRate, (Parity)Enum.Parse(typeof(Parity), configData.Parity), configData.DataBits);
                        this.btn_Connect.Tag = "1";
                        this.btn_Connect.Text = "断开设备";
                        this.led_Connect.State = Sunny.UI.UILightState.On;
                        this.lbl_ConnectStatus.Text = "连接成功";
                        this.btn_TurnOff.Enabled = true; //启用"实时监控"按钮
                        //EnableBtn(true); //启动设备控制按钮
                        MessageBox.Show("设备连接成功", "连接提示");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("设备连接出现问题：" + ex.Message, "连接错误");
                    }
                }
                else
                {
                    MessageBox.Show("请正确配置参数！","连接提示");
                }
            }
            else //断开设备
            {
                this.timer1.Stop(); //先停止定时器
                commService.DisConnect(); //关闭连接
                this.btn_Connect.Tag = "0";
                this.btn_Connect.Text = "连接设备";
                this.led_Connect.State = Sunny.UI.UILightState.Off;
                this.lbl_ConnectStatus.Text = "未连接";
                this.btn_TurnOff.Enabled = false; //禁用"实时监控"按钮
                EnableBtn(false); //禁用设备控制按钮
                ResetData(); //数据和仪表复位
                isShowPumpStatus = false; //恢复读取泵的状态
            }
        }
        #endregion

        #region "实时监控"按钮事件
        private void btn_TurnOff_Click(object sender, EventArgs e)
        {
            if (this.btn_TurnOff.Tag.ToString() == "0")
            {
                this.timer1.Start(); //启动定时器
                this.btn_TurnOff.Tag = "1"; //1表示启动标记
                this.btn_TurnOff.Text = "关闭监控";
                EnableBtn(true); //启用设备控制按钮
            }
            else
            {
                this.timer1.Stop();
                ResetData();
                isShowPumpStatus=false;
                EnableBtn(false);
            }
        }
        #endregion

        #region 定时读取并显示数据
        private Dictionary<string, THData> dataDic = null; //两组温湿度数据
        private List<float> dataList = null; //进出压力模拟量值
        private bool[] pumpStatus = null; //4个水泵的状态
        private List<PressureData> pdList = new List<PressureData>(); //封装压力的实体类集合

        //定时器读取和显示数据
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.led_Time.Value = DateTime.Now;
            try
            {
                //1.读取两组温湿度数据
                this.dataDic = commService.ReadTHData(configData.SlaveId);
                //2.读取模拟量压力值
                this.dataList = commService.ReadPressureData(configData.SlaveId);
            }
            catch (Exception ex)
            {
                this.timer1.Stop(); //先停止定时器
                MessageBox.Show("读取数据异常：" + ex.Message, "异常提示");
                ResetData(); //数据复位
                isShowPumpStatus = false; //恢复读取泵的状态
            }
            //3.显示两组温湿度
            if (dataDic == null)
            {
                return;
            }
            this.meter1.Value = (float)dataDic["1号机房"].Temperature;
            this.meter2.Value = (float)dataDic["2号机房"].Temperature;
            this.wave1.Value = (int)dataDic["1号机房"].Humidity;
            this.wave2.Value = (int)dataDic["2号机房"].Humidity;
            this.lbl_Tem1.Value = dataDic["1号机房"].Temperature;
            this.lbl_Tem2.Value = dataDic["2号机房"].Temperature;
            this.lbl_Hum1.Value = dataDic["1号机房"].Humidity;
            this.lbl_Hum2.Value = dataDic["2号机房"].Humidity;
            //4.显示模拟量压力值
            if (dataList == null) return;
            this.dp1.Value = (decimal)Math.Round(dataList[0], 1); //保留一位小数
            this.dp2.Value = (decimal)Math.Round(dataList[1], 1);
            //5.读取输出线圈的状态（四个水泵的运行状态只读1次，防止定时和手动操作冲突）
            if (!isShowPumpStatus)
            {
                //读取输出线圈
                this.pumpStatus = commService.ReadPumpStatus(configData.SlaveId);
                //显示泵的运行状态（将泵的状态与泵的颜色和按钮同步）
                if (pumpStatus == null) return;
                //封装水泵名和水泵开关名的数组
                var WPumps = new[] { wPump1, wPump2, wPump3, wPump4 };
                var WPumpButtons = new[] { btn_WPump1, btn_WPump2, btn_WPump3, btn_WPump4 };
                //循环将每个泵的状态与开关进行同步
                for (int i = 0; i < 4; i++)
                {
                    if (WPumps[i].IsRun != pumpStatus[i])
                    {
                        WPumps[i].IsRun = WPumpButtons[i].Active = pumpStatus[i];
                    }
                }
                isShowPumpStatus = true; //不再实时同步泵的状态，避免与手动操作冲突（导致有时无法关闭）
            }
            //6.判断温湿度状态（用户报警提醒）
            this.led_THData.State = Sunny.UI.UILightState.On;
            this.lbl_THStatus.Text = "数据正常";

            if (dataDic["1号机房"].Temperature > 35.0
                || dataDic["1号机房"].Humidity > 40.0
                || dataDic["2号机房"].Temperature > 35.0
                || dataDic["2号机房"].Humidity > 40.0)
            {
                this.led_THData.State = Sunny.UI.UILightState.Off;
                this.lbl_THStatus.Text = "数据异常";
            }
            //7.判断进出水压力状态
            this.led_PreData.State = Sunny.UI.UILightState.On;
            this.lbl_PreStatus.Text = "数据正常";

            if (dataList[0] > 15.0f || dataList[1] > 15.0f
                || dataList[0] < 10.0f || dataList[1] < 10.0f)
            {
                this.led_PreData.State = Sunny.UI.UILightState.Off;
                this.lbl_PreStatus.Text = "数据异常";
            }
            //8.封装并显示dgv数据列表
            this.dgv_DataList.DataSource = null; //定时器每次先清除数据源
            if (this.pdList.Count == 10)
            {
                this.pdList.RemoveAt(0); //移除第一行数据
            }
            string status = "正常";
            if ((double)this.dp1.Value > 15.0 || (double)this.dp2.Value > 15.0)
            {
                status = "超限";
            }
            if ((double)this.dp1.Value < 10.0 || (double)this.dp2.Value < 10.0)
            {
                status = "不足";
            }
            pdList.Add(new PressureData()
            {
                CollectionTime = DateTime.Now.ToString("HH:mm:ss"),
                PressureIn = Math.Round(dataList[0], 1),
                PressureOut = Math.Round(dataList[1], 1),
                PressureStatus = status
            });
            this.dgv_DataList.DataSource = pdList;
        }
        #endregion

        #region "设备启停按钮"点击事件（优化）
        private void btnWPump_click(object sender, EventArgs e)
        {
            Sunny.UI.UISwitch btn = (Sunny.UI.UISwitch)sender;
            string btnTagContent = btn.Tag.ToString();
            string btnSubTag = btnTagContent.Substring(btnTagContent.IndexOf("swi_") + 4, btnTagContent.IndexOf(";") - 4);
            try
            {
                bool result = commService.StartOrStopDevice(configData.SlaveId, (ushort)(btnSubTag[4] - '1') , btn.Active);
                if (result)
                {
                    switch(btnSubTag)
                    {
                        case "pump1":
                            this.wPump1.IsRun = btn.Active;
                            break;
                        case "pump2":
                            this.wPump2.IsRun = btn.Active;
                            break;
                        case "pump3":
                            this.wPump3.IsRun = btn.Active;
                            break;
                        case "pump4":
                            this.wPump4.IsRun = btn.Active;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示");
            }
        }
        #endregion
    }
}
