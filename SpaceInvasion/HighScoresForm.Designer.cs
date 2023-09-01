namespace SpaceInvasion
{
    partial class HighScoresForm
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
            dataGridView = new DataGridView();
            backButton = new Button();
            highscoresLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.Gray;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(214, 71);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(472, 500);
            dataGridView.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightSeaGreen;
            backButton.Location = new Point(350, 583);
            backButton.Name = "backButton";
            backButton.Size = new Size(200, 60);
            backButton.TabIndex = 1;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // highscoresLabel
            // 
            highscoresLabel.AutoSize = true;
            highscoresLabel.Location = new Point(368, 21);
            highscoresLabel.Name = "highscoresLabel";
            highscoresLabel.Size = new Size(165, 41);
            highscoresLabel.TabIndex = 2;
            highscoresLabel.Text = "Highscores";
            // 
            // HiscoresForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(882, 653);
            Controls.Add(highscoresLabel);
            Controls.Add(backButton);
            Controls.Add(dataGridView);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "HiscoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HiscoresForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView;
        private Button backButton;
        private Label highscoresLabel;
    }
}