using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form : System.Windows.Forms.Form
    {
        string[] teaBag = { "홍차", "녹차", "루이보스차", "국화차" };
        string str = "시간 : ";
        int countTime = 0;
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < teaBag.Length; i++)
            {
                this.cbBox.Items.Add(teaBag[i]);
            }
            if(this.cbBox.Items.Count > 0)
            {
                this.cbBox.SelectedIndex = 0;
            }
        }

        private void cbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbBox.SelectedItem.Equals("홍차")||this.cbBox.SelectedItem.Equals("국화차"))
            {
                this.teaTime.Text = str + "2분";
                countTime = 120;
            }else if (this.cbBox.SelectedItem.Equals("녹차"))
            {
                this.teaTime.Text = str + "3분";
                countTime = 180;
            }
            else if (this.cbBox.SelectedItem.Equals("루이보스차"))
            {
                this.teaTime.Text = str + "5분";
                countTime = 300;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(countTime < 1)
            {
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbBox.Focus();
            }
            else
            {
                this.countTime--;
                int min = this.countTime / 60;
                int sec = this.countTime % 60;
                this.result.Text = min + "분 " + sec + "초 남았습니다.";
            }
        }
    }
}
