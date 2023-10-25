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
            lblSinglePlayer = new Label();
            multiPlyr = new Button();
            optionsBtn = new Button();
            backBtn = new Button();
            lblMultiPlayer = new Label();
            lblOptions = new Label();
            lblQuit = new Label();
            title = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // singlePlyr
            // 
            singlePlyr.AutoSize = true;
            singlePlyr.BackColor = SystemColors.ActiveCaption;
            singlePlyr.Dock = DockStyle.Fill;
            singlePlyr.Location = new Point(0, 0);
            singlePlyr.Margin = new Padding(0);
            singlePlyr.Name = "singlePlyr";
            singlePlyr.Size = new Size(269, 71);
            singlePlyr.TabIndex = 0;
            singlePlyr.Text = "Single Player";
            singlePlyr.UseVisualStyleBackColor = false;
            singlePlyr.Click += singlePlyr_Click;
            // 
            // lblSinglePlayer
            // 
            lblSinglePlayer.AutoSize = true;
            lblSinglePlayer.Location = new Point(542, 163);
            lblSinglePlayer.Name = "lblSinglePlayer";
            lblSinglePlayer.Size = new Size(84, 15);
            lblSinglePlayer.TabIndex = 1;
            lblSinglePlayer.Text = "lblSinglePlayer";
            // 
            // multiPlyr
            // 
            multiPlyr.BackColor = SystemColors.ActiveCaption;
            multiPlyr.Dock = DockStyle.Fill;
            multiPlyr.Location = new Point(0, 71);
            multiPlyr.Margin = new Padding(0);
            multiPlyr.Name = "multiPlyr";
            multiPlyr.Size = new Size(269, 71);
            multiPlyr.TabIndex = 2;
            multiPlyr.Text = "Multi-Player";
            multiPlyr.UseVisualStyleBackColor = false;
            multiPlyr.Click += multiPlyr_Click;
            // 
            // optionsBtn
            // 
            optionsBtn.BackColor = SystemColors.ActiveCaption;
            optionsBtn.Dock = DockStyle.Fill;
            optionsBtn.Location = new Point(0, 142);
            optionsBtn.Margin = new Padding(0);
            optionsBtn.Name = "optionsBtn";
            optionsBtn.Size = new Size(269, 71);
            optionsBtn.TabIndex = 3;
            optionsBtn.Text = "Options/Statistics";
            optionsBtn.UseVisualStyleBackColor = false;
            optionsBtn.Click += optionsBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.ActiveCaption;
            backBtn.Dock = DockStyle.Fill;
            backBtn.Location = new Point(0, 213);
            backBtn.Margin = new Padding(0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(269, 71);
            backBtn.TabIndex = 4;
            backBtn.Text = "Quit to Desktop";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // lblMultiPlayer
            // 
            lblMultiPlayer.AutoSize = true;
            lblMultiPlayer.Location = new Point(551, 221);
            lblMultiPlayer.Name = "lblMultiPlayer";
            lblMultiPlayer.Size = new Size(80, 15);
            lblMultiPlayer.TabIndex = 5;
            lblMultiPlayer.Text = "lblMultiPlayer";
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(551, 306);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(62, 15);
            lblOptions.TabIndex = 6;
            lblOptions.Text = "lblOptions";
            // 
            // lblQuit
            // 
            lblQuit.AutoSize = true;
            lblQuit.Location = new Point(554, 355);
            lblQuit.Name = "lblQuit";
            lblQuit.Size = new Size(43, 15);
            lblQuit.TabIndex = 7;
            lblQuit.Text = "lblQuit";
            // 
            // title
            // 
            title.Location = new Point(314, 68);
            title.Name = "title";
            title.Size = new Size(152, 23);
            title.TabIndex = 8;
            title.Text = "Welcome to the GTI Arcade";
            title.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(singlePlyr, 0, 0);
            tableLayoutPanel1.Controls.Add(multiPlyr, 0, 1);
            tableLayoutPanel1.Controls.Add(optionsBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(backBtn, 0, 3);
            tableLayoutPanel1.Location = new Point(258, 136);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(269, 284);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(title);
            Controls.Add(lblQuit);
            Controls.Add(lblOptions);
            Controls.Add(lblMultiPlayer);
            Controls.Add(lblSinglePlayer);
            Name = "Game";
            Text = "Games";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}