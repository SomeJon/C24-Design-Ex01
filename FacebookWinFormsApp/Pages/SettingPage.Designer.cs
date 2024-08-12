namespace FacebookClient.Pages
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
            this.appIdComboBox = new System.Windows.Forms.ComboBox();
            this.addAppIdTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addIdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appIdComboBox
            // 
            this.appIdComboBox.FormattingEnabled = true;
            this.appIdComboBox.Location = new System.Drawing.Point(61, 30);
            this.appIdComboBox.Name = "appIdComboBox";
            this.appIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.appIdComboBox.TabIndex = 0;
            this.appIdComboBox.SelectedIndexChanged += new System.EventHandler(this.appIdComboBox_SelectedIndexChanged);
            // 
            // addAppIdTextBox
            // 
            this.addAppIdTextBox.Location = new System.Drawing.Point(188, 30);
            this.addAppIdTextBox.Name = "addAppIdTextBox";
            this.addAppIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.addAppIdTextBox.TabIndex = 1;
            this.addAppIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addAppIdTextBox_KeyPress);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(294, 142);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "App id:";
            // 
            // addIdButton
            // 
            this.addIdButton.Location = new System.Drawing.Point(294, 28);
            this.addIdButton.Name = "addIdButton";
            this.addIdButton.Size = new System.Drawing.Size(75, 23);
            this.addIdButton.TabIndex = 4;
            this.addIdButton.Text = "Add";
            this.addIdButton.UseVisualStyleBackColor = true;
            this.addIdButton.Click += new System.EventHandler(this.addIdButton_Click);
            // 
            // SettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addIdButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addAppIdTextBox);
            this.Controls.Add(this.appIdComboBox);
            this.Name = "SettingPage";
            this.Size = new System.Drawing.Size(393, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox appIdComboBox;
        private System.Windows.Forms.TextBox addAppIdTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addIdButton;
    }
}
