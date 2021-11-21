namespace Krypted_Loader
{
    partial class LoadingForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.ExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.MinimizeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.NameLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.MLabelSub = new Bunifu.UI.WinForms.BunifuLabel();
            this.DataLab = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LoadingProgress1 = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Transparent;
            this.TopPanel.BorderColor = System.Drawing.Color.Transparent;
            this.TopPanel.BorderRadius = 1;
            this.TopPanel.BorderThickness = 1;
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.MinimizeButton);
            this.TopPanel.Controls.Add(this.NameLabel);
            this.TopPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.TopPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.TopPanel.Location = new System.Drawing.Point(-14, -2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.TopPanel.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.TopPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.TopPanel.ShadowDept = 2;
            this.TopPanel.ShadowDepth = 5;
            this.TopPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.TopPanel.ShadowTopLeftVisible = false;
            this.TopPanel.Size = new System.Drawing.Size(844, 40);
            this.TopPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.TopPanel.TabIndex = 6;
            // 
            // ExitButton
            // 
            this.ExitButton.AllowAnimations = true;
            this.ExitButton.AllowBorderColorChanges = true;
            this.ExitButton.AllowMouseEffects = true;
            this.ExitButton.AnimationSpeed = 200;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BorderColor = System.Drawing.Color.Transparent;
            this.ExitButton.BorderRadius = 1;
            this.ExitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.ExitButton.BorderThickness = 1;
            this.ExitButton.ColorContrastOnClick = 30;
            this.ExitButton.ColorContrastOnHover = 30;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ExitButton.CustomizableEdges = borderEdges1;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageMargin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Location = new System.Drawing.Point(779, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RoundBorders = false;
            this.ExitButton.ShowBorders = true;
            this.ExitButton.Size = new System.Drawing.Size(23, 23);
            this.ExitButton.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AllowAnimations = true;
            this.MinimizeButton.AllowBorderColorChanges = true;
            this.MinimizeButton.AllowMouseEffects = true;
            this.MinimizeButton.AnimationSpeed = 200;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BorderColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BorderRadius = 1;
            this.MinimizeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.MinimizeButton.BorderThickness = 1;
            this.MinimizeButton.ColorContrastOnClick = 30;
            this.MinimizeButton.ColorContrastOnHover = 30;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.MinimizeButton.CustomizableEdges = borderEdges2;
            this.MinimizeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageMargin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Location = new System.Drawing.Point(732, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.RoundBorders = false;
            this.MinimizeButton.ShowBorders = true;
            this.MinimizeButton.Size = new System.Drawing.Size(43, 43);
            this.MinimizeButton.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AllowParentOverrides = false;
            this.NameLabel.AutoEllipsis = false;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(26, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(70, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "ExLoader";
            this.NameLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NameLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MLabel
            // 
            this.MLabel.AllowParentOverrides = false;
            this.MLabel.AutoEllipsis = false;
            this.MLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.MLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLabel.ForeColor = System.Drawing.Color.White;
            this.MLabel.Location = new System.Drawing.Point(289, 211);
            this.MLabel.Name = "MLabel";
            this.MLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MLabel.Size = new System.Drawing.Size(191, 29);
            this.MLabel.TabIndex = 7;
            this.MLabel.Text = "Checking Files...";
            this.MLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.MLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MLabelSub
            // 
            this.MLabelSub.AllowParentOverrides = false;
            this.MLabelSub.AutoEllipsis = false;
            this.MLabelSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.MLabelSub.CursorType = System.Windows.Forms.Cursors.Default;
            this.MLabelSub.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLabelSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(91)))));
            this.MLabelSub.Location = new System.Drawing.Point(252, 248);
            this.MLabelSub.Name = "MLabelSub";
            this.MLabelSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MLabelSub.Size = new System.Drawing.Size(276, 16);
            this.MLabelSub.TabIndex = 8;
            this.MLabelSub.Text = "Checking Files So The Application Can Run";
            this.MLabelSub.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.MLabelSub.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DataLab
            // 
            this.DataLab.AllowParentOverrides = false;
            this.DataLab.AutoEllipsis = false;
            this.DataLab.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataLab.CursorType = System.Windows.Forms.Cursors.Default;
            this.DataLab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataLab.ForeColor = System.Drawing.Color.White;
            this.DataLab.Location = new System.Drawing.Point(304, 419);
            this.DataLab.Name = "DataLab";
            this.DataLab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataLab.Size = new System.Drawing.Size(165, 16);
            this.DataLab.TabIndex = 9;
            this.DataLab.Text = "Data Is Being Processed...\r\n";
            this.DataLab.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.DataLab.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(91)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(20, 419);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(110, 14);
            this.bunifuLabel4.TabIndex = 10;
            this.bunifuLabel4.Text = "Verison 0.0.1 Build 1\r\n";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LoadingProgress1
            // 
            this.LoadingProgress1.AllowAnimations = false;
            this.LoadingProgress1.Animation = 0;
            this.LoadingProgress1.AnimationSpeed = 100;
            this.LoadingProgress1.AnimationStep = 10;
            this.LoadingProgress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.LoadingProgress1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadingProgress1.BackgroundImage")));
            this.LoadingProgress1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.LoadingProgress1.BorderRadius = 9;
            this.LoadingProgress1.BorderThickness = 1;
            this.LoadingProgress1.Location = new System.Drawing.Point(-5, 439);
            this.LoadingProgress1.Maximum = 100;
            this.LoadingProgress1.MaximumValue = 100;
            this.LoadingProgress1.Minimum = 0;
            this.LoadingProgress1.MinimumValue = 0;
            this.LoadingProgress1.Name = "LoadingProgress1";
            this.LoadingProgress1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LoadingProgress1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.LoadingProgress1.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.LoadingProgress1.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.LoadingProgress1.Size = new System.Drawing.Size(58, 10);
            this.LoadingProgress1.TabIndex = 11;
            this.LoadingProgress1.Value = 0;
            this.LoadingProgress1.ValueByTransition = 0;
            this.LoadingProgress1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 30);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoadingProgress1);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.DataLab);
            this.Controls.Add(this.MLabelSub);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuShadowPanel TopPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton ExitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton MinimizeButton;
        private Bunifu.UI.WinForms.BunifuLabel NameLabel;
        private Bunifu.UI.WinForms.BunifuLabel MLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel DataLab;
        private Bunifu.UI.WinForms.BunifuLabel MLabelSub;
        private Bunifu.UI.WinForms.BunifuProgressBar LoadingProgress1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}