namespace GoodVibrations
{
    partial class Game
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
            singlePlyr = new Button();
            multiPlyr = new Button();
            optionsBtn = new Button();
            backBtn = new Button();
            title = new TextBox();
            menuTable = new TableLayoutPanel();
            menuTable.SuspendLayout();
            SuspendLayout();
            // 
            // singlePlyr
            // 
            singlePlyr.AutoSize = true;
            singlePlyr.BackColor = SystemColors.ActiveCaption;
            singlePlyr.Dock = DockStyle.Fill;
            singlePlyr.Location = new Point(3, 3);
            singlePlyr.Name = "singlePlyr";
            singlePlyr.Size = new Size(294, 73);
            singlePlyr.TabIndex = 0;
            singlePlyr.Text = "Single Player";
            singlePlyr.UseVisualStyleBackColor = false;
            singlePlyr.Click += singlePlyr_Click;
            // 
            // multiPlyr
            // 
            multiPlyr.BackColor = SystemColors.ActiveCaption;
            multiPlyr.Dock = DockStyle.Fill;
            multiPlyr.Location = new Point(3, 82);
            multiPlyr.Name = "multiPlyr";
            multiPlyr.Size = new Size(294, 73);
            multiPlyr.TabIndex = 2;
            multiPlyr.Text = "Multi-Player";
            multiPlyr.UseVisualStyleBackColor = false;
            multiPlyr.Click += multiPlyr_Click;
            // 
            // optionsBtn
            // 
            optionsBtn.BackColor = SystemColors.ActiveCaption;
            optionsBtn.Dock = DockStyle.Fill;
            optionsBtn.Location = new Point(3, 161);
            optionsBtn.Name = "optionsBtn";
            optionsBtn.Size = new Size(294, 73);
            optionsBtn.TabIndex = 3;
            optionsBtn.Text = "Options/Statistics";
            optionsBtn.UseVisualStyleBackColor = false;
            optionsBtn.Click += optionsBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ActiveCaption;
            backBtn.Dock = DockStyle.Fill;
            backBtn.Location = new Point(3, 240);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(294, 73);
            backBtn.TabIndex = 4;
            backBtn.Text = "Quit to Desktop";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            title.Location = new Point(345, 98);
            title.Name = "title";
            title.Size = new Size(514, 61);
            title.TabIndex = 8;
            title.Text = "Welcome to the GTI Arcade";
            title.TextAlign = HorizontalAlignment.Center;
            // 
            // menuTable
            // 
            menuTable.AutoScroll = true;
            menuTable.AutoSize = true;
            menuTable.ColumnCount = 1;
            menuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTable.Controls.Add(singlePlyr, 0, 0);
            menuTable.Controls.Add(multiPlyr, 0, 1);
            menuTable.Controls.Add(optionsBtn, 0, 2);
            menuTable.Controls.Add(backBtn, 0, 3);
            menuTable.Location = new Point(456, 207);
            menuTable.Name = "menuTable";
            menuTable.RowCount = 4;
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.Size = new Size(300, 316);
            menuTable.TabIndex = 9;
            menuTable.Paint += menuTable_Paint;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(menuTable);
            Controls.Add(title);
            Name = "Game";
            Text = "Games";
            menuTable.ResumeLayout(false);
            menuTable.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button singlePlyr;
        private Button multiPlyr;
        private Button optionsBtn;
        private Button backBtn;
        private Label lblSinglePlayer;
        private Label lblMultiPlayer;
        private Label lblOptions;
        private Label lblQuit;
        private TextBox title;
        private TableLayoutPanel menuTable;
    }
}