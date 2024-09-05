namespace FacebookPages.Pages
{
    partial class SettingPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingPage));
            this.appIdComboBox = new System.Windows.Forms.ComboBox();
            this.addAppIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new FacebookPages.Buttons.PageSwitchButton();
            this.addIdButton = new FacebookPages.Buttons.LoadInfoButton();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // appIdComboBox
            // 
            this.appIdComboBox.FormattingEnabled = true;
            this.appIdComboBox.Location = new System.Drawing.Point(157, 73);
            this.appIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.appIdComboBox.Name = "appIdComboBox";
            this.appIdComboBox.Size = new System.Drawing.Size(160, 24);
            this.appIdComboBox.TabIndex = 0;
            // 
            // addAppIdTextBox
            // 
            this.addAppIdTextBox.Location = new System.Drawing.Point(337, 75);
            this.addAppIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addAppIdTextBox.Multiline = true;
            this.addAppIdTextBox.Name = "addAppIdTextBox";
            this.addAppIdTextBox.Size = new System.Drawing.Size(132, 22);
            this.addAppIdTextBox.TabIndex = 1;
            this.addAppIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addAppIdTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "App id:";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(834, 453);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.Login;
            this.buttonBack.Size = new System.Drawing.Size(100, 25);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addIdButton
            // 
            this.addIdButton.BackColor = System.Drawing.Color.DarkBlue;
            this.addIdButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addIdButton.FlatAppearance.BorderSize = 0;
            this.addIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIdButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addIdButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addIdButton.InfoChoice = FacebookPages.Buttons.LoadInfoButton.eInfoChoice.AppId;
            this.addIdButton.Location = new System.Drawing.Point(488, 65);
            this.addIdButton.Margin = new System.Windows.Forms.Padding(4);
            this.addIdButton.Name = "addIdButton";
            this.addIdButton.RecivedInfo = null;
            this.addIdButton.Size = new System.Drawing.Size(62, 38);
            this.addIdButton.TabIndex = 6;
            this.addIdButton.Text = "Add";
            this.addIdButton.UseCompatibleTextRendering = true;
            this.addIdButton.UseVisualStyleBackColor = false;
            this.addIdButton.Click += new System.EventHandler(this.addIdButton_Click);
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
            this.pictureBoxReturn.Location = new System.Drawing.Point(951, 434);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(60, 44);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReturn.TabIndex = 70;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Tag = "back";
            this.pictureBoxReturn.Click += new System.EventHandler(this.pictureBoxReturn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(748, 378);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 28);
            this.textBox3.TabIndex = 71;
            this.textBox3.Text = "select back or emoji";
            this.textBox3.Visible = false;
            // 
            // SettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.addIdButton);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAppIdTextBox);
            this.Controls.Add(this.appIdComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingPage";
            this.Size = new System.Drawing.Size(1091, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox appIdComboBox;
        private System.Windows.Forms.TextBox addAppIdTextBox;
        private System.Windows.Forms.Label label1;
        private Buttons.PageSwitchButton buttonBack;
        private Buttons.LoadInfoButton addIdButton;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.TextBox textBox3;
    }
}
