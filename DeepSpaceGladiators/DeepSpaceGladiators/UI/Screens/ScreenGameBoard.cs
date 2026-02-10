namespace DeepSpaceGladiators.UI.Screens
{
    public partial class ScreenGameBoard : Form
    {
        public ScreenGameBoard()
        {
            InitializeComponent();
            KeyDown += ScreenGameBoard_KeyDown;
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
