namespace GoodVibrations
{
    public partial class Game : Form
    {
        //Make an arcade cabinet
        //Multiplayer and Single Player games. 3 Menus. 5 games.
        public Game()
        {
            InitializeComponent();

        }
        private int clicks = 0;

        //When the button is clicked.
        private void singlePlyr_Click(object sender, EventArgs e)
        {
            lblSinglePlayer.Text = "You clicked me!";
        }
        private void multiPlyr_Click(object sender, EventArgs e)
        {
            lblMultiPlayer.Text = "You clicked me.";
        }
        private void optionsBtn_Click(object sender, EventArgs eventArgs)
        {
            lblOptions.Text = "Why did you click me?";
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            lblQuit.Text = "Don't click me again!";
            clicks += 1;
            if (clicks == 2)
            {
                //Quit program
                this.Close();
            }
        }
    }
}