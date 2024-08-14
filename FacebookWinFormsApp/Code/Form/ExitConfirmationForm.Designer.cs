namespace FacebookClient.Pages
{
    partial class ExitConfirmationForm
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
            this.labelExitConfirmation = new System.Windows.Forms.Label();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelExitConfirmation
            // 
            this.labelExitConfirmation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelExitConfirmation.AutoSize = true;
            this.labelExitConfirmation.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelExitConfirmation.Location = new System.Drawing.Point(49, 22);
            this.labelExitConfirmation.Name = "labelExitConfirmation";
            this.labelExitConfirmation.Size = new System.Drawing.Size(519, 50);
            this.labelExitConfirmation.TabIndex = 0;
            this.labelExitConfirmation.Text = "Are you sure you want to exit?";
            // 
            // buttonYes
            // 
            this.buttonYes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonYes.BackColor = System.Drawing.Color.LightGreen;
            this.buttonYes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonYes.Location = new System.Drawing.Point(31, 165);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(201, 111);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNo.BackColor = System.Drawing.Color.Red;
            this.buttonNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonNo.Location = new System.Drawing.Point(388, 165);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(195, 111);
            this.buttonNo.TabIndex = 2;
            this.buttonNo.Text = "No";
            this.buttonNo.UseVisualStyleBackColor = false;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // ExitConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(618, 355);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.buttonYes);
            this.Controls.Add(this.labelExitConfirmation);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 373);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(636, 373);
            this.Name = "ExitConfirmationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExitConfirmation;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNo;
    }
}