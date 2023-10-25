namespace GoodVibrations
{
    partial class singlePlyrMenu
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
            menuTable = new TableLayoutPanel();
            playSnake = new Button();
            playComets = new Button();
            playDarts = new Button();
            exitButton = new Button();
            menuTable.SuspendLayout();
            SuspendLayout();
            // 
            // menuTable
            // 
            menuTable.ColumnCount = 1;
            menuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            menuTable.Controls.Add(playSnake, 0, 0);
            menuTable.Controls.Add(playComets, 0, 1);
            menuTable.Controls.Add(playDarts, 0, 2);
            menuTable.Controls.Add(exitButton, 0, 3);
            menuTable.Location = new Point(191, 127);
            menuTable.Name = "menuTable";
            menuTable.RowCount = 4;
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.Size = new Size(442, 311);
            menuTable.TabIndex = 1;
            // 
            // playSnake
            // 
            playSnake.Dock = DockStyle.Fill;
            playSnake.Location = new Point(3, 3);
            playSnake.Name = "playSnake";
            playSnake.Size = new Size(436, 71);
            playSnake.TabIndex = 0;
            playSnake.Text = "Snake";
            playSnake.UseVisualStyleBackColor = true;
            playSnake.Click += playSnake_Click;
            // 
            // playComets
            // 
            playComets.Dock = DockStyle.Fill;
            playComets.Location = new Point(3, 80);
            playComets.Name = "playComets";
            playComets.Size = new Size(436, 71);
            playComets.TabIndex = 1;
            playComets.Text = "Comets";
            playComets.UseVisualStyleBackColor = true;
            playComets.Click += playComets_Click;
            // 
            // playDarts
            // 
            playDarts.Dock = DockStyle.Fill;
            playDarts.Location = new Point(3, 157);
            playDarts.Name = "playDarts";
            playDarts.Size = new Size(436, 71);
            playDarts.TabIndex = 2;
            playDarts.Text = "NASA DARTS";
            playDarts.UseVisualStyleBackColor = true;
            playDarts.Click += playDarts_Click;
            // 
            // exitButton
            // 
            exitButton.DialogResult = DialogResult.Cancel;
            exitButton.Dock = DockStyle.Fill;
            exitButton.Location = new Point(3, 234);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(436, 74);
            exitButton.TabIndex = 3;
            exitButton.Text = "Back to Main Menu";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // singlePlyrMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuTable);
            Name = "singlePlyrMenu";
            Text = "singlePlyrMenu";
            menuTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel menuTable;
        private Button playSnake;
        private Button playComets;
        private Button playDarts;
        private Button exitButton;
    }
}