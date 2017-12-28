using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            TXT_version.Text = "Version: " + Application.ProductVersion; // +" Build " + strVersion;
            //海帆添加20170228：修改公司logo和初始启动画面的配置
            TXT_version.Text = "Version:V1.0";
            label1.Text = "广州笨笨网络科技有限公司";

            if (Program.Logo != null)
            {
                pictureBox1.BackgroundImage = MissionPlanner.Properties.Resources.bgdark;
                //pictureBox1.Image = Program.Logo;
                pictureBox1.Visible = true;
            }
        }
    }
}