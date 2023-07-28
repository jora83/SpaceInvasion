namespace SpaceInvasion
{
    partial class EnterUserForm
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
            userTextBox = new TextBox();
            userLabel = new Label();
            enterButton = new Button();
            SuspendLayout();
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(325, 315);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(250, 47);
            userTextBox.TabIndex = 0;
            userTextBox.KeyUp += EnterButtonUp;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(325, 271);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(247, 41);
            userLabel.TabIndex = 1;
            userLabel.Text = "Enter a username";
            // 
            // enterButton
            // 
            enterButton.Location = new Point(350, 368);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(200, 60);
            enterButton.TabIndex = 2;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // EnterUserForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(882, 653);
            Controls.Add(enterButton);
            Controls.Add(userLabel);
            Controls.Add(userTextBox);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "EnterUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnterUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userTextBox;
        private Label userLabel;
        private Button enterButton;
    }
}