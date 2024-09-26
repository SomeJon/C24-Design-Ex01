using FacebookPages.Code.Buttons;
using FacebookPages.Code.Buttons.Interfaces;

namespace FacebookPages.Pages
{
    partial class PhotosPage
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
            this.buttonReturn = new PageSwitchButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_AlbumChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_PicturesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(4, 4);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.PageChoice = ePageChoice.WallPage;
            this.buttonReturn.Size = new System.Drawing.Size(70, 38);
            this.buttonReturn.TabIndex = 76;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(88, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 79;
            this.label1.Text = "my albums:";
            // 
            // m_AlbumChoiceComboBox
            // 
            this.m_AlbumChoiceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_AlbumChoiceComboBox.FormattingEnabled = true;
            this.m_AlbumChoiceComboBox.Location = new System.Drawing.Point(286, 15);
            this.m_AlbumChoiceComboBox.Name = "m_AlbumChoiceComboBox";
            this.m_AlbumChoiceComboBox.Size = new System.Drawing.Size(364, 21);
            this.m_AlbumChoiceComboBox.TabIndex = 80;
            this.m_AlbumChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.m_AlbumChoiceComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(5, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 70);
            this.panel1.TabIndex = 81;
            // 
            // m_PicturesFlow
            // 
            this.m_PicturesFlow.AutoScroll = true;
            this.m_PicturesFlow.BackColor = System.Drawing.Color.SteelBlue;
            this.m_PicturesFlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_PicturesFlow.Location = new System.Drawing.Point(0, 125);
            this.m_PicturesFlow.Name = "m_PicturesFlow";
            this.m_PicturesFlow.Size = new System.Drawing.Size(652, 290);
            this.m_PicturesFlow.TabIndex = 82;
            // 
            // PhotosPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.m_PicturesFlow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_AlbumChoiceComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhotosPage";
            this.Size = new System.Drawing.Size(652, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PageSwitchButton buttonReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_AlbumChoiceComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel m_PicturesFlow;
    }
}
