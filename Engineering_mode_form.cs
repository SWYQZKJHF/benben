using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Engineering_mode_form : Form
    {
        
        public bool open_engineering_mode = false;

        public Engineering_mode_form()
        {
            InitializeComponent();
        }

        private void comfirm_eng_Click(object sender, EventArgs e)
        {
            if (PassWord_textbox.Text == "123")
            {
                open_engineering_mode = true;
                this.Close();
            }
            else {
                PassWord_textbox.Text = "";
                //MessageBox.Show("密码错误，请重新输入。");
                CustomMessageBox.Show("Wrong PassWord,Please try again! ");
            }
        }

        private void cancel_eng_Click(object sender, EventArgs e)
        {
            open_engineering_mode = false;
            this.Close();
        }

        private void PassWord_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                comfirm_eng_Click( sender,  e);
            }
        }
    }
}