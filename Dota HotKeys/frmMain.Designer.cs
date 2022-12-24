
namespace Dota_HotKeys
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonLog = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHeroes = new Guna.UI2.WinForms.Guna2Button();
            this.OpenSettings = new System.Windows.Forms.PictureBox();
            this.MiniBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CloseBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.banner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Transparent;
            this.PanelTop.Controls.Add(this.buttonLog);
            this.PanelTop.Controls.Add(this.buttonHeroes);
            this.PanelTop.Controls.Add(this.OpenSettings);
            this.PanelTop.Controls.Add(this.MiniBox);
            this.PanelTop.Controls.Add(this.CloseBox);
            this.PanelTop.Controls.Add(this.banner);
            this.Transition.SetDecoration(this.PanelTop, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.ShadowDecoration.Parent = this.PanelTop;
            this.PanelTop.Size = new System.Drawing.Size(1044, 53);
            this.PanelTop.TabIndex = 1;
            // 
            // buttonLog
            // 
            this.buttonLog.CheckedState.Parent = this.buttonLog;
            this.buttonLog.CustomImages.Parent = this.buttonLog;
            this.Transition.SetDecoration(this.buttonLog, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonLog.FillColor = System.Drawing.Color.Transparent;
            this.buttonLog.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonLog.ForeColor = System.Drawing.Color.Gray;
            this.buttonLog.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonLog.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonLog.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.buttonLog.HoverState.Parent = this.buttonLog;
            this.buttonLog.Location = new System.Drawing.Point(310, 0);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.PressedColor = System.Drawing.Color.Transparent;
            this.buttonLog.PressedDepth = 0;
            this.buttonLog.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.buttonLog.ShadowDecoration.Parent = this.buttonLog;
            this.buttonLog.Size = new System.Drawing.Size(94, 45);
            this.buttonLog.TabIndex = 56;
            this.buttonLog.Text = "LOG";
            this.buttonLog.TextOffset = new System.Drawing.Point(-7, -1);
            this.buttonLog.Click += new System.EventHandler(this.Menu_Click);
            this.buttonLog.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.buttonLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            // 
            // buttonHeroes
            // 
            this.buttonHeroes.CheckedState.Parent = this.buttonHeroes;
            this.buttonHeroes.CustomImages.Parent = this.buttonHeroes;
            this.Transition.SetDecoration(this.buttonHeroes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.buttonHeroes.FillColor = System.Drawing.Color.Transparent;
            this.buttonHeroes.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonHeroes.ForeColor = System.Drawing.Color.Gray;
            this.buttonHeroes.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonHeroes.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonHeroes.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.buttonHeroes.HoverState.Parent = this.buttonHeroes;
            this.buttonHeroes.Location = new System.Drawing.Point(216, 0);
            this.buttonHeroes.Name = "buttonHeroes";
            this.buttonHeroes.PressedColor = System.Drawing.Color.Transparent;
            this.buttonHeroes.PressedDepth = 0;
            this.buttonHeroes.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.buttonHeroes.ShadowDecoration.Parent = this.buttonHeroes;
            this.buttonHeroes.Size = new System.Drawing.Size(94, 45);
            this.buttonHeroes.TabIndex = 4;
            this.buttonHeroes.Text = "HEROES";
            this.buttonHeroes.TextOffset = new System.Drawing.Point(0, -1);
            this.buttonHeroes.Click += new System.EventHandler(this.Menu_Click);
            this.buttonHeroes.MouseLeave += new System.EventHandler(this.Menu_MouseLeave);
            this.buttonHeroes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            // 
            // OpenSettings
            // 
            this.OpenSettings.BackColor = System.Drawing.Color.Transparent;
            this.OpenSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Transition.SetDecoration(this.OpenSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OpenSettings.Image = global::Dota_HotKeys.Properties.Resources.Settings1;
            this.OpenSettings.Location = new System.Drawing.Point(12, 7);
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(26, 26);
            this.OpenSettings.TabIndex = 55;
            this.OpenSettings.TabStop = false;
            this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
            this.OpenSettings.MouseLeave += new System.EventHandler(this.OpenSettings_MouseLeave);
            this.OpenSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OpenSettings_MouseMove);
            // 
            // MiniBox
            // 
            this.MiniBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MiniBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Transition.SetDecoration(this.MiniBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MiniBox.FillColor = System.Drawing.Color.Transparent;
            this.MiniBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MiniBox.HoverState.Parent = this.MiniBox;
            this.MiniBox.IconColor = System.Drawing.Color.White;
            this.MiniBox.Location = new System.Drawing.Point(953, 0);
            this.MiniBox.Name = "MiniBox";
            this.MiniBox.ShadowDecoration.Parent = this.MiniBox;
            this.MiniBox.Size = new System.Drawing.Size(45, 40);
            this.MiniBox.TabIndex = 7;
            this.MiniBox.Click += new System.EventHandler(this.MiniBox_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Transition.SetDecoration(this.CloseBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CloseBox.FillColor = System.Drawing.Color.Transparent;
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CloseBox.HoverState.Parent = this.CloseBox;
            this.CloseBox.IconColor = System.Drawing.Color.White;
            this.CloseBox.Location = new System.Drawing.Point(998, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.ShadowDecoration.Parent = this.CloseBox;
            this.CloseBox.Size = new System.Drawing.Size(45, 40);
            this.CloseBox.TabIndex = 6;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.banner, Guna.UI2.AnimatorNS.DecorationType.None);
            this.banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banner.Image = global::Dota_HotKeys.Properties.Resources.Banner;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.ShadowDecoration.Parent = this.banner;
            this.banner.Size = new System.Drawing.Size(1044, 53);
            this.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 23;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.banner;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.Transition.SetDecoration(this.PanelContainer, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 53);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1044, 547);
            this.PanelContainer.TabIndex = 2;
            // 
            // Transition
            // 
            this.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dota HotKeys";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1044, 600);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelTop);
            this.Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelTop;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox MiniBox;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBox;
        private Guna.UI2.WinForms.Guna2PictureBox banner;
        private System.Windows.Forms.PictureBox OpenSettings;
        public Guna.UI2.WinForms.Guna2Transition Transition;
        private Guna.UI2.WinForms.Guna2Button buttonHeroes;
        private Guna.UI2.WinForms.Guna2Button buttonLog;
        public Guna.UI2.WinForms.Guna2Panel PanelContainer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

