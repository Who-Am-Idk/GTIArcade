using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodVibrations
{
    public partial class OptionMenu : Form
    {
        public OptionMenu()
        {
            InitializeComponent();
        }
        private void menuTable_Paint(object sender, PaintEventArgs e)
        {
            int displayW = DisplayRectangle.Width;
            int displayH = DisplayRectangle.Height;
            menuTable.Location = new Point((displayW - menuTable.Width) / 2, displayH / 3);
            menuTable.Size = new Size();
        }
        /*
         * Plan: Open File will take the user inputted file, and then write a local file called "Highscores" or something
         * That File will be used by the other form
         * Save File will use the highscores txt and save a copy of that file to the user inputted destination.
         */
        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Write functionality for saving a file. 
            }
        }

        //In the future need to make it so you can return back to the options menu instead of having to close and reopen the menu
        private void infoButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                    control.Visible = false;
            }
            creditBox.Visible = true;
            int displayW = DisplayRectangle.Width;
            int displayH = DisplayRectangle.Height;
            creditBox.Location = new Point((displayW - menuTable.Width) / 2, displayH / 3);
        }
    }
}
