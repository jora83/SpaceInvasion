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
            highscoresButton = new Button();
            informationsButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.LightSeaGreen;
            startButton.Location = new Point(350, 194);
            startButton.Margin = new Padding(6);
            startButton.Name = "startButton";
            startButton.Size = new Size(200, 60);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // highscoresButton
            // 
            highscoresButton.BackColor = Color.LightSeaGreen;
            highscoresButton.Location = new Point(350, 263);
            highscoresButton.Name = "highscoresButton";
            highscoresButton.Size = new Size(200, 60);
            highscoresButton.TabIndex = 1;
            highscoresButton.Text = "Highscores";
            highscoresButton.UseVisualStyleBackColor = false;
            highscoresButton.Click += hiscoresButton_Click;
            // 
            // informationsButton
            // 
            informationsButton.BackColor = Color.LightSeaGreen;
            informationsButton.Location = new Point(350, 329);
            informationsButton.Name = "informationsButton";
            informationsButton.Size = new Size(200, 60);
            informationsButton.TabIndex = 2;
            informationsButton.Text = "Informations";
            informationsButton.UseVisualStyleBackColor = false;
            informationsButton.Click += rulesButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.LightSeaGreen;
            exitButton.Location = new Point(350, 395);
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
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(882, 653);
            Controls.Add(exitButton);
            Controls.Add(informationsButton);
            Controls.Add(highscoresButton);
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
        private Button highscoresButton;
        private Button informationsButton;
        private Button exitButton;
    }
}