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
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_ViewPanelControl = new FacebookPages.Code.Buttons.ViewPanel();
            this.postViewButton1 = new FacebookPages.Code.Buttons.PostViewButton();
            this.demoControl1 = new FacebookPages.Code.Buttons.DemoControl();
            this.m_ViewPanelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 420);
            this.panel1.TabIndex = 1;
            // 
            // m_ViewPanelControl
            // 
            this.m_ViewPanelControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_ViewPanelControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_ViewPanelControl.Controls.Add(this.postViewButton1);
            this.m_ViewPanelControl.Location = new System.Drawing.Point(681, 466);
            this.m_ViewPanelControl.Name = "m_ViewPanelControl";
            this.m_ViewPanelControl.Size = new System.Drawing.Size(165, 127);
            this.m_ViewPanelControl.TabIndex = 0;
            // 
            // postViewButton1
            // 
            this.postViewButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.postViewButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.postViewButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.postViewButton1.Location = new System.Drawing.Point(0, 0);
            this.postViewButton1.Margin = new System.Windows.Forms.Padding(4);
            this.postViewButton1.Name = "postViewButton1";
            this.postViewButton1.Size = new System.Drawing.Size(165, 100);
            this.postViewButton1.TabIndex = 0;
            // 
            // demoControl1
            // 
            this.demoControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.demoControl1.Location = new System.Drawing.Point(28, 441);
            this.demoControl1.Name = "demoControl1";
            this.demoControl1.Size = new System.Drawing.Size(462, 111);
            this.demoControl1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(846, 593);
            this.Controls.Add(this.demoControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_ViewPanelControl);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.m_ViewPanelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public ViewPanel m_ViewPanelControl;

        #endregion

        private PostViewButton postViewButton1;
        private System.Windows.Forms.Panel panel1;
        private DemoControl demoControl1;
    }
}

