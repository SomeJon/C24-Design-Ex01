using FacebookPages.Code.Buttons;
using FacebookPages.Code.Buttons.Interfaces;

namespace FacebookPages.Code.Pages
{
    partial class LoginSettingPage
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
            this.appIdComboBox = new System.Windows.Forms.ComboBox();
            this.addAppIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new PageSwitchButton();
            this.addIdButton = new LoadInfoButton();
            this.SuspendLayout();
            // 
            // appIdComboBox
            // 
            this.appIdComboBox.FormattingEnabled = true;
            this.appIdComboBox.Location = new System.Drawing.Point(118, 59);
            this.appIdComboBox.Name = "appIdComboBox";
            this.appIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.appIdComboBox.TabIndex = 0;
            // 
            // addAppIdTextBox
            // 
            this.addAppIdTextBox.Location = new System.Drawing.Point(253, 61);
            this.addAppIdTextBox.Multiline = true;
            this.addAppIdTextBox.Name = "addAppIdTextBox";
            this.addAppIdTextBox.Size = new System.Drawing.Size(100, 19);
            this.addAppIdTextBox.TabIndex = 1;
            this.addAppIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addAppIdTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "App id:";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(722, 368);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.PageChoice = ePageChoice.Login;
            this.buttonBack.Size = new System.Drawing.Size(75, 20);
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
            this.addIdButton.InfoChoice = eInfoChoice.AppId;
            this.addIdButton.Location = new System.Drawing.Point(366, 53);
            this.addIdButton.Name = "addIdButton";
            this.addIdButton.ReceivedInfo = null;
            this.addIdButton.Size = new System.Drawing.Size(46, 31);
            this.addIdButton.TabIndex = 6;
            this.addIdButton.Text = "Add";
            this.addIdButton.UseCompatibleTextRendering = true;
            this.addIdButton.UseVisualStyleBackColor = false;
            this.addIdButton.Click += new System.EventHandler(this.addIdButton_Click);
            // 
            // LoginSettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.addIdButton);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAppIdTextBox);
            this.Controls.Add(this.appIdComboBox);
            this.Name = "LoginSettingPage";
            this.Size = new System.Drawing.Size(818, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox appIdComboBox;
        private System.Windows.Forms.TextBox addAppIdTextBox;
        private System.Windows.Forms.Label label1;
        private PageSwitchButton buttonBack;
        private LoadInfoButton addIdButton;
    }
}
