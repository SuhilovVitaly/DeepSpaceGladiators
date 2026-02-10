namespace DeepSpaceGladiators.UI.Screens
{
    partial class ScreenMainMenu
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
            ButtonExit = new Button();
            ButtonNewGame = new Button();
            SuspendLayout();
            // 
            // ButtonExit
            // 
            ButtonExit.BackColor = Color.SeaShell;
            ButtonExit.Cursor = Cursors.Hand;
            ButtonExit.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            ButtonExit.FlatAppearance.MouseDownBackColor = Color.SeaShell;
            ButtonExit.FlatAppearance.MouseOverBackColor = Color.DarkKhaki;
            ButtonExit.FlatStyle = FlatStyle.Flat;
            ButtonExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonExit.ForeColor = Color.Black;
            ButtonExit.Location = new Point(274, 325);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(233, 65);
            ButtonExit.TabIndex = 0;
            ButtonExit.Text = "EXIT";
            ButtonExit.UseVisualStyleBackColor = false;
            ButtonExit.Click += Event_ExitGame;
            // 
            // ButtonNewGame
            // 
            ButtonNewGame.BackColor = Color.SeaShell;
            ButtonNewGame.Cursor = Cursors.Hand;
            ButtonNewGame.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            ButtonNewGame.FlatAppearance.MouseDownBackColor = Color.SeaShell;
            ButtonNewGame.FlatAppearance.MouseOverBackColor = Color.DarkKhaki;
            ButtonNewGame.FlatStyle = FlatStyle.Flat;
            ButtonNewGame.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonNewGame.ForeColor = Color.Black;
            ButtonNewGame.Location = new Point(274, 82);
            ButtonNewGame.Name = "ButtonNewGame";
            ButtonNewGame.Size = new Size(233, 65);
            ButtonNewGame.TabIndex = 0;
            ButtonNewGame.Text = "EXIT";
            ButtonNewGame.UseVisualStyleBackColor = false;
            ButtonNewGame.Click += Event_NewGame;
            // 
            // ScreenMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonNewGame);
            Controls.Add(ButtonExit);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenMainMenu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ScreenMainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonExit;
        private Button ButtonNewGame;
    }
}