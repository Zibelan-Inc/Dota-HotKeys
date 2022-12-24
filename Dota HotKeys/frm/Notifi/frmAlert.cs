using Dota_HotKeys.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dota_HotKeys
{
    public partial class frmAlert : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(modCommon.CurrentDirectory + @"\Sound/Suspense.wav");
        public frmAlert()
        {
            InitializeComponent();
        }
        public enum alertTypeEnum
        {
            Roshan,
        }
        private int x, y;
        private int min, seg;
        public void setAlert(string msg, frmAlert.alertTypeEnum type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmAlert f = (frmAlert)Application.OpenForms[fname];

                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 1788;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 270 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case frmAlert.alertTypeEnum.Roshan:
                    this.GunaPictureBox1.Image = Resources.icon_roshan;
                    this.BackColor = Color.FromArgb(31, 32, 35);
                    break;
            }
            if(msg == "Roshan")
            {
                modCommon.roshan = true;
                this.GunaLabel1.Text = "00:00";
            }
            else
            {
                this.GunaLabel1.Text = msg;
            }

            //this.TopMost = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;

            this.Show();
            this.action = actionEnum.start;
            if(modCommon.roshan == true)
            {
                this.timerRoshan.Start();
                min = 8;
                seg = 0;
            }
            this.Timer1.Start();
        }
        public enum actionEnum
        {
            wait,
            start,
            close
        }
        private frmAlert.actionEnum action;
        private void GunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Timer1.Interval = 1;
            this.action = frmAlert.actionEnum.close;
        }

        private void timerRoshan_Tick(object sender, EventArgs e)
        {
            if(seg > 0)
            {
                seg -= 1;
            }

            string minutos = min.ToString();
            string segundos = seg.ToString();

            if (min < 10) { minutos = "0" + min.ToString(); };
            if (seg < 10) { segundos = "0" + seg.ToString(); };

            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }
            if (min == 0 && seg == 0)
            {
                timerRoshan.Stop();
                modCommon.roshan = false;
                this.BackColor = Color.FromArgb(42, 171, 160);
                player.Play();
            }
            this.GunaLabel1.Text = minutos + ":" + segundos;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case frmAlert.actionEnum.wait:
                    if(modCommon.roshan == true)
                    {
                        this.Timer1.Interval = 485000;
                    }
                    else
                    {
                        this.Timer1.Interval = 5000;
                    }
                    this.action = frmAlert.actionEnum.close;
                    break;
                case frmAlert.actionEnum.start:
                    this.Timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = frmAlert.actionEnum.wait;
                        }
                    }
                    break;
                case frmAlert.actionEnum.close:
                    this.Timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
