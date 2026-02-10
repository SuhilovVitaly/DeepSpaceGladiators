namespace DeepSpaceGladiators.UI.Screens
{
    public partial class ScreenGameMenu : Form
    {
        public ScreenGameMenu()
        {
            InitializeComponent();
        }

        private void Event_ExitToMenu(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void Event_Resume(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
