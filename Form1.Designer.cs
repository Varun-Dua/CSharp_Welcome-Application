namespace Assignment1
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.NameLabel = new System.Windows.Forms.Label();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.StudentIdBox = new System.Windows.Forms.TextBox();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.PicLabel = new System.Windows.Forms.Label();
            this.PinkButton = new System.Windows.Forms.RadioButton();
            this.RoyalBlueButton = new System.Windows.Forms.RadioButton();
            this.ChocolateButton = new System.Windows.Forms.RadioButton();
            this.GreenButton = new System.Windows.Forms.RadioButton();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PicToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.WelcomePanel.SuspendLayout();
            this.ColorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(43, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = true;
            this.StudentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdLabel.Location = new System.Drawing.Point(269, 55);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(125, 17);
            this.StudentIdLabel.TabIndex = 1;
            this.StudentIdLabel.Text = "Student Number";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(122, 50);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 2;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentIdBox
            // 
            this.StudentIdBox.Location = new System.Drawing.Point(441, 50);
            this.StudentIdBox.Name = "StudentIdBox";
            this.StudentIdBox.Size = new System.Drawing.Size(100, 22);
            this.StudentIdBox.TabIndex = 3;
            this.StudentIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(601, 35);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(114, 57);
            this.DisplayButton.TabIndex = 4;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearButton.Location = new System.Drawing.Point(705, 329);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 46);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "&Clear";
            this.PicToolTip.SetToolTip(this.ClearButton, "Click to Clear Form");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExitButton.Location = new System.Drawing.Point(705, 384);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 40);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "E&xit";
            this.PicToolTip.SetToolTip(this.ExitButton, "Click to Exit");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomePanel.Controls.Add(this.NameLabel);
            this.WelcomePanel.Controls.Add(this.NameBox);
            this.WelcomePanel.Controls.Add(this.StudentIdLabel);
            this.WelcomePanel.Controls.Add(this.DisplayButton);
            this.WelcomePanel.Controls.Add(this.StudentIdBox);
            this.WelcomePanel.Location = new System.Drawing.Point(34, 12);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(734, 121);
            this.WelcomePanel.TabIndex = 7;
            this.WelcomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // PicLabel
            // 
            this.PicLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicLabel.AutoSize = true;
            this.PicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicLabel.Location = new System.Drawing.Point(376, 407);
            this.PicLabel.Name = "PicLabel";
            this.PicLabel.Size = new System.Drawing.Size(72, 17);
            this.PicLabel.TabIndex = 9;
            this.PicLabel.Text = "Click Me!";
            // 
            // PinkButton
            // 
            this.PinkButton.AutoSize = true;
            this.PinkButton.Location = new System.Drawing.Point(37, 42);
            this.PinkButton.Name = "PinkButton";
            this.PinkButton.Size = new System.Drawing.Size(56, 21);
            this.PinkButton.TabIndex = 10;
            this.PinkButton.TabStop = true;
            this.PinkButton.Text = "Pink";
            this.PinkButton.UseVisualStyleBackColor = true;
            this.PinkButton.CheckedChanged += new System.EventHandler(this.PinkButton_CheckedChanged);
            // 
            // RoyalBlueButton
            // 
            this.RoyalBlueButton.AutoSize = true;
            this.RoyalBlueButton.Location = new System.Drawing.Point(37, 69);
            this.RoyalBlueButton.Name = "RoyalBlueButton";
            this.RoyalBlueButton.Size = new System.Drawing.Size(93, 21);
            this.RoyalBlueButton.TabIndex = 11;
            this.RoyalBlueButton.TabStop = true;
            this.RoyalBlueButton.Text = "RoyalBlue";
            this.RoyalBlueButton.UseVisualStyleBackColor = true;
            this.RoyalBlueButton.CheckedChanged += new System.EventHandler(this.RoyalBlueButton_CheckedChanged);
            // 
            // ChocolateButton
            // 
            this.ChocolateButton.AutoSize = true;
            this.ChocolateButton.Location = new System.Drawing.Point(37, 96);
            this.ChocolateButton.Name = "ChocolateButton";
            this.ChocolateButton.Size = new System.Drawing.Size(92, 21);
            this.ChocolateButton.TabIndex = 12;
            this.ChocolateButton.TabStop = true;
            this.ChocolateButton.Text = "Chocolate";
            this.ChocolateButton.UseVisualStyleBackColor = true;
            this.ChocolateButton.CheckedChanged += new System.EventHandler(this.ChocolateButton_CheckedChanged);
            // 
            // GreenButton
            // 
            this.GreenButton.AutoSize = true;
            this.GreenButton.Location = new System.Drawing.Point(37, 123);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(69, 21);
            this.GreenButton.TabIndex = 13;
            this.GreenButton.TabStop = true;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.CheckedChanged += new System.EventHandler(this.GreenButton_CheckedChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ColorBox.Controls.Add(this.PinkButton);
            this.ColorBox.Controls.Add(this.GreenButton);
            this.ColorBox.Controls.Add(this.RoyalBlueButton);
            this.ColorBox.Controls.Add(this.ChocolateButton);
            this.ColorBox.Location = new System.Drawing.Point(34, 211);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(200, 164);
            this.ColorBox.TabIndex = 14;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Choose a Color";
            this.PicToolTip.SetToolTip(this.ColorBox, "Click to choose color");
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(362, 136);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(66, 17);
            this.MessageLabel.TabIndex = 15;
            this.MessageLabel.Text = "Welcome";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(80, 407);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(46, 17);
            this.IdLabel.TabIndex = 16;
            this.IdLabel.Text = "label1";
            // 
            // PicToolTip
            // 
            this.PicToolTip.IsBalloon = true;
            this.PicToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImageBox.Image = global::Assignment1.Properties.Resources.Im1;
            this.ImageBox.InitialImage = null;
            this.ImageBox.Location = new System.Drawing.Point(240, 175);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(420, 220);
            this.ImageBox.TabIndex = 8;
            this.ImageBox.TabStop = false;
            this.PicToolTip.SetToolTip(this.ImageBox, "Click to change Image");
            this.ImageBox.Click += new System.EventHandler(this.ImageBox_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.PicLabel);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox StudentIdBox;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label PicLabel;
        private System.Windows.Forms.RadioButton PinkButton;
        private System.Windows.Forms.RadioButton RoyalBlueButton;
        private System.Windows.Forms.RadioButton ChocolateButton;
        private System.Windows.Forms.RadioButton GreenButton;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ToolTip PicToolTip;
    }
}

