using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiators.UI.Screens
{
    public partial class ScreenGameBoard : Form
    {
        public BattleState BattleState { get; }

        public ScreenGameBoard() : this(BattleState.CreateDefault())
        {
        }

        public ScreenGameBoard(BattleState battleState)
        {
            BattleState = battleState ?? throw new ArgumentNullException(nameof(battleState));
            InitializeComponent();
            Load += ScreenGameBoard_Load;
            KeyDown += ScreenGameBoard_KeyDown;
        }

        private void ScreenGameBoard_Load(object? sender, EventArgs e)
        {
            Bounds = Screen.PrimaryScreen!.Bounds;
            PlayerPilot.Bind(BattleState.Player.Pilot);
            ComputerPilot.Bind(BattleState.Opponent.Pilot);
        }

        private void ScreenGameBoard_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                using var gameMenu = new ScreenGameMenu();
                if (gameMenu.ShowDialog(this) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
