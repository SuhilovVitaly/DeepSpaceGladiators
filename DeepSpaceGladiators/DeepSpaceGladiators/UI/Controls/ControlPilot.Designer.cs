namespace DeepSpaceGladiators.UI.Controls
{
    partial class ControlPilot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PilotName = new Label();
            PilotStaminaLabel = new Label();
            PilotStaminaValue = new Label();
            PilotRank = new Label();
            PilotPortrait = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PilotPortrait).BeginInit();
            SuspendLayout();
            // 
            // PilotName
            // 
            PilotName.Dock = DockStyle.Top;
            PilotName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PilotName.Location = new Point(0, 0);
            PilotName.Name = "PilotName";
            PilotName.Size = new Size(273, 37);
            PilotName.TabIndex = 0;
            PilotName.Text = "Pilot Name";
            PilotName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PilotStaminaLabel
            // 
            PilotStaminaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PilotStaminaLabel.Location = new Point(101, 95);
            PilotStaminaLabel.Name = "PilotStaminaLabel";
            PilotStaminaLabel.Size = new Size(124, 25);
            PilotStaminaLabel.TabIndex = 1;
            PilotStaminaLabel.Text = "Stamina";
            PilotStaminaLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // PilotStaminaValue
            // 
            PilotStaminaValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PilotStaminaValue.Location = new Point(231, 95);
            PilotStaminaValue.Name = "PilotStaminaValue";
            PilotStaminaValue.Size = new Size(38, 25);
            PilotStaminaValue.TabIndex = 2;
            PilotStaminaValue.Text = "6";
            // 
            // PilotRank
            // 
            PilotRank.Dock = DockStyle.Top;
            PilotRank.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PilotRank.Location = new Point(0, 37);
            PilotRank.Name = "PilotRank";
            PilotRank.Size = new Size(273, 32);
            PilotRank.TabIndex = 3;
            PilotRank.Text = "Rank";
            PilotRank.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PilotPortrait
            // 
            PilotPortrait.Location = new Point(14, 72);
            PilotPortrait.Name = "PilotPortrait";
            PilotPortrait.Size = new Size(125, 155);
            PilotPortrait.TabIndex = 4;
            PilotPortrait.TabStop = false;
            // 
            // ControlPilot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PilotPortrait);
            Controls.Add(PilotRank);
            Controls.Add(PilotStaminaValue);
            Controls.Add(PilotStaminaLabel);
            Controls.Add(PilotName);
            Name = "ControlPilot";
            Size = new Size(273, 244);
            ((System.ComponentModel.ISupportInitialize)PilotPortrait).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label PilotName;
        private Label PilotStaminaLabel;
        private Label PilotStaminaValue;
        private Label PilotRank;
        private PictureBox PilotPortrait;
    }
}
