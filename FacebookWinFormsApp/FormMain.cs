using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using FacebookClient.Pages;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public LoginResult LoginResult { get; set; }
        public User LoggedUser { get; private set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("design.patterns");

            if (LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            LoginResult = FacebookService.Login(AppSettings.s_AppID,
                    AppSettings.s_Permissions);

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedUser = LoginResult.LoggedInUser;
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
            }

            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                //pictureBoxProfile.ImageLocation = LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                //buttonLogout.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            //buttonLogin.BackColor = buttonLogout.BackColor;
            LoginResult = null;
            buttonLogin.Enabled = true;
           // buttonLogout.Enabled = false;
        }

        private void loginPage1_SelectedChoice(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            if((sender as Button).Name.Equals("loginButton"))
            {
                login();
                MainPage.SelectedIndex = 0;
            }
            else
            {
                MainPage.SelectedIndex = 2;
            }
        }

        public static class AppSettings
        {
            public static string s_AppID = "867142571975316";
            public static string[] s_Permissions = new string[] {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            //"user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"};
        }

        private void changePage_PageControl(object sender, EventArgs e)
        {
            //check to which page we need to move
            Button selectedPage = sender as Button;
            if ((sender as Button).Name.Equals("loginButton"))
            {
                login();
                MainPage.SelectedIndex = 0;
            }
            else if ((sender as Button).Name.Equals("settingButton"))
            {
                MainPage.SelectedIndex = 2;
            }
            else
            {
                MainPage.SelectedIndex = 1;
            }
        }

        private void recivedInfo_PageControl(object sender, EventArgs e)
        {
            //check which new info recived and use it
            AppSettings.s_AppID = (sender as ComboBox).SelectedItem.ToString();
        }

        private void buttonLogout_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
