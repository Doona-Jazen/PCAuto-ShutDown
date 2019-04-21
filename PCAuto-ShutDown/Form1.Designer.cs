namespace PCAuto_ShutDown
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.distime_timer = new System.Windows.Forms.Timer(this.components);
            this.h_label = new System.Windows.Forms.Label();
            this.ask_label = new System.Windows.Forms.Label();
            this.mh_label = new System.Windows.Forms.Label();
            this.m_label = new System.Windows.Forms.Label();
            this.ha_button = new System.Windows.Forms.Button();
            this.hs_button = new System.Windows.Forms.Button();
            this.ma_button = new System.Windows.Forms.Button();
            this.ms_button = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.dish_label = new System.Windows.Forms.Label();
            this.dism_label = new System.Windows.Forms.Label();
            this.dis_h_time = new System.Windows.Forms.Label();
            this.dis_m_time = new System.Windows.Forms.Label();
            this.sub_panel = new System.Windows.Forms.Panel();
            this.msbCheckBox = new System.Windows.Forms.CheckBox();
            this.hm_label = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.dis_s_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dis_m_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dis_h_label = new System.Windows.Forms.Label();
            this.mini_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.topinfo_label = new System.Windows.Forms.Label();
            this.sub_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // distime_timer
            // 
            this.distime_timer.Tick += new System.EventHandler(this.distime_timer_Tick);
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.h_label.ForeColor = System.Drawing.Color.Orange;
            this.h_label.Location = new System.Drawing.Point(93, 76);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(83, 62);
            this.h_label.TabIndex = 0;
            this.h_label.Text = "00";
            // 
            // ask_label
            // 
            this.ask_label.AutoSize = true;
            this.ask_label.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ask_label.Location = new System.Drawing.Point(33, 31);
            this.ask_label.Name = "ask_label";
            this.ask_label.Size = new System.Drawing.Size(348, 21);
            this.ask_label.TabIndex = 2;
            this.ask_label.Text = "What time do you want to shut down";
            // 
            // mh_label
            // 
            this.mh_label.AutoSize = true;
            this.mh_label.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mh_label.ForeColor = System.Drawing.Color.Orange;
            this.mh_label.Location = new System.Drawing.Point(198, 84);
            this.mh_label.Name = "mh_label";
            this.mh_label.Size = new System.Drawing.Size(28, 46);
            this.mh_label.TabIndex = 3;
            this.mh_label.Text = ":";
            // 
            // m_label
            // 
            this.m_label.AutoSize = true;
            this.m_label.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_label.ForeColor = System.Drawing.Color.Orange;
            this.m_label.Location = new System.Drawing.Point(219, 76);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(83, 62);
            this.m_label.TabIndex = 1;
            this.m_label.Text = "00";
            // 
            // ha_button
            // 
            this.ha_button.BackColor = System.Drawing.Color.White;
            this.ha_button.FlatAppearance.BorderSize = 0;
            this.ha_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ha_button.ForeColor = System.Drawing.Color.Green;
            this.ha_button.Location = new System.Drawing.Point(167, 80);
            this.ha_button.Name = "ha_button";
            this.ha_button.Size = new System.Drawing.Size(25, 28);
            this.ha_button.TabIndex = 4;
            this.ha_button.Text = "▲";
            this.ha_button.UseVisualStyleBackColor = false;
            this.ha_button.Click += new System.EventHandler(this.ha_button_Click);
            // 
            // hs_button
            // 
            this.hs_button.BackColor = System.Drawing.Color.White;
            this.hs_button.FlatAppearance.BorderSize = 0;
            this.hs_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hs_button.ForeColor = System.Drawing.Color.Green;
            this.hs_button.Location = new System.Drawing.Point(167, 106);
            this.hs_button.Name = "hs_button";
            this.hs_button.Size = new System.Drawing.Size(25, 28);
            this.hs_button.TabIndex = 5;
            this.hs_button.Text = "▼";
            this.hs_button.UseVisualStyleBackColor = false;
            this.hs_button.Click += new System.EventHandler(this.hs_button_Click);
            // 
            // ma_button
            // 
            this.ma_button.BackColor = System.Drawing.Color.White;
            this.ma_button.FlatAppearance.BorderSize = 0;
            this.ma_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ma_button.ForeColor = System.Drawing.Color.Green;
            this.ma_button.Location = new System.Drawing.Point(290, 78);
            this.ma_button.Name = "ma_button";
            this.ma_button.Size = new System.Drawing.Size(25, 28);
            this.ma_button.TabIndex = 6;
            this.ma_button.Text = "▲";
            this.ma_button.UseVisualStyleBackColor = false;
            this.ma_button.Click += new System.EventHandler(this.ma_button_Click);
            // 
            // ms_button
            // 
            this.ms_button.BackColor = System.Drawing.Color.White;
            this.ms_button.FlatAppearance.BorderSize = 0;
            this.ms_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ms_button.ForeColor = System.Drawing.Color.Green;
            this.ms_button.Location = new System.Drawing.Point(290, 108);
            this.ms_button.Name = "ms_button";
            this.ms_button.Size = new System.Drawing.Size(25, 28);
            this.ms_button.TabIndex = 7;
            this.ms_button.Text = "▼";
            this.ms_button.UseVisualStyleBackColor = false;
            this.ms_button.Click += new System.EventHandler(this.ms_button_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(100, 159);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(121, 20);
            this.info_label.TabIndex = 8;
            this.info_label.Text = "距离关机还剩下：";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.White;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start_button.ForeColor = System.Drawing.Color.Orange;
            this.start_button.Location = new System.Drawing.Point(179, 204);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(74, 34);
            this.start_button.TabIndex = 9;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // dish_label
            // 
            this.dish_label.AutoSize = true;
            this.dish_label.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dish_label.ForeColor = System.Drawing.Color.Orange;
            this.dish_label.Location = new System.Drawing.Point(239, 159);
            this.dish_label.Name = "dish_label";
            this.dish_label.Size = new System.Drawing.Size(37, 19);
            this.dish_label.TabIndex = 10;
            this.dish_label.Text = "小时";
            // 
            // dism_label
            // 
            this.dism_label.AutoSize = true;
            this.dism_label.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dism_label.ForeColor = System.Drawing.Color.Orange;
            this.dism_label.Location = new System.Drawing.Point(300, 159);
            this.dism_label.Name = "dism_label";
            this.dism_label.Size = new System.Drawing.Size(37, 19);
            this.dism_label.TabIndex = 11;
            this.dism_label.Text = "分钟";
            // 
            // dis_h_time
            // 
            this.dis_h_time.AutoSize = true;
            this.dis_h_time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dis_h_time.ForeColor = System.Drawing.Color.Green;
            this.dis_h_time.Location = new System.Drawing.Point(216, 160);
            this.dis_h_time.Name = "dis_h_time";
            this.dis_h_time.Size = new System.Drawing.Size(27, 19);
            this.dis_h_time.TabIndex = 12;
            this.dis_h_time.Text = "00";
            // 
            // dis_m_time
            // 
            this.dis_m_time.AutoSize = true;
            this.dis_m_time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dis_m_time.ForeColor = System.Drawing.Color.Green;
            this.dis_m_time.Location = new System.Drawing.Point(275, 159);
            this.dis_m_time.Name = "dis_m_time";
            this.dis_m_time.Size = new System.Drawing.Size(27, 19);
            this.dis_m_time.TabIndex = 13;
            this.dis_m_time.Text = "00";
            // 
            // sub_panel
            // 
            this.sub_panel.Controls.Add(this.msbCheckBox);
            this.sub_panel.Controls.Add(this.hm_label);
            this.sub_panel.Controls.Add(this.day_label);
            this.sub_panel.Controls.Add(this.dis_s_label);
            this.sub_panel.Controls.Add(this.label6);
            this.sub_panel.Controls.Add(this.dis_m_label);
            this.sub_panel.Controls.Add(this.label2);
            this.sub_panel.Controls.Add(this.dis_h_label);
            this.sub_panel.Controls.Add(this.mini_button);
            this.sub_panel.Controls.Add(this.cancel_button);
            this.sub_panel.Controls.Add(this.label3);
            this.sub_panel.Controls.Add(this.topinfo_label);
            this.sub_panel.Location = new System.Drawing.Point(0, 5);
            this.sub_panel.Name = "sub_panel";
            this.sub_panel.Size = new System.Drawing.Size(434, 264);
            this.sub_panel.TabIndex = 14;
            this.sub_panel.Visible = false;
            this.sub_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sub_panel_Paint);
            // 
            // msbCheckBox
            // 
            this.msbCheckBox.AutoSize = true;
            this.msbCheckBox.Checked = true;
            this.msbCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.msbCheckBox.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msbCheckBox.Location = new System.Drawing.Point(173, 145);
            this.msbCheckBox.Name = "msbCheckBox";
            this.msbCheckBox.Size = new System.Drawing.Size(82, 19);
            this.msbCheckBox.TabIndex = 28;
            this.msbCheckBox.Text = "关机确认";
            this.msbCheckBox.UseVisualStyleBackColor = true;
            // 
            // hm_label
            // 
            this.hm_label.AutoSize = true;
            this.hm_label.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hm_label.ForeColor = System.Drawing.Color.Orange;
            this.hm_label.Location = new System.Drawing.Point(254, 173);
            this.hm_label.Name = "hm_label";
            this.hm_label.Size = new System.Drawing.Size(49, 19);
            this.hm_label.TabIndex = 27;
            this.hm_label.Text = "00:00";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.day_label.ForeColor = System.Drawing.Color.Green;
            this.day_label.Location = new System.Drawing.Point(211, 172);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(37, 19);
            this.day_label.TabIndex = 26;
            this.day_label.Text = "今天";
            // 
            // dis_s_label
            // 
            this.dis_s_label.AutoSize = true;
            this.dis_s_label.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dis_s_label.ForeColor = System.Drawing.Color.Orange;
            this.dis_s_label.Location = new System.Drawing.Point(274, 70);
            this.dis_s_label.Name = "dis_s_label";
            this.dis_s_label.Size = new System.Drawing.Size(83, 62);
            this.dis_s_label.TabIndex = 24;
            this.dis_s_label.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(250, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 46);
            this.label6.TabIndex = 25;
            this.label6.Text = ":";
            // 
            // dis_m_label
            // 
            this.dis_m_label.AutoSize = true;
            this.dis_m_label.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dis_m_label.ForeColor = System.Drawing.Color.Orange;
            this.dis_m_label.Location = new System.Drawing.Point(174, 70);
            this.dis_m_label.Name = "dis_m_label";
            this.dis_m_label.Size = new System.Drawing.Size(83, 62);
            this.dis_m_label.TabIndex = 22;
            this.dis_m_label.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(151, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 46);
            this.label2.TabIndex = 23;
            this.label2.Text = ":";
            // 
            // dis_h_label
            // 
            this.dis_h_label.AutoSize = true;
            this.dis_h_label.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dis_h_label.ForeColor = System.Drawing.Color.Orange;
            this.dis_h_label.Location = new System.Drawing.Point(78, 70);
            this.dis_h_label.Name = "dis_h_label";
            this.dis_h_label.Size = new System.Drawing.Size(83, 62);
            this.dis_h_label.TabIndex = 21;
            this.dis_h_label.Text = "00";
            // 
            // mini_button
            // 
            this.mini_button.BackColor = System.Drawing.Color.White;
            this.mini_button.FlatAppearance.BorderSize = 0;
            this.mini_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini_button.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mini_button.ForeColor = System.Drawing.Color.Orange;
            this.mini_button.Location = new System.Drawing.Point(258, 200);
            this.mini_button.Name = "mini_button";
            this.mini_button.Size = new System.Drawing.Size(77, 34);
            this.mini_button.TabIndex = 20;
            this.mini_button.Text = "Mini";
            this.mini_button.UseVisualStyleBackColor = false;
            this.mini_button.Click += new System.EventHandler(this.mini_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.White;
            this.cancel_button.FlatAppearance.BorderSize = 0;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel_button.ForeColor = System.Drawing.Color.Orange;
            this.cancel_button.Location = new System.Drawing.Point(106, 200);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(87, 34);
            this.cancel_button.TabIndex = 19;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "关机时间：";
            // 
            // topinfo_label
            // 
            this.topinfo_label.AutoSize = true;
            this.topinfo_label.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.topinfo_label.Location = new System.Drawing.Point(155, 25);
            this.topinfo_label.Name = "topinfo_label";
            this.topinfo_label.Size = new System.Drawing.Size(124, 21);
            this.topinfo_label.TabIndex = 12;
            this.topinfo_label.Text = "距离关机还有";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 271);
            this.Controls.Add(this.sub_panel);
            this.Controls.Add(this.dis_m_time);
            this.Controls.Add(this.dis_h_time);
            this.Controls.Add(this.dism_label);
            this.Controls.Add(this.dish_label);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.ms_button);
            this.Controls.Add(this.ma_button);
            this.Controls.Add(this.hs_button);
            this.Controls.Add(this.ha_button);
            this.Controls.Add(this.m_label);
            this.Controls.Add(this.mh_label);
            this.Controls.Add(this.ask_label);
            this.Controls.Add(this.h_label);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCAuto ShutDown";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sub_panel.ResumeLayout(false);
            this.sub_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer distime_timer;
        private System.Windows.Forms.Label h_label;
        private System.Windows.Forms.Label ask_label;
        private System.Windows.Forms.Label mh_label;
        private System.Windows.Forms.Label m_label;
        private System.Windows.Forms.Button ha_button;
        private System.Windows.Forms.Button hs_button;
        private System.Windows.Forms.Button ma_button;
        private System.Windows.Forms.Button ms_button;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label dish_label;
        private System.Windows.Forms.Label dism_label;
        private System.Windows.Forms.Label dis_h_time;
        private System.Windows.Forms.Label dis_m_time;
        private System.Windows.Forms.Panel sub_panel;
        private System.Windows.Forms.Button mini_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label topinfo_label;
        private System.Windows.Forms.Label dis_m_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dis_h_label;
        private System.Windows.Forms.Label dis_s_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label hm_label;
        private System.Windows.Forms.CheckBox msbCheckBox;
    }
}

