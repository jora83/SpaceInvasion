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
            dataGridView1 = new DataGridView();
            playerBindingSource = new BindingSource(components);
            UserColumn = new DataGridViewTextBoxColumn();
            ScoreColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserColumn, ScoreColumn });
            dataGridView1.DataSource = playerBindingSource;
            dataGridView1.Location = new Point(271, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 70;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(323, 102);
            dataGridView1.TabIndex = 0;
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Scripts.Player);
            // 
            // UserColumn
            // 
            UserColumn.HeaderText = "User";
            UserColumn.MinimumWidth = 6;
            UserColumn.Name = "UserColumn";
            UserColumn.Width = 125;
            // 
            // ScoreColumn
            // 
            ScoreColumn.HeaderText = "Score";
            ScoreColumn.MinimumWidth = 6;
            ScoreColumn.Name = "ScoreColumn";
            ScoreColumn.Width = 125;
            // 
            // HiscoresForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(882, 653);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "HiscoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HiscoresForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn UserColumn;
        private DataGridViewTextBoxColumn ScoreColumn;
        private BindingSource playerBindingSource;
    }
}