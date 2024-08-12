namespace FacebookClient.Pages
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.facebooklogo = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebooklogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Azure;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(273, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Showing the current date in dd/mm/yy";
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.dateLabel);
            this.timePanel.Location = new System.Drawing.Point(3, 3);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(339, 26);
            this.timePanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(213, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(629, 146);
            this.button1.TabIndex = 2;
            this.button1.Text = "Welcome to Facebook 2.0!!!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(82, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 24);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "press to throw facebook logos in the air";
            this.textBox1.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.loginButton.Location = new System.Drawing.Point(362, 226);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(336, 97);
            this.loginButton.TabIndex = 59;
            this.loginButton.Text = "Login with Facebook";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // facebooklogo
            // 
            this.facebooklogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facebooklogo.BackColor = System.Drawing.Color.Transparent;
            this.facebooklogo.Image = ((System.Drawing.Image)(resources.GetObject("facebooklogo.Image")));
            this.facebooklogo.Location = new System.Drawing.Point(733, 226);
            this.facebooklogo.Name = "facebooklogo";
            this.facebooklogo.Size = new System.Drawing.Size(131, 98);
            this.facebooklogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebooklogo.TabIndex = 60;
            this.facebooklogo.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.exitButton.Location = new System.Drawing.Point(362, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(336, 50);
            this.exitButton.TabIndex = 61;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox9.Location = new System.Drawing.Point(164, 375);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(241, 24);
            this.textBox9.TabIndex = 62;
            this.textBox9.Text = "new mini form to confirm exit";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(913, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 77);
            this.button2.TabIndex = 63;
            this.button2.Text = "Setting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.facebooklogo);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timePanel);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(1007, 547);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebooklogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox facebooklogo;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button2;
    }
}
