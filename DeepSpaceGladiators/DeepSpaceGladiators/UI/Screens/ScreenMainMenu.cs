using DeepSpaceGladiatorsEngine.Models;

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
            DialogResult = DialogResult.OK;
            Application.Exit();
        }

        private void Event_NewGame(object sender, EventArgs e)
        {            
            var battleState = BattleState.CreateDefault();
            using var gameBoard = new ScreenGameBoard(battleState);
            gameBoard.ShowDialog(this);
        }
    }
}
