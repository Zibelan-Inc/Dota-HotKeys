
namespace Dota_HotKeys
{
    partial class frmSettings
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
            UIDC.UI_LabelMaterial AdvancedHotkeys;
            UIDC.UI_LabelMaterial ResetHotkeys;
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.SETTINGS = new UIDC.UI_LabelMaterial();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Transition = new Guna.UI2.WinForms.Guna2Transition();
            AdvancedHotkeys = new UIDC.UI_LabelMaterial();
            ResetHotkeys = new UIDC.UI_LabelMaterial();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdvancedHotkeys
            // 
            AdvancedHotkeys.AutoSize = true;
            AdvancedHotkeys.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(AdvancedHotkeys, Guna.UI2.AnimatorNS.DecorationType.None);
            AdvancedHotkeys.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AdvancedHotkeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            AdvancedHotkeys.Location = new System.Drawing.Point(322, 13);
            AdvancedHotkeys.Name = "AdvancedHotkeys";
            AdvancedHotkeys.Size = new System.Drawing.Size(159, 13);
            AdvancedHotkeys.TabIndex = 48;
            AdvancedHotkeys.Text = "TO ADVANCED HOTKEYS";
            AdvancedHotkeys.Click += new System.EventHandler(this.AdvancedHotkeys_Click);
            AdvancedHotkeys.MouseLeave += new System.EventHandler(this.AdvancedHotkeys_MouseLeave);
            AdvancedHotkeys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdvancedHotkeys_MouseMove);
            // 
            // ResetHotkeys
            // 
            ResetHotkeys.AutoSize = true;
            ResetHotkeys.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(ResetHotkeys, Guna.UI2.AnimatorNS.DecorationType.None);
            ResetHotkeys.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ResetHotkeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            ResetHotkeys.Location = new System.Drawing.Point(12, 13);
            ResetHotkeys.Name = "ResetHotkeys";
            ResetHotkeys.Size = new System.Drawing.Size(95, 12);
            ResetHotkeys.TabIndex = 47;
            ResetHotkeys.Text = "RESET HOTKEYS...";
            ResetHotkeys.Click += new System.EventHandler(this.ResetHotkeys_Click);
            ResetHotkeys.MouseLeave += new System.EventHandler(this.ResetHotkeys_MouseLeave);
            ResetHotkeys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResetHotkeys_MouseMove);
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.PanelTop.Controls.Add(this.CloseBox);
            this.PanelTop.Controls.Add(this.SETTINGS);
            this.Transition.SetDecoration(this.PanelTop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.ShadowDecoration.Parent = this.PanelTop;
            this.PanelTop.Size = new System.Drawing.Size(775, 30);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.PanelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.CloseBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CloseBox.Image = global::Dota_HotKeys.Properties.Resources.SClose1;
            this.CloseBox.Location = new System.Drawing.Point(5, 1);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(22, 23);
            this.CloseBox.TabIndex = 56;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            this.CloseBox.MouseLeave += new System.EventHandler(this.CloseBox_MouseLeave);
            this.CloseBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CloseBox_MouseMove);
            // 
            // SETTINGS
            // 
            this.SETTINGS.AutoSize = true;
            this.SETTINGS.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.SETTINGS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SETTINGS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SETTINGS.ForeColor = System.Drawing.Color.Gainsboro;
            this.SETTINGS.Location = new System.Drawing.Point(37, 8);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Size = new System.Drawing.Size(71, 13);
            this.SETTINGS.TabIndex = 0;
            this.SETTINGS.Text = "SETTINGS";
            this.SETTINGS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Event_MouseDown);
            this.SETTINGS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Event_MouseMove);
            this.SETTINGS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Event_MouseUp);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(AdvancedHotkeys);
            this.guna2Panel1.Controls.Add(ResetHotkeys);
            this.Transition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 438);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(775, 43);
            this.guna2Panel1.TabIndex = 3;
            // 
            // PanelContainer
            // 
            this.Transition.SetDecoration(this.PanelContainer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 30);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(775, 408);
            this.PanelContainer.TabIndex = 4;
            // 
            // Transition
            // 
            this.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(775, 481);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.PanelTop);
            this.Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelTop;
        private UIDC.UI_LabelMaterial SETTINGS;
        private System.Windows.Forms.PictureBox CloseBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private Guna.UI2.WinForms.Guna2Transition Transition;
    }
}