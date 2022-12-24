using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dota_HotKeys.Properties;

namespace Dota_HotKeys
{
    public partial class frmSettings : Form
    {
        public static frmSettings frmsettings;
        private bool mouseDown;     //Mover ventana
        private Point lastLocation; //Mover ventana
        bool state = false;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(modCommon.CurrentDirectory + @"\Sound/Menu.wav");

        public frmSettings()
        {
            InitializeComponent();
        }
        private void frmSettings_Load(object sender, EventArgs e)
        {
            frmsettings = this;
            frm.Settings1 uC_ = new frm.Settings1();
            addUserControl(uC_);
        }
        public void addUserControl(UserControl uc)
        {
            PanelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            PanelContainer.Controls.Add(uc);
        }
        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            modCommon.Ready = false;
            Close();
        }
        private void Event_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Event_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
                Opacity = 0.93;
            }
        }
        private void Event_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Opacity = 100;
        }
        private void CloseBox_Click(object sender, EventArgs e)
        {
            if(state == false)
            {
                modCommon.confi.Keys1 = frm.Settings1.settings1.Keys1.Text;
                modCommon.confi.Keys2 = frm.Settings1.settings1.Keys2.Text;
                modCommon.confi.Keys3 = frm.Settings1.settings1.Keys3.Text;
                modCommon.confi.Keys4 = frm.Settings1.settings1.Keys4.Text;
                modCommon.confi.Keys5 = frm.Settings1.settings1.Keys5.Text;
                modCommon.confi.Keys6 = frm.Settings1.settings1.Keys6.Text;
                modCommon.confi.Keys7 = frm.Settings1.settings1.Keys7.Text;
                modCommon.confi.Keys8 = frm.Settings1.settings1.Keys8.Text;
                modCommon.confi.Keys9 = frm.Settings1.settings1.Keys9.Text;
                modCommon.confi.Keys10 = frm.Settings1.settings1.Keys10.Text;
                modCommon.confi.Keys11 = frm.Settings1.settings1.Keys11.Text;
                modCommon.confi.Keys12 = frm.Settings1.settings1.Keys12.Text;
                modCommon.confi.Keys13 = frm.Settings1.settings1.Keys13.Text;
                modCommon.confi.Keys14 = frm.Settings1.settings1.Keys14.Text;
                modCommon.confi.Keys15 = frm.Settings1.settings1.Keys15.Text;
                modCommon.confi.Keys16 = frm.Settings1.settings1.Keys16.Text;
                modCommon.confi.Keys17 = frm.Settings1.settings1.Keys17.Text;
                modCommon.confi.Keys18 = frm.Settings1.settings1.Keys18.Text;
                modCommon.confi.Keys19 = frm.Settings1.settings1.Keys19.Text;
                modCommon.confi.Keys20 = frm.Settings1.settings1.Keys20.Text;
                modCommon.confi.Keys21 = frm.Settings1.settings1.Keys21.Text;
                modCommon.confi.Keys22 = frm.Settings1.settings1.Keys22.Text;
                modCommon.confi.Keys23 = frm.Settings1.settings1.Keys23.Text;
                modCommon.confi.Keys24 = frm.Settings1.settings1.Keys24.Text;
                modCommon.confi.Keys25 = frm.Settings1.settings1.Keys25.Text;
            }
            else
            {
                modCommon.confi.Keys26 = frm.Settings2.settings2.Keys26.Text;
                modCommon.confi.Keys27 = frm.Settings2.settings2.Keys27.Text;
                modCommon.confi.Keys28 = frm.Settings2.settings2.Keys28.Text;
                modCommon.confi.Keys29 = frm.Settings2.settings2.Keys29.Text;
                modCommon.confi.Keys30 = frm.Settings2.settings2.Keys30.Text;
                modCommon.confi.Keys31 = frm.Settings2.settings2.Keys31.Text;
                modCommon.confi.Keys32 = frm.Settings2.settings2.Keys32.Text;
                modCommon.confi.Keys33 = frm.Settings2.settings2.Keys33.Text;
                modCommon.confi.Keys34 = frm.Settings2.settings2.Keys34.Text;
                modCommon.confi.Keys35 = frm.Settings2.settings2.Keys35.Text;
                modCommon.confi.Keys36 = frm.Settings2.settings2.Keys36.Text;
                modCommon.confi.Keys37 = frm.Settings2.settings2.Keys37.Text;
                modCommon.confi.Keys38 = frm.Settings2.settings2.Keys38.Text;
                modCommon.confi.Keys39 = frm.Settings2.settings2.Keys39.Text;
                modCommon.confi.Keys40 = frm.Settings2.settings2.Keys40.Text;
                modCommon.confi.Keys41 = frm.Settings2.settings2.Keys41.Text;
            }
            modCommon.Serializar();

            modCommon.Ready = false;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(modCommon.CurrentDirectory + @"\Sound/Setting2.wav");
            player.Play();
            frmMain.frmmain.Transition.HideSync(this);
        }
        private void CloseBox_MouseLeave(object sender, EventArgs e)
        {
            CloseBox.Image = Resources.SClose1;
        }
        private void CloseBox_MouseMove(object sender, MouseEventArgs e)
        {
            CloseBox.Image = Resources.SClose2;
        }
        private void ResetHotkeys_Click(object sender, EventArgs e)
        {
            player.Play();
            if (modCommon.uc == false)
            {
                modCommon.confi.Keys1 = "Q";
                modCommon.confi.Keys2 = "W";
                modCommon.confi.Keys3 = "E";
                modCommon.confi.Keys4 = "D";
                modCommon.confi.Keys5 = "F";
                modCommon.confi.Keys6 = "R";
                modCommon.confi.Keys7 = "Z";
                modCommon.confi.Keys8 = "X";
                modCommon.confi.Keys9 = "C";
                modCommon.confi.Keys10 = "V";
                modCommon.confi.Keys11 = "B";
                modCommon.confi.Keys12 = "N";
                modCommon.confi.Keys13 = "F1";
                modCommon.confi.Keys14 = "";
                modCommon.confi.Keys15 = "A";
                modCommon.confi.Keys16 = "H";
                modCommon.confi.Keys17 = "F2";
                modCommon.confi.Keys18 = "F3";
                modCommon.confi.Keys19 = "F5";
                modCommon.confi.Keys20 = "Tab";
                modCommon.confi.Keys21 = "";
                modCommon.confi.Keys22 = "1";
                modCommon.confi.Keys23 = "2";
                modCommon.confi.Keys24 = "3";
                modCommon.confi.Keys25 = "4";
                frm.Settings1.settings1.Keys1.Text = modCommon.confi.Keys1;
                frm.Settings1.settings1.Keys2.Text = modCommon.confi.Keys2;
                frm.Settings1.settings1.Keys3.Text = modCommon.confi.Keys3;
                frm.Settings1.settings1.Keys4.Text = modCommon.confi.Keys4;
                frm.Settings1.settings1.Keys5.Text = modCommon.confi.Keys5;
                frm.Settings1.settings1.Keys6.Text = modCommon.confi.Keys6;
                frm.Settings1.settings1.Keys7.Text = modCommon.confi.Keys7;
                frm.Settings1.settings1.Keys8.Text = modCommon.confi.Keys8;
                frm.Settings1.settings1.Keys9.Text = modCommon.confi.Keys9;
                frm.Settings1.settings1.Keys10.Text = modCommon.confi.Keys10;
                frm.Settings1.settings1.Keys11.Text = modCommon.confi.Keys11;
                frm.Settings1.settings1.Keys12.Text = modCommon.confi.Keys12;
                frm.Settings1.settings1.Keys13.Text = modCommon.confi.Keys13;
                frm.Settings1.settings1.Keys14.Text = modCommon.confi.Keys14;
                frm.Settings1.settings1.Keys15.Text = modCommon.confi.Keys15;
                frm.Settings1.settings1.Keys16.Text = modCommon.confi.Keys16;
                frm.Settings1.settings1.Keys17.Text = modCommon.confi.Keys17;
                frm.Settings1.settings1.Keys18.Text = modCommon.confi.Keys18;
                frm.Settings1.settings1.Keys19.Text = modCommon.confi.Keys19;
                frm.Settings1.settings1.Keys20.Text = modCommon.confi.Keys20;
                frm.Settings1.settings1.Keys21.Text = modCommon.confi.Keys21;
                frm.Settings1.settings1.Keys22.Text = modCommon.confi.Keys22;
                frm.Settings1.settings1.Keys23.Text = modCommon.confi.Keys23;
                frm.Settings1.settings1.Keys24.Text = modCommon.confi.Keys24;
                frm.Settings1.settings1.Keys25.Text = modCommon.confi.Keys25;
            }
            else
            {

            }
        }
        private void ResetHotkeys_MouseLeave(object sender, EventArgs e)
        {
            UIDC.UI_LabelMaterial label = (UIDC.UI_LabelMaterial)sender;
            label.ForeColor = Color.FromArgb(100, 88, 255);
        }
        private void ResetHotkeys_MouseMove(object sender, MouseEventArgs e)
        {
            UIDC.UI_LabelMaterial label = (UIDC.UI_LabelMaterial)sender;
            label.ForeColor = Color.FromArgb(255, 255, 255);
        }
        private void AdvancedHotkeys_Click(object sender, EventArgs e)
        {
            if(state == false)
            {
                modCommon.confi.Keys1 = frm.Settings1.settings1.Keys1.Text;
                modCommon.confi.Keys2 = frm.Settings1.settings1.Keys2.Text;
                modCommon.confi.Keys3 = frm.Settings1.settings1.Keys3.Text;
                modCommon.confi.Keys4 = frm.Settings1.settings1.Keys4.Text;
                modCommon.confi.Keys5 = frm.Settings1.settings1.Keys5.Text;
                modCommon.confi.Keys6 = frm.Settings1.settings1.Keys6.Text;
                modCommon.confi.Keys7 = frm.Settings1.settings1.Keys7.Text;
                modCommon.confi.Keys8 = frm.Settings1.settings1.Keys8.Text;
                modCommon.confi.Keys9 = frm.Settings1.settings1.Keys9.Text;
                modCommon.confi.Keys10 = frm.Settings1.settings1.Keys10.Text;
                modCommon.confi.Keys11 = frm.Settings1.settings1.Keys11.Text;
                modCommon.confi.Keys12 = frm.Settings1.settings1.Keys12.Text;
                modCommon.confi.Keys13 = frm.Settings1.settings1.Keys13.Text;
                modCommon.confi.Keys14 = frm.Settings1.settings1.Keys14.Text;
                modCommon.confi.Keys15 = frm.Settings1.settings1.Keys15.Text;
                modCommon.confi.Keys16 = frm.Settings1.settings1.Keys16.Text;
                modCommon.confi.Keys17 = frm.Settings1.settings1.Keys17.Text;
                modCommon.confi.Keys18 = frm.Settings1.settings1.Keys18.Text;
                modCommon.confi.Keys19 = frm.Settings1.settings1.Keys19.Text;
                modCommon.confi.Keys20 = frm.Settings1.settings1.Keys20.Text;
                modCommon.confi.Keys21 = frm.Settings1.settings1.Keys21.Text;
                modCommon.confi.Keys22 = frm.Settings1.settings1.Keys22.Text;
                modCommon.confi.Keys23 = frm.Settings1.settings1.Keys23.Text;
                modCommon.confi.Keys24 = frm.Settings1.settings1.Keys24.Text;
                modCommon.confi.Keys25 = frm.Settings1.settings1.Keys25.Text;
                modCommon.Serializar();
                state = true;
                player.Play();
                frm.Settings2 uC_ = new frm.Settings2();
                addUserControl(uC_);
            }
            else
            {
                modCommon.confi.Keys26 = frm.Settings2.settings2.Keys26.Text;
                modCommon.confi.Keys27 = frm.Settings2.settings2.Keys27.Text;
                modCommon.confi.Keys28 = frm.Settings2.settings2.Keys28.Text;
                modCommon.confi.Keys29 = frm.Settings2.settings2.Keys29.Text;
                modCommon.confi.Keys30 = frm.Settings2.settings2.Keys30.Text;
                modCommon.confi.Keys31 = frm.Settings2.settings2.Keys31.Text;
                modCommon.confi.Keys32 = frm.Settings2.settings2.Keys32.Text;
                modCommon.confi.Keys33 = frm.Settings2.settings2.Keys33.Text;
                modCommon.confi.Keys34 = frm.Settings2.settings2.Keys34.Text;
                modCommon.confi.Keys35 = frm.Settings2.settings2.Keys35.Text;
                modCommon.confi.Keys36 = frm.Settings2.settings2.Keys36.Text;
                modCommon.confi.Keys37 = frm.Settings2.settings2.Keys37.Text;
                modCommon.confi.Keys38 = frm.Settings2.settings2.Keys38.Text;
                modCommon.confi.Keys39 = frm.Settings2.settings2.Keys39.Text;
                modCommon.confi.Keys40 = frm.Settings2.settings2.Keys40.Text;
                modCommon.confi.Keys41 = frm.Settings2.settings2.Keys41.Text;
                modCommon.Serializar();
                state = false;
                player.Play();
                frm.Settings1 uC_ = new frm.Settings1();
                addUserControl(uC_);
            }
        }
        private void AdvancedHotkeys_MouseLeave(object sender, EventArgs e)
        {
            UIDC.UI_LabelMaterial label = (UIDC.UI_LabelMaterial)sender;
            label.ForeColor = Color.FromArgb(100, 88, 255);
        }
        private void AdvancedHotkeys_MouseMove(object sender, MouseEventArgs e)
        {
            UIDC.UI_LabelMaterial label = (UIDC.UI_LabelMaterial)sender;
            label.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
