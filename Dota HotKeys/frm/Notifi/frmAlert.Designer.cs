namespace Dota_HotKeys
{
    partial class frmAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.GunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.timerRoshan = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Image = global::Dota_HotKeys.Properties.Resources.icon_roshan;
            this.GunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GunaPictureBox1.TabIndex = 10;
            this.GunaPictureBox1.TabStop = false;
            // 
            // GunaLabel1
            // 
            this.GunaLabel1.AutoSize = true;
            this.GunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GunaLabel1.ForeColor = System.Drawing.Color.White;
            this.GunaLabel1.Location = new System.Drawing.Point(76, 23);
            this.GunaLabel1.Name = "GunaLabel1";
            this.GunaLabel1.Size = new System.Drawing.Size(49, 21);
            this.GunaLabel1.TabIndex = 11;
            this.GunaLabel1.Text = "00:00";
            // 
            // timerRoshan
            // 
            this.timerRoshan.Interval = 1000;
            this.timerRoshan.Tick += new System.EventHandler(this.timerRoshan_Tick);
            // 
            // frmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(132, 70);
            this.Controls.Add(this.GunaLabel1);
            this.Controls.Add(this.GunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmAlert";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Timer Timer1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
        internal Guna.UI.WinForms.GunaLabel GunaLabel1;
        internal System.Windows.Forms.Timer timerRoshan;
    }
}