namespace GoodVibrations
{
    partial class multiPlyrMenu
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
            playRoyalRuckus = new Button();
            playQuickDraw = new Button();
            playEmpty = new Button();
            exitButton = new Button();
            multiPlyrTitle = new TextBox();
            menuTable.SuspendLayout();
            SuspendLayout();
            // 
            // menuTable
            // 
            menuTable.ColumnCount = 1;
            menuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            menuTable.Controls.Add(playRoyalRuckus, 0, 0);
            menuTable.Controls.Add(playQuickDraw, 0, 1);
            menuTable.Controls.Add(playEmpty, 0, 2);
            menuTable.Controls.Add(exitButton, 0, 3);
            menuTable.Location = new Point(183, 127);
            menuTable.Name = "menuTable";
            menuTable.RowCount = 4;
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.Size = new Size(442, 311);
            menuTable.TabIndex = 1;
            // 
            // playRoyalRuckus
            // 
            playRoyalRuckus.Dock = DockStyle.Fill;
            playRoyalRuckus.Location = new Point(3, 3);
            playRoyalRuckus.Name = "playRoyalRuckus";
            playRoyalRuckus.Size = new Size(436, 71);
            playRoyalRuckus.TabIndex = 0;
            playRoyalRuckus.Text = "Royal Ruckus";
            playRoyalRuckus.UseVisualStyleBackColor = true;
            playRoyalRuckus.Click += playRoyalRuckus_Click;
            // 
            // playQuickDraw
            // 
            playQuickDraw.Dock = DockStyle.Fill;
            playQuickDraw.Location = new Point(3, 80);
            playQuickDraw.Name = "playQuickDraw";
            playQuickDraw.Size = new Size(436, 71);
            playQuickDraw.TabIndex = 1;
            playQuickDraw.Text = "Quick Draw";
            playQuickDraw.UseVisualStyleBackColor = true;
            playQuickDraw.Click += playQuickDraw_Click;
            // 
            // playEmpty
            // 
            playEmpty.Dock = DockStyle.Fill;
            playEmpty.Location = new Point(3, 157);
            playEmpty.Name = "playEmpty";
            playEmpty.Size = new Size(436, 71);
            playEmpty.TabIndex = 2;
            playEmpty.UseVisualStyleBackColor = true;
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
            // multiPlyrTitle
            // 
            multiPlyrTitle.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            multiPlyrTitle.Location = new Point(284, 69);
            multiPlyrTitle.Name = "multiPlyrTitle";
            multiPlyrTitle.ReadOnly = true;
            multiPlyrTitle.Size = new Size(240, 52);
            multiPlyrTitle.TabIndex = 2;
            multiPlyrTitle.Text = "Multiplayer";
            multiPlyrTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // multiPlyrMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(multiPlyrTitle);
            Controls.Add(menuTable);
            Name = "multiPlyrMenu";
            Text = "multiPlyrMenu";
            menuTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel menuTable;
        private Button playRoyalRuckus;
        private Button playQuickDraw;
        private Button playEmpty;
        private Button exitButton;
        private TextBox multiPlyrTitle;
    }
}