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

namespace Dota_HotKeys.frm
{
    public partial class Settings2 : UserControl
    {
        public static Settings2 settings2;
        bool pressalt = false;

        public Settings2()
        {
            InitializeComponent();
        }

        private void Settings2_Load(object sender, EventArgs e)
        {
            settings2 = this;
            modCommon.Ready = true;
            modCommon.uc = true;
            if (File.Exists(modCommon.Name_File))
            {
                modCommon.Deserializar();
                Keys26.Text = modCommon.confi.Keys26;
                Keys27.Text = modCommon.confi.Keys27;
                Keys28.Text = modCommon.confi.Keys28;
                Keys29.Text = modCommon.confi.Keys29;
                Keys30.Text = modCommon.confi.Keys30;
                Keys31.Text = modCommon.confi.Keys31;
                Keys32.Text = modCommon.confi.Keys32;
                Keys33.Text = modCommon.confi.Keys33;
                Keys34.Text = modCommon.confi.Keys34;
                Keys35.Text = modCommon.confi.Keys35;
                Keys36.Text = modCommon.confi.Keys36;
                Keys37.Text = modCommon.confi.Keys37;
                Keys38.Text = modCommon.confi.Keys38;
                Keys39.Text = modCommon.confi.Keys39;
                Keys40.Text = modCommon.confi.Keys40;
                Keys41.Text = modCommon.confi.Keys41;
            }
            else
            {
                modCommon.confi.Keys26 = Keys26.Text;
                modCommon.confi.Keys27 = Keys27.Text;
                modCommon.confi.Keys28 = Keys28.Text;
                modCommon.confi.Keys29 = Keys29.Text;
                modCommon.confi.Keys30 = Keys30.Text;
                modCommon.confi.Keys31 = Keys31.Text;
                modCommon.confi.Keys32 = Keys32.Text;
                modCommon.confi.Keys33 = Keys33.Text;
                modCommon.confi.Keys34 = Keys34.Text;
                modCommon.confi.Keys35 = Keys35.Text;
                modCommon.confi.Keys36 = Keys36.Text;
                modCommon.confi.Keys37 = Keys37.Text;
                modCommon.confi.Keys38 = Keys38.Text;
                modCommon.confi.Keys39 = Keys39.Text;
                modCommon.confi.Keys40 = Keys40.Text;
                modCommon.confi.Keys41 = Keys41.Text;
                modCommon.Serializar();
            }
        }
        private void Abilities_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.FillColor = Color.FromArgb(100, 88, 255);
        }
        private void Key_MouseClick(object sender, MouseEventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            string temp = Convert.ToString(e.Button);
            if (temp != "Left")
            {
                if (temp != "Right")
                {
                    if (temp == "Middle")
                    {
                        temp = "MOUSE3";
                    }
                    if (temp == "XButton1")
                    {
                        temp = "MOUSE4";
                    }
                    if (temp == "XButton2")
                    {
                        temp = "MOUSE5";
                    }
                    if (temp == "XButton3")
                    {
                        temp = "MOUSE6";
                    }
                    if (temp == "XButton4")
                    {
                        temp = "MOUSE7";
                    }
                    if (temp == "XButton5")
                    {
                        temp = "MOUSE8";
                    }
                    if (temp == "XButton6")
                    {
                        temp = "MOUSE9";
                    }
                    if (temp == "ControlKey")
                    {
                        return;
                    }
                    if (button.Text != temp)
                    {
                        VerKeys(temp);
                        if (modCommon.existkeys != true)
                        {
                            button.Text = temp;
                            button.FillColor = Color.FromArgb(44, 48, 49);
                        }
                        else
                        {
                            button.FillColor = Color.FromArgb(255, 48, 49);
                            modCommon.existkeys = false;
                        }
                        if (button.Name == "Keys26")
                        {
                            modCommon.confi.Keys26 = Keys26.Text;
                        }
                        else if (button.Name == "Keys27")
                        {
                            modCommon.confi.Keys27 = Keys27.Text;
                        }
                        else if (button.Name == "Keys28")
                        {
                            modCommon.confi.Keys28 = Keys28.Text;
                        }
                        else if (button.Name == "Keys29")
                        {
                            modCommon.confi.Keys29 = Keys29.Text;
                        }
                        else if (button.Name == "Keys30")
                        {
                            modCommon.confi.Keys30 = Keys30.Text;
                        }
                        else if (button.Name == "Keys31")
                        {
                            modCommon.confi.Keys31 = Keys31.Text;
                        }
                        else if (button.Name == "Keys32")
                        {
                            modCommon.confi.Keys32 = Keys32.Text;
                        }
                        else if (button.Name == "Keys33")
                        {
                            modCommon.confi.Keys33 = Keys33.Text;
                        }
                        else if (button.Name == "Keys34")
                        {
                            modCommon.confi.Keys34 = Keys34.Text;
                        }
                        else if (button.Name == "Keys35")
                        {
                            modCommon.confi.Keys35 = Keys35.Text;
                        }
                        else if (button.Name == "Keys36")
                        {
                            modCommon.confi.Keys36 = Keys36.Text;
                        }
                        else if (button.Name == "Keys37")
                        {
                            modCommon.confi.Keys37 = Keys37.Text;
                        }
                        else if (button.Name == "Keys38")
                        {
                            modCommon.confi.Keys38 = Keys38.Text;
                        }
                        else if (button.Name == "Keys39")
                        {
                            modCommon.confi.Keys39 = Keys39.Text;
                        }
                        else if (button.Name == "Keys40")
                        {
                            modCommon.confi.Keys40 = Keys40.Text;
                        }
                        else if (button.Name == "Keys41")
                        {
                            modCommon.confi.Keys41 = Keys41.Text;
                        }
                    }
                }
            }
            else if (temp != "Right")
            {
                if (temp != "Left")
                {
                    if (temp == "Middle")
                    {
                        temp = "MOUSE3";
                    }
                    if (temp == "XButton1")
                    {
                        temp = "MOUSE4";
                    }
                    if (temp == "XButton2")
                    {
                        temp = "MOUSE5";
                    }
                    if (temp == "XButton3")
                    {
                        temp = "MOUSE6";
                    }
                    if (temp == "XButton4")
                    {
                        temp = "MOUSE7";
                    }
                    if (temp == "XButton5")
                    {
                        temp = "MOUSE8";
                    }
                    if (temp == "XButton6")
                    {
                        temp = "MOUSE9";
                    }
                    if (temp == "ControlKey")
                    {
                        return;
                    }
                    if (button.Text != temp)
                    {
                        VerKeys(temp);
                        if (modCommon.existkeys != true)
                        {
                            button.Text = temp;
                            button.FillColor = Color.FromArgb(44, 48, 49);
                        }
                        else
                        {
                            button.FillColor = Color.FromArgb(255, 48, 49);
                            modCommon.existkeys = false;
                        }
                        if (button.Name == "Keys26")
                        {
                            modCommon.confi.Keys26 = Keys26.Text;
                        }
                        else if (button.Name == "Keys27")
                        {
                            modCommon.confi.Keys27 = Keys27.Text;
                        }
                        else if (button.Name == "Keys28")
                        {
                            modCommon.confi.Keys28 = Keys28.Text;
                        }
                        else if (button.Name == "Keys29")
                        {
                            modCommon.confi.Keys29 = Keys29.Text;
                        }
                        else if (button.Name == "Keys30")
                        {
                            modCommon.confi.Keys30 = Keys30.Text;
                        }
                        else if (button.Name == "Keys31")
                        {
                            modCommon.confi.Keys31 = Keys31.Text;
                        }
                        else if (button.Name == "Keys32")
                        {
                            modCommon.confi.Keys32 = Keys32.Text;
                        }
                        else if (button.Name == "Keys33")
                        {
                            modCommon.confi.Keys33 = Keys33.Text;
                        }
                        else if (button.Name == "Keys34")
                        {
                            modCommon.confi.Keys34 = Keys34.Text;
                        }
                        else if (button.Name == "Keys35")
                        {
                            modCommon.confi.Keys35 = Keys35.Text;
                        }
                        else if (button.Name == "Keys36")
                        {
                            modCommon.confi.Keys36 = Keys36.Text;
                        }
                        else if (button.Name == "Keys37")
                        {
                            modCommon.confi.Keys37 = Keys37.Text;
                        }
                        else if (button.Name == "Keys38")
                        {
                            modCommon.confi.Keys38 = Keys38.Text;
                        }
                        else if (button.Name == "Keys39")
                        {
                            modCommon.confi.Keys39 = Keys39.Text;
                        }
                        else if (button.Name == "Keys40")
                        {
                            modCommon.confi.Keys40 = Keys40.Text;
                        }
                        else if (button.Name == "Keys41")
                        {
                            modCommon.confi.Keys41 = Keys41.Text;
                        }
                    }
                }
            }
        }
        private void Key_MouseLeave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.FillColor = Color.FromArgb(44, 48, 49);
            return;
        }
        private void Key_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            string temp = Convert.ToString(e.KeyCode);
            if (button.Text != temp)
            {
                if (pressalt != true)
                {
                    if (temp == "Menu")
                    {
                        pressalt = true;
                        return;
                    }
                    if (temp == "ControlKey")
                    {
                        return;
                    }
                    VerKeys(temp);
                    if (modCommon.existkeys != true)
                    {
                        if (temp == "NumPad0")
                        {
                            temp = "0";
                        }
                        if (temp == "D0")
                        {
                            temp = "0";
                        }
                        if (temp == "NumPad1")
                        {
                            temp = "1";
                        }
                        if (temp == "D1")
                        {
                            temp = "1";
                        }
                        if (temp == "NumPad2")
                        {
                            temp = "2";
                        }
                        if (temp == "D2")
                        {
                            temp = "2";
                        }
                        if (temp == "NumPad3")
                        {
                            temp = "3";
                        }
                        if (temp == "D3")
                        {
                            temp = "3";
                        }
                        if (temp == "NumPad4")
                        {
                            temp = "4";
                        }
                        if (temp == "D4")
                        {
                            temp = "4";
                        }
                        if (temp == "NumPad5")
                        {
                            temp = "5";
                        }
                        if (temp == "D5")
                        {
                            temp = "5";
                        }
                        if (temp == "NumPad6")
                        {
                            temp = "6";
                        }
                        if (temp == "D6")
                        {
                            temp = "6";
                        }
                        if (temp == "NumPad7")
                        {
                            temp = "7";
                        }
                        if (temp == "D7")
                        {
                            temp = "7";
                        }
                        if (temp == "NumPad8")
                        {
                            temp = "8";
                        }
                        if (temp == "D8")
                        {
                            temp = "8";
                        }
                        if (temp == "NumPad9")
                        {
                            temp = "9";
                        }
                        if (temp == "D9")
                        {
                            temp = "9";
                        }
                        else if (temp == "Tab")
                        {
                            button.Text = "TAB";
                        }
                        else
                        {
                            button.Text = temp;
                        }
                        button.FillColor = Color.FromArgb(44, 48, 49);
                    }
                    else
                    {
                        button.FillColor = Color.FromArgb(255, 48, 49);
                        modCommon.existkeys = false;
                    }
                }
                else
                {
                    string temp2 = "Alt+" + temp;
                    VerKeys(temp2);
                    if (modCommon.existkeys != true)
                    {
                        button.Text = temp2;
                        button.FillColor = Color.FromArgb(44, 48, 49);
                    }
                    else
                    {
                        button.FillColor = Color.FromArgb(255, 48, 49);
                        modCommon.existkeys = false;
                    }
                    pressalt = false;
                }
                if (button.Name == "Keys26")
                {
                    modCommon.confi.Keys26 = Keys26.Text;
                }
                else if (button.Name == "Keys27")
                {
                    modCommon.confi.Keys27 = Keys27.Text;
                }
                else if (button.Name == "Keys28")
                {
                    modCommon.confi.Keys28 = Keys28.Text;
                }
                else if (button.Name == "Keys29")
                {
                    modCommon.confi.Keys29 = Keys29.Text;
                }
                else if (button.Name == "Keys30")
                {
                    modCommon.confi.Keys30 = Keys30.Text;
                }
                else if (button.Name == "Keys31")
                {
                    modCommon.confi.Keys31 = Keys31.Text;
                }
                else if (button.Name == "Keys32")
                {
                    modCommon.confi.Keys32 = Keys32.Text;
                }
                else if (button.Name == "Keys33")
                {
                    modCommon.confi.Keys33 = Keys33.Text;
                }
                else if (button.Name == "Keys34")
                {
                    modCommon.confi.Keys34 = Keys34.Text;
                }
                else if (button.Name == "Keys35")
                {
                    modCommon.confi.Keys35 = Keys35.Text;
                }
                else if (button.Name == "Keys36")
                {
                    modCommon.confi.Keys36 = Keys36.Text;
                }
                else if (button.Name == "Keys37")
                {
                    modCommon.confi.Keys37 = Keys37.Text;
                }
                else if (button.Name == "Keys38")
                {
                    modCommon.confi.Keys38 = Keys38.Text;
                }
                else if (button.Name == "Keys39")
                {
                    modCommon.confi.Keys39 = Keys39.Text;
                }
                else if (button.Name == "Keys40")
                {
                    modCommon.confi.Keys40 = Keys40.Text;
                }
                else if (button.Name == "Keys41")
                {
                    modCommon.confi.Keys41 = Keys41.Text;
                }
            }
            else
            {
                button.FillColor = Color.FromArgb(44, 48, 49);
            }
        }
        private void VerKeys(string keys)
        {
            if (keys == modCommon.confi.Keys1)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys2)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys3)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys4)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys5)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys6)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys7)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys8)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys9)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys10)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys11)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys12)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys13)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys14)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys15)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys16)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys17)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys18)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys19)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys20)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys21)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys22)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys23)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys24)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys25)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys26)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys27)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys28)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys29)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys30)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys31)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys32)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys33)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys34)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys35)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys36)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys37)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys38)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys39)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys40)
            {
                modCommon.existkeys = true;
            }
            else if (keys == modCommon.confi.Keys41)
            {
                modCommon.existkeys = true;
            }
            else
            {
                modCommon.existkeys = false;
            }
        }
    }
}
