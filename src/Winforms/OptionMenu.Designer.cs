namespace GoodVibrations
{
    partial class OptionMenu
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
            openFile = new Button();
            saveFile = new Button();
            infoButton = new Button();
            exitButton = new Button();
            textBox1 = new TextBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            creditBox = new TextBox();
            menuTable.SuspendLayout();
            SuspendLayout();
            // 
            // menuTable
            // 
            menuTable.ColumnCount = 1;
            menuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            menuTable.Controls.Add(openFile, 0, 0);
            menuTable.Controls.Add(saveFile, 0, 1);
            menuTable.Controls.Add(infoButton, 0, 2);
            menuTable.Controls.Add(exitButton, 0, 3);
            menuTable.Location = new Point(188, 127);
            menuTable.Name = "menuTable";
            menuTable.RowCount = 4;
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            menuTable.Size = new Size(442, 311);
            menuTable.TabIndex = 0;
            // 
            // openFile
            // 
            openFile.Dock = DockStyle.Fill;
            openFile.Location = new Point(3, 3);
            openFile.Name = "openFile";
            openFile.Size = new Size(436, 71);
            openFile.TabIndex = 0;
            openFile.Text = "Load Existing Highscores";
            openFile.UseVisualStyleBackColor = true;
            openFile.Click += openFile_Click;
            // 
            // saveFile
            // 
            saveFile.Dock = DockStyle.Fill;
            saveFile.Location = new Point(3, 80);
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(436, 71);
            saveFile.TabIndex = 1;
            saveFile.Text = "Save Highscores to Disk";
            saveFile.UseVisualStyleBackColor = true;
            saveFile.Click += saveFile_Click;
            // 
            // infoButton
            // 
            infoButton.Dock = DockStyle.Fill;
            infoButton.Location = new Point(3, 157);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(436, 71);
            infoButton.TabIndex = 2;
            infoButton.Text = "Program Information";
            infoButton.UseVisualStyleBackColor = true;
            infoButton.Click += infoButton_Click;
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
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(309, 53);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(193, 43);
            textBox1.TabIndex = 1;
            textBox1.Text = "Options Menu";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "Text Files|*.txt";
            // 
            // creditBox
            // 
            creditBox.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            creditBox.Location = new Point(191, 53);
            creditBox.Name = "creditBox";
            creditBox.ReadOnly = true;
            creditBox.Size = new Size(440, 52);
            creditBox.TabIndex = 2;
            creditBox.Text = "Written by Matthew Sorensen";
            creditBox.Visible = false;
            // 
            // OptionMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(creditBox);
            Controls.Add(textBox1);
            Controls.Add(menuTable);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OptionMenu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "OptionMenu";
            menuTable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel menuTable;
        private Button openFile;
        private Button saveFile;
        private Button infoButton;
        private Button exitButton;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private TextBox creditBox;
    }
}