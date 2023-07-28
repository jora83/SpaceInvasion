namespace SpaceInvasion
{
    partial class HiscoresForm
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
            components = new System.ComponentModel.Container();
            playerBindingSource = new BindingSource(components);
            dataGridView = new DataGridView();
            label1 = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Scripts.Player);
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(200, 67);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(500, 500);
            dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 19);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 1;
            label1.Text = "Highscores";
            // 
            // backButton
            // 
            backButton.Location = new Point(350, 581);
            backButton.Name = "backButton";
            backButton.Size = new Size(200, 60);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // HiscoresForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(882, 653);
            Controls.Add(backButton);
            Controls.Add(label1);
            Controls.Add(dataGridView);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "HiscoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HiscoresForm";
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource playerBindingSource;
        private DataGridView dataGridView;
        private Label label1;
        private Button backButton;
    }
}