namespace SpaceInvasion
{
    partial class InformationsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            objectiveRichTextBox = new RichTextBox();
            controlsRichTextBox = new RichTextBox();
            label4 = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 9);
            label2.Name = "label2";
            label2.Size = new Size(186, 41);
            label2.TabIndex = 1;
            label2.Text = "Informations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 65);
            label3.Name = "label3";
            label3.Size = new Size(150, 41);
            label3.TabIndex = 2;
            label3.Text = "Objective:";
            // 
            // objectiveRichTextBox
            // 
            objectiveRichTextBox.BackColor = Color.LightSeaGreen;
            objectiveRichTextBox.Location = new Point(12, 111);
            objectiveRichTextBox.Name = "objectiveRichTextBox";
            objectiveRichTextBox.ReadOnly = true;
            objectiveRichTextBox.Size = new Size(858, 150);
            objectiveRichTextBox.TabIndex = 3;
            objectiveRichTextBox.Text = "lalalalala";
            // 
            // controlsRichTextBox
            // 
            controlsRichTextBox.BackColor = Color.LightSeaGreen;
            controlsRichTextBox.Location = new Point(12, 313);
            controlsRichTextBox.Name = "controlsRichTextBox";
            controlsRichTextBox.ReadOnly = true;
            controlsRichTextBox.Size = new Size(858, 150);
            controlsRichTextBox.TabIndex = 4;
            controlsRichTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 269);
            label4.Name = "label4";
            label4.Size = new Size(137, 41);
            label4.TabIndex = 5;
            label4.Text = "Controls:";
            // 
            // backButton
            // 
            backButton.BackColor = Color.LightSeaGreen;
            backButton.Location = new Point(350, 582);
            backButton.Name = "backButton";
            backButton.Size = new Size(200, 60);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // InformationsForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(882, 653);
            Controls.Add(backButton);
            Controls.Add(label4);
            Controls.Add(controlsRichTextBox);
            Controls.Add(objectiveRichTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "InformationsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformationsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox objectiveRichTextBox;
        private RichTextBox controlsRichTextBox;
        private Label label4;
        private Button backButton;
    }
}