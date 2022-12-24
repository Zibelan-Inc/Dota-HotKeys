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
    public partial class Settings1 : UserControl
    {
        public static Settings1 settings1;
        bool pressalt = false;

        public Settings1()
        {
            InitializeComponent();
        }

        private void Settings1_Load(object sender, EventArgs e)
        {
            settings1 = this;
            modCommon.Ready = true;
            modCommon.uc = false;
            if (File.Exists(modCommon.Name_File))
            {
                modCommon.Deserializar();
                Keys1.Text = modCommon.confi.Keys1;
                Keys2.Text = modCommon.confi.Keys2;
                Keys3.Text = modCommon.confi.Keys3;
                Keys4.Text = modCommon.confi.Keys4;
                Keys5.Text = modCommon.confi.Keys5;
                Keys6.Text = modCommon.confi.Keys6;
                Keys7.Text = modCommon.confi.Keys7;
                Keys8.Text = modCommon.confi.Keys8;
                Keys9.Text = modCommon.confi.Keys9;
                Keys10.Text = modCommon.confi.Keys10;
                Keys11.Text = modCommon.confi.Keys11;
                Keys12.Text = modCommon.confi.Keys12;
                Keys13.Text = modCommon.confi.Keys13;
                Keys14.Text = modCommon.confi.Keys14;
                Keys15.Text = modCommon.confi.Keys15;
                Keys16.Text = modCommon.confi.Keys16;
                Keys17.Text = modCommon.confi.Keys17;
                Keys18.Text = modCommon.confi.Keys18;
                Keys19.Text = modCommon.confi.Keys19;
                Keys20.Text = modCommon.confi.Keys20;
                Keys21.Text = modCommon.confi.Keys21;
                Keys22.Text = modCommon.confi.Keys22;
                Keys23.Text = modCommon.confi.Keys23;
                Keys24.Text = modCommon.confi.Keys24;
                Keys25.Text = modCommon.confi.Keys25;
            }
            else
            {
                modCommon.confi.Keys1 = Keys1.Text;
                modCommon.confi.Keys2 = Keys2.Text;
                modCommon.confi.Keys3 = Keys3.Text;
                modCommon.confi.Keys4 = Keys4.Text;
                modCommon.confi.Keys5 = Keys5.Text;
                modCommon.confi.Keys6 = Keys6.Text;
                modCommon.confi.Keys7 = Keys7.Text;
                modCommon.confi.Keys8 = Keys8.Text;
                modCommon.confi.Keys9 = Keys9.Text;
                modCommon.confi.Keys10 = Keys10.Text;
                modCommon.confi.Keys11 = Keys11.Text;
                modCommon.confi.Keys12 = Keys12.Text;
                modCommon.confi.Keys13 = Keys13.Text;
                modCommon.confi.Keys14 = Keys14.Text;
                modCommon.confi.Keys15 = Keys15.Text;
                modCommon.confi.Keys16 = Keys16.Text;
                modCommon.confi.Keys17 = Keys17.Text;
                modCommon.confi.Keys18 = Keys18.Text;
                modCommon.confi.Keys19 = Keys19.Text;
                modCommon.confi.Keys20 = Keys20.Text;
                modCommon.confi.Keys21 = Keys21.Text;
                modCommon.confi.Keys22 = Keys22.Text;
                modCommon.confi.Keys23 = Keys23.Text;
                modCommon.confi.Keys24 = Keys24.Text;
                modCommon.confi.Keys25 = Keys25.Text;
                modCommon.Serializar();
            }
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            //e.Graphics.Clear(SystemColors.Control);
            //e.Graphics.DrawString(box.Text, box.Font, Brushes.Black ,0,0);
            DrawGroupBox(box, e.Graphics, Color.Red, Color.FromArgb(5, 5, 5));
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
        private void Abilities_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.FillColor = Color.FromArgb(100, 88, 255);
            pressalt = false;
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
                        if (button.Name == "Keys1")
                        {
                            modCommon.confi.Keys1 = Keys1.Text;
                        }
                        else if (button.Name == "Keys2")
                        {
                            modCommon.confi.Keys2 = Keys2.Text;
                        }
                        else if (button.Name == "Keys3")
                        {
                            modCommon.confi.Keys3 = Keys3.Text;
                        }
                        else if (button.Name == "Keys4")
                        {
                            modCommon.confi.Keys4 = Keys4.Text;
                        }
                        else if (button.Name == "Keys5")
                        {
                            modCommon.confi.Keys5 = Keys5.Text;
                        }
                        else if (button.Name == "Keys6")
                        {
                            modCommon.confi.Keys6 = Keys6.Text;
                        }
                        else if (button.Name == "Keys7")
                        {
                            modCommon.confi.Keys7 = Keys7.Text;
                        }
                        else if (button.Name == "Keys8")
                        {
                            modCommon.confi.Keys8 = Keys8.Text;
                        }
                        else if (button.Name == "Keys9")
                        {
                            modCommon.confi.Keys9 = Keys9.Text;
                        }
                        else if (button.Name == "Keys10")
                        {
                            modCommon.confi.Keys10 = Keys10.Text;
                        }
                        else if (button.Name == "Keys11")
                        {
                            modCommon.confi.Keys11 = Keys11.Text;
                        }
                        else if (button.Name == "Keys12")
                        {
                            modCommon.confi.Keys12 = Keys12.Text;
                        }
                        else if (button.Name == "Keys13")
                        {
                            modCommon.confi.Keys13 = Keys13.Text;
                        }
                        else if (button.Name == "Keys14")
                        {
                            modCommon.confi.Keys14 = Keys14.Text;
                        }
                        else if (button.Name == "Keys15")
                        {
                            modCommon.confi.Keys15 = Keys15.Text;
                        }
                        else if (button.Name == "Keys16")
                        {
                            modCommon.confi.Keys16 = Keys16.Text;
                        }
                        else if (button.Name == "Keys17")
                        {
                            modCommon.confi.Keys17 = Keys17.Text;
                        }
                        else if (button.Name == "Keys18")
                        {
                            modCommon.confi.Keys18 = Keys18.Text;
                        }
                        else if (button.Name == "Keys19")
                        {
                            modCommon.confi.Keys19 = Keys19.Text;
                        }
                        else if (button.Name == "Keys20")
                        {
                            modCommon.confi.Keys20 = Keys20.Text;
                        }
                        else if (button.Name == "Keys21")
                        {
                            modCommon.confi.Keys21 = Keys21.Text;
                        }
                        else if (button.Name == "Keys22")
                        {
                            modCommon.confi.Keys22 = Keys22.Text;
                        }
                        else if (button.Name == "Keys23")
                        {
                            modCommon.confi.Keys23 = Keys23.Text;
                        }
                        else if (button.Name == "Keys24")
                        {
                            modCommon.confi.Keys24 = Keys24.Text;
                        }
                        else if (button.Name == "Keys25")
                        {
                            modCommon.confi.Keys25 = Keys25.Text;
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
                        if (button.Name == "Keys1")
                        {
                            modCommon.confi.Keys1 = Keys1.Text;
                        }
                        else if (button.Name == "Keys2")
                        {
                            modCommon.confi.Keys2 = Keys2.Text;
                        }
                        else if (button.Name == "Keys3")
                        {
                            modCommon.confi.Keys3 = Keys3.Text;
                        }
                        else if (button.Name == "Keys4")
                        {
                            modCommon.confi.Keys4 = Keys4.Text;
                        }
                        else if (button.Name == "Keys5")
                        {
                            modCommon.confi.Keys5 = Keys5.Text;
                        }
                        else if (button.Name == "Keys6")
                        {
                            modCommon.confi.Keys6 = Keys6.Text;
                        }
                        else if (button.Name == "Keys7")
                        {
                            modCommon.confi.Keys7 = Keys7.Text;
                        }
                        else if (button.Name == "Keys8")
                        {
                            modCommon.confi.Keys8 = Keys8.Text;
                        }
                        else if (button.Name == "Keys9")
                        {
                            modCommon.confi.Keys9 = Keys9.Text;
                        }
                        else if (button.Name == "Keys10")
                        {
                            modCommon.confi.Keys10 = Keys10.Text;
                        }
                        else if (button.Name == "Keys11")
                        {
                            modCommon.confi.Keys11 = Keys11.Text;
                        }
                        else if (button.Name == "Keys12")
                        {
                            modCommon.confi.Keys12 = Keys12.Text;
                        }
                        else if (button.Name == "Keys13")
                        {
                            modCommon.confi.Keys13 = Keys13.Text;
                        }
                        else if (button.Name == "Keys14")
                        {
                            modCommon.confi.Keys14 = Keys14.Text;
                        }
                        else if (button.Name == "Keys15")
                        {
                            modCommon.confi.Keys15 = Keys15.Text;
                        }
                        else if (button.Name == "Keys16")
                        {
                            modCommon.confi.Keys16 = Keys16.Text;
                        }
                        else if (button.Name == "Keys17")
                        {
                            modCommon.confi.Keys17 = Keys17.Text;
                        }
                        else if (button.Name == "Keys18")
                        {
                            modCommon.confi.Keys18 = Keys18.Text;
                        }
                        else if (button.Name == "Keys19")
                        {
                            modCommon.confi.Keys19 = Keys19.Text;
                        }
                        else if (button.Name == "Keys20")
                        {
                            modCommon.confi.Keys20 = Keys20.Text;
                        }
                        else if (button.Name == "Keys21")
                        {
                            modCommon.confi.Keys21 = Keys21.Text;
                        }
                        else if (button.Name == "Keys22")
                        {
                            modCommon.confi.Keys22 = Keys22.Text;
                        }
                        else if (button.Name == "Keys23")
                        {
                            modCommon.confi.Keys23 = Keys23.Text;
                        }
                        else if (button.Name == "Keys24")
                        {
                            modCommon.confi.Keys24 = Keys24.Text;
                        }
                        else if (button.Name == "Keys25")
                        {
                            modCommon.confi.Keys25 = Keys25.Text;
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
                if(pressalt != true)
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
                            button.Text = "0";
                        }
                        if (temp == "D0")
                        {
                            button.Text = "0";
                        }
                        else if (temp == "NumPad1")
                        {
                            button.Text = "1";
                        }
                        else if (temp == "D1")
                        {
                            button.Text = "1";
                        }
                        else if (temp == "NumPad2")
                        {
                            button.Text = "2";
                        }
                        else if (temp == "D2")
                        {
                            button.Text = "2";
                        }
                        else if (temp == "NumPad3")
                        {
                            button.Text = "3";
                        }
                        else if (temp == "D3")
                        {
                            button.Text = "3";
                        }
                        else if (temp == "NumPad4")
                        {
                            button.Text = "4";
                        }
                        else if (temp == "D4")
                        {
                            button.Text = "4";
                        }
                        else if (temp == "NumPad5")
                        {
                            button.Text = "5";
                        }
                        else if (temp == "D5")
                        {
                            button.Text = "5";
                        }
                        else if (temp == "NumPad6")
                        {
                            button.Text = "6";
                        }
                        else if (temp == "D6")
                        {
                            button.Text = "6";
                        }
                        else if (temp == "NumPad7")
                        {
                            button.Text = "7";
                        }
                        else if (temp == "D7")
                        {
                            button.Text = "7";
                        }
                        else if (temp == "NumPad8")
                        {
                            button.Text = "8";
                        }
                        else if (temp == "D8")
                        {
                            button.Text = "8";
                        }
                        else if (temp == "NumPad9")
                        {
                            button.Text = "9";
                        }
                        else if (temp == "D9")
                        {
                            button.Text = "9";
                        }
                        else if (temp == "Tab")
                        {
                            button.Text = "TAB";
                        }
                        else
                        {
                            button.Text = temp;
                            modCommon.existkeys = false;
                        }
                        button.FillColor = Color.FromArgb(44, 48, 49);
                        pressalt = false;
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
                if (button.Name == "Keys1")
                {
                    modCommon.confi.Keys1 = Keys1.Text;
                }
                else if (button.Name == "Keys2")
                {
                    modCommon.confi.Keys2 = Keys2.Text;
                }
                else if (button.Name == "Keys3")
                {
                    modCommon.confi.Keys3 = Keys3.Text;
                }
                else if (button.Name == "Keys4")
                {
                    modCommon.confi.Keys4 = Keys4.Text;
                }
                else if (button.Name == "Keys5")
                {
                    modCommon.confi.Keys5 = Keys5.Text;
                }
                else if (button.Name == "Keys6")
                {
                    modCommon.confi.Keys6 = Keys6.Text;
                }
                else if (button.Name == "Keys7")
                {
                    modCommon.confi.Keys7 = Keys7.Text;
                }
                else if (button.Name == "Keys8")
                {
                    modCommon.confi.Keys8 = Keys8.Text;
                }
                else if (button.Name == "Keys9")
                {
                    modCommon.confi.Keys9 = Keys9.Text;
                }
                else if (button.Name == "Keys10")
                {
                    modCommon.confi.Keys10 = Keys10.Text;
                }
                else if (button.Name == "Keys11")
                {
                    modCommon.confi.Keys11 = Keys11.Text;
                }
                else if (button.Name == "Keys12")
                {
                    modCommon.confi.Keys12 = Keys12.Text;
                }
                else if (button.Name == "Keys13")
                {
                    modCommon.confi.Keys13 = Keys13.Text;
                }
                else if (button.Name == "Keys14")
                {
                    modCommon.confi.Keys14 = Keys14.Text;
                }
                else if (button.Name == "Keys15")
                {
                    modCommon.confi.Keys15 = Keys15.Text;
                }
                else if (button.Name == "Keys16")
                {
                    modCommon.confi.Keys16 = Keys16.Text;
                }
                else if (button.Name == "Keys17")
                {
                    modCommon.confi.Keys17 = Keys17.Text;
                }
                else if (button.Name == "Keys18")
                {
                    modCommon.confi.Keys18 = Keys18.Text;
                }
                else if (button.Name == "Keys19")
                {
                    modCommon.confi.Keys19 = Keys19.Text;
                }
                else if (button.Name == "Keys20")
                {
                    modCommon.confi.Keys20 = Keys20.Text;
                }
                else if (button.Name == "Keys21")
                {
                    modCommon.confi.Keys21 = Keys21.Text;
                }
                else if (button.Name == "Keys22")
                {
                    modCommon.confi.Keys22 = Keys22.Text;
                }
                else if (button.Name == "Keys23")
                {
                    modCommon.confi.Keys23 = Keys23.Text;
                }
                else if (button.Name == "Keys24")
                {
                    modCommon.confi.Keys24 = Keys24.Text;
                }
                else if (button.Name == "Keys25")
                {
                    modCommon.confi.Keys25 = Keys25.Text;
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
