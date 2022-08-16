namespace ISP_ChatClient
{
    partial class UserData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserData));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TextboxLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ExportButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ConnectButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.UserTextbox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SendButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FontButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Location = new System.Drawing.Point(0, -2);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(695, 59);
            this.TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ChatClient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExitButton.color = System.Drawing.Color.Firebrick;
            this.ExitButton.colorActive = System.Drawing.Color.Sienna;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.2F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImagePosition = 14;
            this.ExitButton.ImageZoom = 50;
            this.ExitButton.LabelPosition = 27;
            this.ExitButton.LabelText = "Izlaz";
            this.ExitButton.Location = new System.Drawing.Point(594, 380);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 85);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TextboxLabel
            // 
            this.TextboxLabel.AutoSize = true;
            this.TextboxLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxLabel.ForeColor = System.Drawing.Color.Black;
            this.TextboxLabel.Location = new System.Drawing.Point(12, 394);
            this.TextboxLabel.Name = "TextboxLabel";
            this.TextboxLabel.Size = new System.Drawing.Size(120, 20);
            this.TextboxLabel.TabIndex = 2;
            this.TextboxLabel.Text = "Korisničko ime:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(669, 309);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ExportButton.color = System.Drawing.Color.LightSeaGreen;
            this.ExportButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.2F);
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportButton.Image")));
            this.ExportButton.ImagePosition = 14;
            this.ExportButton.ImageZoom = 50;
            this.ExportButton.LabelPosition = 27;
            this.ExportButton.LabelText = "Izvoz";
            this.ExportButton.Location = new System.Drawing.Point(499, 380);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(85, 85);
            this.ExportButton.TabIndex = 5;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ConnectButton.color = System.Drawing.Color.SeaGreen;
            this.ConnectButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.ConnectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.2F);
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectButton.Image")));
            this.ConnectButton.ImagePosition = 14;
            this.ConnectButton.ImageZoom = 50;
            this.ConnectButton.LabelPosition = 27;
            this.ConnectButton.LabelText = "Poveži se";
            this.ConnectButton.Location = new System.Drawing.Point(284, 380);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(5);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(85, 85);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // UserTextbox
            // 
            this.UserTextbox.AcceptsReturn = false;
            this.UserTextbox.AcceptsTab = false;
            this.UserTextbox.AnimationSpeed = 200;
            this.UserTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserTextbox.BackColor = System.Drawing.Color.Transparent;
            this.UserTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserTextbox.BackgroundImage")));
            this.UserTextbox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.UserTextbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserTextbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UserTextbox.BorderColorIdle = System.Drawing.Color.Silver;
            this.UserTextbox.BorderRadius = 1;
            this.UserTextbox.BorderThickness = 1;
            this.UserTextbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTextbox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.UserTextbox.DefaultText = "";
            this.UserTextbox.FillColor = System.Drawing.Color.White;
            this.UserTextbox.HideSelection = true;
            this.UserTextbox.IconLeft = null;
            this.UserTextbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTextbox.IconPadding = 10;
            this.UserTextbox.IconRight = null;
            this.UserTextbox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTextbox.Lines = new string[0];
            this.UserTextbox.Location = new System.Drawing.Point(16, 417);
            this.UserTextbox.MaxLength = 32767;
            this.UserTextbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserTextbox.Modified = false;
            this.UserTextbox.Multiline = false;
            this.UserTextbox.Name = "UserTextbox";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserTextbox.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserTextbox.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserTextbox.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserTextbox.OnIdleState = stateProperties12;
            this.UserTextbox.Padding = new System.Windows.Forms.Padding(3);
            this.UserTextbox.PasswordChar = '\0';
            this.UserTextbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserTextbox.PlaceholderText = "Petar Perić";
            this.UserTextbox.ReadOnly = false;
            this.UserTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTextbox.SelectedText = "";
            this.UserTextbox.SelectionLength = 0;
            this.UserTextbox.SelectionStart = 0;
            this.UserTextbox.ShortcutsEnabled = true;
            this.UserTextbox.Size = new System.Drawing.Size(260, 41);
            this.UserTextbox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserTextbox.TabIndex = 7;
            this.UserTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserTextbox.TextMarginBottom = 0;
            this.UserTextbox.TextMarginLeft = 3;
            this.UserTextbox.TextMarginTop = 0;
            this.UserTextbox.TextPlaceholder = "Petar Perić";
            this.UserTextbox.UseSystemPasswordChar = false;
            this.UserTextbox.WordWrap = true;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.SeaGreen;
            this.SendButton.color = System.Drawing.Color.SeaGreen;
            this.SendButton.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.2F);
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.Image")));
            this.SendButton.ImagePosition = 14;
            this.SendButton.ImageZoom = 50;
            this.SendButton.LabelPosition = 27;
            this.SendButton.LabelText = "Pošalji";
            this.SendButton.Location = new System.Drawing.Point(284, 380);
            this.SendButton.Margin = new System.Windows.Forms.Padding(5);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(85, 85);
            this.SendButton.TabIndex = 8;
            this.SendButton.Visible = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // FontButton
            // 
            this.FontButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.FontButton.color = System.Drawing.Color.DodgerBlue;
            this.FontButton.colorActive = System.Drawing.Color.DarkSlateGray;
            this.FontButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FontButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.2F);
            this.FontButton.ForeColor = System.Drawing.Color.White;
            this.FontButton.Image = ((System.Drawing.Image)(resources.GetObject("FontButton.Image")));
            this.FontButton.ImagePosition = 14;
            this.FontButton.ImageZoom = 50;
            this.FontButton.LabelPosition = 27;
            this.FontButton.LabelText = "Font";
            this.FontButton.Location = new System.Drawing.Point(404, 380);
            this.FontButton.Margin = new System.Windows.Forms.Padding(5);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(85, 85);
            this.FontButton.TabIndex = 9;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 479);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.UserTextbox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TextboxLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserData";
            this.Text = "ISP ChatClient";
            this.Load += new System.EventHandler(this.UserData_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton ExitButton;
        private System.Windows.Forms.Label TextboxLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuTileButton ExportButton;
        private Bunifu.Framework.UI.BunifuTileButton ConnectButton;
        private Bunifu.UI.WinForms.BunifuTextBox UserTextbox;
        private Bunifu.Framework.UI.BunifuTileButton SendButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Bunifu.Framework.UI.BunifuTileButton FontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

