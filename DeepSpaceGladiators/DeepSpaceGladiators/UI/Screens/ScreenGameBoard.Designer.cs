namespace DeepSpaceGladiators.UI.Screens
{
    partial class ScreenGameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PlayerPilot = new DeepSpaceGladiators.UI.Controls.ControlPilot();
            ComputerPilot = new DeepSpaceGladiators.UI.Controls.ControlPilot();
            SuspendLayout();
            // 
            // PlayerPilot
            // 
            PlayerPilot.BackColor = Color.WhiteSmoke;
            PlayerPilot.Location = new Point(12, 12);
            PlayerPilot.Name = "PlayerPilot";
            PlayerPilot.Size = new Size(273, 244);
            PlayerPilot.TabIndex = 0;
            // 
            // ComputerPilot
            // 
            ComputerPilot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ComputerPilot.BackColor = Color.WhiteSmoke;
            ComputerPilot.Location = new Point(1635, 12);
            ComputerPilot.Name = "ComputerPilot";
            ComputerPilot.Size = new Size(273, 244);
            ComputerPilot.TabIndex = 1;
            // 
            // ScreenGameBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1920, 1080);
            Controls.Add(ComputerPilot);
            Controls.Add(PlayerPilot);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "ScreenGameBoard";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ScreenGameBoard";
            ResumeLayout(false);
        }

        #endregion

        private Controls.ControlPilot PlayerPilot;
        private Controls.ControlPilot ComputerPilot;
    }
}