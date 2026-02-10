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
            while (true)
            {
                using var mainMenu = new ScreenMainMenu();
                if (mainMenu.ShowDialog(this) != DialogResult.OK)
                    break;

                using var gameBoard = new ScreenGameBoard();
                gameBoard.FormBorderStyle = FormBorderStyle.None;
                gameBoard.StartPosition = FormStartPosition.Manual;
                gameBoard.Bounds = Screen.PrimaryScreen!.Bounds;
                if (gameBoard.ShowDialog(this) != DialogResult.OK)
                    break;
            }
        }
    }
}
