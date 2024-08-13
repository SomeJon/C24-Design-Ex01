using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookClient.Pages
{
    internal class FriendsPage : UserControl
    {
        private TextBox textBoxNumberOfFriends;
        private Buttons.PageSwitchButton buttonReturn;
        private TextBox textBox1;

        [Category(".Page Events")]
        [Description("Occurs when information is received " +
           "and needs to be proccessed.")]
        public event EventHandler RecivedInfo;

        [Category(".Page Events")]
        [Description("Occurs when recieve a page change request.")]
        public event EventHandler ChangePage;

        protected void OnRecivedInfo(object sender, EventArgs e)
        {
            RecivedInfo?.Invoke(sender, e);
        }

        protected void OnChangePage(object sender, EventArgs e)
        {
            ChangePage?.Invoke(sender, e);
        }

        private void InitializeComponent()
        {
            this.textBoxNumberOfFriends = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonReturn = new FacebookClient.Buttons.PageSwitchButton();
            this.SuspendLayout();
            // 
            // textBoxNumberOfFriends
            // 
            this.textBoxNumberOfFriends.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNumberOfFriends.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNumberOfFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxNumberOfFriends.Location = new System.Drawing.Point(0, 83);
            this.textBoxNumberOfFriends.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberOfFriends.Name = "textBoxNumberOfFriends";
            this.textBoxNumberOfFriends.Size = new System.Drawing.Size(190, 28);
            this.textBoxNumberOfFriends.TabIndex = 59;
            this.textBoxNumberOfFriends.Text = "Number of friends";
            this.textBoxNumberOfFriends.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(4, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 56);
            this.textBox1.TabIndex = 60;
            this.textBox1.Text = "frinds list";
            this.textBox1.Visible = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonReturn.Location = new System.Drawing.Point(0, 4);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.Logout;
            this.buttonReturn.Size = new System.Drawing.Size(128, 52);
            this.buttonReturn.TabIndex = 68;
            this.buttonReturn.Text = "return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // FriendsPage
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNumberOfFriends);
            this.Name = "FriendsPage";
            this.Size = new System.Drawing.Size(826, 487);
            this.Load += new System.EventHandler(this.FriendsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FriendsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
