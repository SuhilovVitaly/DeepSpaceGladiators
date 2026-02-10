using DeepSpaceGladiatorsEngine.Models;

namespace DeepSpaceGladiators.UI.Controls
{
    public partial class ControlPilot : UserControl
    {
        public ControlPilot()
        {
            InitializeComponent();
        }

        /// <summary>Binds pilot data to the control: name, rank, stamina, portrait image.</summary>
        public void Bind(Pilot pilot)
        {
            if (pilot == null)
                return;
            PilotName.Text = pilot.Name;
            PilotRank.Text = FormatRank(pilot.Rank);
            PilotStaminaValue.Text = pilot.StaminaCurrent.ToString();
            PilotPortrait.Image = LoadPortrait(pilot.Portrait);
        }

        private static string FormatRank(PilotRank rank)
        {
            if (rank == DeepSpaceGladiatorsEngine.Models.PilotRank.Unknown)
                return string.Empty;
            var s = rank.ToString();
            if (string.IsNullOrEmpty(s))
                return s;
            var result = new System.Text.StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && char.IsUpper(s[i]))
                    result.Append(' ');
                result.Append(s[i]);
            }
            return result.ToString();
        }

        private Image? LoadPortrait(string? path)
        {
            var old = PilotPortrait.Image;
            PilotPortrait.Image = null;
            old?.Dispose();
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
                return null;
            try
            {
                return Image.FromFile(path);
            }
            catch
            {
                return null;
            }
        }
    }
}
