namespace FacebookPages.Code.Pages
{
    partial class UserControl1
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
            this.postViewButton1 = new FacebookPages.Code.Buttons.PostViewButton();
            this.SuspendLayout();
            // 
            // postViewButton1
            // 
            this.postViewButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.postViewButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.postViewButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postViewButton1.Location = new System.Drawing.Point(0, 181);
            this.postViewButton1.Margin = new System.Windows.Forms.Padding(4);
            this.postViewButton1.Name = "postViewButton1";
            this.postViewButton1.Size = new System.Drawing.Size(846, 178);
            this.postViewButton1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postViewButton1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(846, 359);
            this.ResumeLayout(false);

        }

        #endregion

        private Buttons.PostViewButton postViewButton1;
    }
}
