namespace SpaceInvasion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startButton = new Button();
            hiscoresButton = new Button();
            rulesButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(0, 192, 192);
            startButton.Location = new Point(350, 178);
            startButton.Margin = new Padding(6);
            startButton.Name = "startButton";
            startButton.Size = new Size(200, 60);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // hiscoresButton
            // 
            hiscoresButton.BackColor = Color.FromArgb(0, 192, 192);
            hiscoresButton.Location = new Point(350, 247);
            hiscoresButton.Name = "hiscoresButton";
            hiscoresButton.Size = new Size(200, 60);
            hiscoresButton.TabIndex = 1;
            hiscoresButton.Text = "Hiscores";
            hiscoresButton.UseVisualStyleBackColor = false;
            hiscoresButton.Click += hiscoresButton_Click;
            // 
            // rulesButton
            // 
            rulesButton.BackColor = Color.FromArgb(0, 192, 192);
            rulesButton.Location = new Point(350, 313);
            rulesButton.Name = "rulesButton";
            rulesButton.Size = new Size(200, 60);
            rulesButton.TabIndex = 2;
            rulesButton.Text = "Rules";
            rulesButton.UseVisualStyleBackColor = false;
            rulesButton.Click += rulesButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(0, 192, 192);
            exitButton.Location = new Point(350, 379);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 60);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(882, 653);
            Controls.Add(exitButton);
            Controls.Add(rulesButton);
            Controls.Add(hiscoresButton);
            Controls.Add(startButton);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button hiscoresButton;
        private Button rulesButton;
        private Button exitButton;
    }
}