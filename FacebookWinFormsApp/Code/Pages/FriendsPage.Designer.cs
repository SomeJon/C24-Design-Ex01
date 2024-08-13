namespace FacebookClient.Code.Pages
{
    partial class FriendsPage
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
            this.pageSwitchButton1 = new FacebookClient.Buttons.PageSwitchButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pageSwitchButton1
            // 
            this.pageSwitchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pageSwitchButton1.Location = new System.Drawing.Point(4, 4);
            this.pageSwitchButton1.Margin = new System.Windows.Forms.Padding(4);
            this.pageSwitchButton1.Name = "pageSwitchButton1";
            this.pageSwitchButton1.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.Logout;
            this.pageSwitchButton1.Size = new System.Drawing.Size(128, 52);
            this.pageSwitchButton1.TabIndex = 68;
            this.pageSwitchButton1.Text = "return";
            this.pageSwitchButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(4, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 24);
            this.textBox1.TabIndex = 59;
            this.textBox1.Text = "Number of friends";
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(8, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 56);
            this.textBox2.TabIndex = 60;
            this.textBox2.Text = "frinds list";
            this.textBox2.Visible = false;
            // 
            // FriendsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.pageSwitchButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FriendsPage";
            this.Size = new System.Drawing.Size(591, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buttons.PageSwitchButton pageSwitchButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
