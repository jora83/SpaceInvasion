namespace SpaceInvasion
{
    partial class PauseUserControl
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
            exitButton = new Button();
            resumeLabel = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(350, 313);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 60);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resumeLabel
            // 
            resumeLabel.AutoSize = true;
            resumeLabel.Location = new Point(218, 248);
            resumeLabel.Name = "resumeLabel";
            resumeLabel.Size = new Size(463, 41);
            resumeLabel.TabIndex = 2;
            resumeLabel.Text = "Press escape to resume the game";
            // 
            // PauseUserControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            Controls.Add(resumeLabel);
            Controls.Add(exitButton);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "PauseUserControl";
            Size = new Size(900, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitButton;
        private Label resumeLabel;
    }
}
