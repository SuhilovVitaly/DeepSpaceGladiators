namespace DeepSpaceGladiators.UI.Screens
{
    public partial class ScreenMainMenu : Form
    {
        public ScreenMainMenu()
        {
            InitializeComponent();
        }

        private void Event_ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
