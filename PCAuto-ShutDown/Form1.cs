using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PCAuto_ShutDown
{
    public partial class MainForm : Form
    {
        //自定义消息提示框
        NewMessageBox newMsg = new NewMessageBox();
        //建立通信，使得点击窗体可以移动--点击控件除外
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
            {
                message.Result = (IntPtr)HTCAPTION;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {//主窗体加载方法
            DateTime now_time = DateTime.Now;
            h_label.Text = now_time.Hour.ToString();
            if (h_label.Text.Length < 2)
            {
                h_label.Text = '0' + h_label.Text;
            }
            m_label.Text ="00";
            distime_timer.Start();
        }
        private void ha_button_Click(object sender, EventArgs e)
        {////hours to add
            h_label.Text=(Convert.ToInt32(h_label.Text)+1).ToString();
            if (Convert.ToInt32(h_label.Text) == 24)
            {
                h_label.Text = "00";
            }
        }

        private void hs_button_Click(object sender, EventArgs e)
        {//hours to sub
            h_label.Text = (Convert.ToInt32(h_label.Text) - 1).ToString();
            if (Convert.ToInt32(h_label.Text) == -1)
            {
                h_label.Text = "23";
            }
        }

        private void ma_button_Click(object sender, EventArgs e)
        {//minutes to add
            m_label.Text = (Convert.ToInt32(m_label.Text) + 5).ToString();
            if (Convert.ToInt32(m_label.Text) == 60)
            {
                m_label.Text = "00";
            }
        }

        private void ms_button_Click(object sender, EventArgs e)
        {//minutes to sub
            m_label.Text = (Convert.ToInt32(m_label.Text) - 5).ToString();
            if (Convert.ToInt32(m_label.Text) == -5)
            {
                m_label.Text = "55";
            }
        }

        
        private void start_button_Click(object sender, EventArgs e)
        {
            distime_timer.Enabled = true;
            sub_panel.Refresh();
            sub_panel.Visible = true;
        }
        private void sub_panel_Paint(object sender, PaintEventArgs e)
        {
            dis_h_label.Text = dis_h_time.Text;
            dis_m_label.Text = dis_m_time.Text;

            if (dis_s_label.Text.Length < 2)
            {
                dis_s_label.Text = "0" + dis_s_label.Text;
            }
            if (dis_m_label.Text.Length < 2)
            {
                dis_m_label.Text = "0" + dis_m_label.Text;
            }
            if (dis_h_label.Text.Length < 2)
            {
                dis_h_label.Text = "0" + dis_h_label.Text;
            }

            if (Convert.ToInt32(h_label.Text) < DateTime.Now.Hour)
            {
                day_label.Text = "明天";
            }
            else if ((Convert.ToInt32(h_label.Text) == DateTime.Now.Hour) && (Convert.ToInt32(m_label.Text) < DateTime.Now.Minute))
            {
                day_label.Text = "明天";
            }
            else
            {
                day_label.Text = "今天";
            }
            hm_label.Text = h_label.Text + ":" + m_label.Text;
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            distime_timer.Enabled = false;
            sub_panel.Visible = false;
            distime_timer.Start();
        }

        private void mini_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void distime_timer_Tick(object sender, EventArgs e)
        {
            int dis_h = Convert.ToInt32(h_label.Text) - DateTime.Now.Hour;
            int dis_m = Convert.ToInt32(m_label.Text) - DateTime.Now.Minute - 1;
            int dis_s = 59 - DateTime.Now.Second;


            if (dis_m < 0)
            {
                dis_h = dis_h - 1;
                dis_m = 59 - Math.Abs(dis_m);
            }
            if (dis_h < 0)
            {
                dis_h = 24 - Math.Abs(dis_h);
            }
            dis_h_time.Text = dis_h.ToString();
            dis_m_time.Text = dis_m.ToString();

            if (dis_s < 0)
            {
                dis_m = dis_m - 1;
                dis_s = 59 - Math.Abs(dis_s);
            }

            dis_h_label.Text = dis_h.ToString();
            dis_m_label.Text = dis_m.ToString();
            dis_s_label.Text = dis_s.ToString();

            if (sub_panel.Visible)
            {
                int finalTime = Convert.ToInt32(dis_h_label.Text + dis_m_label.Text + dis_s_label.Text);

                if (finalTime == 0)
                {
                    distime_timer.Enabled = false;
                    if (msbCheckBox.Checked)
                    {
                        newMsg.ShowDialog();
                        DialogResult dr = newMsg.dialogResult;
                        if (dr == DialogResult.OK)
                        {
                            Process.Start("shutdown.exe", "-s");//关机
                        }
                        else
                        {
                            sub_panel.Visible = false;
                            distime_timer.Start();
                        }
                    }
                    else
                    {
                        Process.Start("shutdown.exe", "-s");//关机
                    }
                }
            }
        }
    }
}
