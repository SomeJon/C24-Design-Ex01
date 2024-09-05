using FacebookPages.Code.Buttons;

namespace FacebookPages.Code.Pages
{
    partial class HomePage
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
            this.useCase1Button = new FacebookPages.Buttons.PageSwitchButton();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.PageChoice = ePageChoice.Logout;
            this.logoutButton.Text = "Logout";
            // 
            // useCase1Button
            // 
            this.useCase1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.useCase1Button.Location = new System.Drawing.Point(238, 214);
            this.useCase1Button.Name = "useCase1Button";
            this.useCase1Button.PageChoice = ePageChoice.UseCase1Page;
            this.useCase1Button.Size = new System.Drawing.Size(133, 31);
            this.useCase1Button.TabIndex = 76;
            this.useCase1Button.Text = "Use Case 1";
            this.useCase1Button.UseVisualStyleBackColor = true;
            this.useCase1Button.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.useCase1Button);
            this.Name = "HomePage";
            this.Controls.SetChildIndex(this.logoutButton, 0);
            this.Controls.SetChildIndex(this.useCase1Button, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FacebookPages.Buttons.PageSwitchButton useCase1Button;
    }
}
