namespace GoodVibrations
{
    public partial class Game : Form
    {
        /*
         * Written by Matthew Sorensen
         * 10/25/23
         * v0.0.2
         * Objective: Create a winforms program that features a few games, both single and multiplayer.
         */
        public Game()
        {
            InitializeComponent();

        }

        private void menuTable_Paint(object sender, PaintEventArgs e)
        {

            int displayW = DisplayRectangle.Width;
            int displayH = DisplayRectangle.Height;
            menuTable.Location = new Point((displayW - menuTable.Width) / 2, displayH / 3);
            //menuTable.Size = new Size();
        }

        //When the button is clicked.
        private void singlePlyr_Click(object sender, EventArgs e)
        {
            singlePlyrMenu unoPlyrMenu = new singlePlyrMenu();
            unoPlyrMenu.ShowDialog(this);
        }
        private void multiPlyr_Click(object sender, EventArgs e)
        {
            multiPlyrMenu dosPlyrMenu = new multiPlyrMenu();
            dosPlyrMenu.ShowDialog(this);
        }
        private void optionsBtn_Click(object sender, EventArgs e)
        {
            OptionMenu optionMenu = new OptionMenu();
            optionMenu.ShowDialog(this);
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_Resize(object sender, EventArgs e)
        {
            menuTable_Paint(){ };
        }
    }
}