using Dota_HotKeys.Properties;
using Shortcut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dota_HotKeys
{
    public partial class frmMain : Form
    {
        public static frmMain frmmain;
        List<Control> Menus = new List<Control>();
        string menusselecter;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(modCommon.CurrentDirectory + @"\Sound/Menu.wav");

        public frmMain()
        {
            InitializeComponent();
        }
        private bool home;
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmmain = this;
            SetParents();
            menusselecter = "HEROES";
            buttonHeroes.ForeColor = Color.White;
            banner.Image = Resources.M1;
            frm.Heroes uC_ = new frm.Heroes();
            addUserControl(uC_);
            try
            {
               modCommon._hotkeyBinder.Unbind(Modifiers.Alt, Keys.Home);
            }
            catch { }
            modCommon._hotkeyBinder.Bind(Modifiers.Alt, Keys.Home).To(Hotkeys);
            home = false;
        }
        public void Hotkeys()
        {
            if(home == true)
            {
                this.Show();
                home = false;
                notifyIcon1.Visible = false;
            }
            else
            {
                this.Hide();
                home = true;
                notifyIcon1.Visible = true;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            home = false;
            notifyIcon1.Visible = false;
            this.Show();
        }
        public void addUserControl(UserControl uc)
        {
            PanelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            PanelContainer.Controls.Add(uc);
        }
        private void SetParents()
        {
            //Menus.Add(labelHeroes);
            //Menus.Add(labelWord);

            foreach (Control item in Menus)
            {
                if (item is Panel)
                {
                    item.Parent = banner;
                }
                //
            }

            OpenSettings.Parent = banner;
            buttonHeroes.Parent = banner;
            buttonLog.Parent = banner;
            MiniBox.Parent = banner;
            CloseBox.Parent = banner;
        }
        private void OpenSettings_Click(object sender, EventArgs e)
        {
            if (modCommon.Ready == true)
                return;
            frmSettings settings = new frmSettings();
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(modCommon.CurrentDirectory + @"\Sound/Setting1.wav");
            player2.Play();
            Transition.ShowSync(settings);
        }
        private void OpenSettings_MouseLeave(object sender, EventArgs e)
        {
            OpenSettings.Image = Resources.Settings1;
        }
        private void OpenSettings_MouseMove(object sender, MouseEventArgs e)
        {
            OpenSettings.Image = Resources.Settings2;
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.ForeColor = Color.White;
            menusselecter = button.Text;
            for (int i = 0; i < banner.Controls.Count; i++)
            {
                if (banner.Controls[i] != button)
                {
                    if(banner.Controls[i].Text == "HEROES")
                    {
                        Guna.UI2.WinForms.Guna2Button c = banner.Controls[i] as Guna.UI2.WinForms.Guna2Button;
                        c.ForeColor = Color.Gray;
                    }
                    if (banner.Controls[i].Text == "LOG")
                    {
                        Guna.UI2.WinForms.Guna2Button c = banner.Controls[i] as Guna.UI2.WinForms.Guna2Button;
                        c.ForeColor = Color.Gray;
                    }
                }
            }
            switch(menusselecter)
            {
                case "HEROES":
                    player.Play();
                    banner.Image = Resources.M1;
                    frm.Heroes heroes = new frm.Heroes();
                    addUserControl(heroes);
                    break;
                case "LOG":
                    player.Play();
                    banner.Image = Resources.M2;
                    frm.Log log = new frm.Log();
                    addUserControl(log);
                    break;
            }
        }
        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            if (menusselecter != button.Text)
            {
                button.ForeColor = Color.Gray;
            }
        }
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.ForeColor = Color.White;
        }
        private void CloseBox_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Application.Exit();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            modCommon._hotkeyBinder.Unbind(Modifiers.Alt, Keys.Home);
        }
        private void MiniBox_Click(object sender, EventArgs e)
        {
            home = true;
            notifyIcon1.Visible = true;
            this.Hide();
        }
    }
}
