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

        private void Event_NewGame(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
