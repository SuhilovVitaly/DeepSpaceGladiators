namespace DeepSpaceGladiators.UI.Screens
{
    partial class ScreenGameMenu
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
            ButtonExitToMenu = new Button();
            ButtonResume = new Button();
            SuspendLayout();
            // 
            // ButtonExitToMenu
            // 
            ButtonExitToMenu.BackColor = Color.SeaShell;
            ButtonExitToMenu.Cursor = Cursors.Hand;
            ButtonExitToMenu.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            ButtonExitToMenu.FlatAppearance.MouseDownBackColor = Color.SeaShell;
            ButtonExitToMenu.FlatAppearance.MouseOverBackColor = Color.DarkKhaki;
            ButtonExitToMenu.FlatStyle = FlatStyle.Flat;
            ButtonExitToMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonExitToMenu.ForeColor = Color.Black;
            ButtonExitToMenu.Location = new Point(274, 325);
            ButtonExitToMenu.Name = "ButtonExitToMenu";
            ButtonExitToMenu.Size = new Size(233, 65);
            ButtonExitToMenu.TabIndex = 0;
            ButtonExitToMenu.Text = "EXIT TO MENU";
            ButtonExitToMenu.UseVisualStyleBackColor = false;
            ButtonExitToMenu.Click += Event_ExitToMenu;
            // 
            // ButtonResume
            // 
            ButtonResume.BackColor = Color.SeaShell;
            ButtonResume.Cursor = Cursors.Hand;
            ButtonResume.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            ButtonResume.FlatAppearance.MouseDownBackColor = Color.SeaShell;
            ButtonResume.FlatAppearance.MouseOverBackColor = Color.DarkKhaki;
            ButtonResume.FlatStyle = FlatStyle.Flat;
            ButtonResume.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonResume.ForeColor = Color.Black;
            ButtonResume.Location = new Point(274, 75);
            ButtonResume.Name = "ButtonResume";
            ButtonResume.Size = new Size(233, 65);
            ButtonResume.TabIndex = 0;
            ButtonResume.Text = "RESUME";
            ButtonResume.UseVisualStyleBackColor = false;
            ButtonResume.Click += Event_Resume;
            // 
            // ScreenGameMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonResume);
            Controls.Add(ButtonExitToMenu);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenGameMenu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ScreenMainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonExitToMenu;
        private Button ButtonResume;
    }
}