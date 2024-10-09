using FacebookPages.Code.Buttons;

namespace FacebookClient.Code
{
    partial class FormMain
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
            this.m_ViewPanelControl = new FacebookPages.Code.Buttons.ViewPanel();
            this.SuspendLayout();
            // 
            // m_ViewPanelControl
            // 
            this.m_ViewPanelControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_ViewPanelControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_ViewPanelControl.CurrentActivePage = null;
            this.m_ViewPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ViewPanelControl.Location = new System.Drawing.Point(0, 0);
            this.m_ViewPanelControl.Name = "m_ViewPanelControl";
            this.m_ViewPanelControl.Size = new System.Drawing.Size(894, 537);
            this.m_ViewPanelControl.TabIndex = 0;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(894, 537);
            this.Controls.Add(this.m_ViewPanelControl);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Facebook";
            this.ResumeLayout(false);

        }

        public ViewPanel m_ViewPanelControl;

        #endregion
    }
}

