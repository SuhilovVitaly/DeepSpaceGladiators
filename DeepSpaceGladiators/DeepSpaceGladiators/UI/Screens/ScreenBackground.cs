using DeepSpaceGladiators.UI.Screens;

namespace DeepSpaceGladiators
{
    public partial class ScreenBackground : Form
    {
        public ScreenBackground()
        {
            InitializeComponent();
            Load += ScreenBackground_Load;
        }

        private void ScreenBackground_Load(object? sender, EventArgs e)
        {
            using var mainMenu = new ScreenMainMenu();
            mainMenu.ShowDialog(this);
        }
    }
}
