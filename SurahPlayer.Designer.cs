namespace Quran_Player
{
    partial class SurahPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurahPlayer));
            surahNameLabel = new Label();
            SuspendLayout();
            // 
            // surahNameLabel
            // 
            surahNameLabel.BackColor = Color.Transparent;
            surahNameLabel.Font = new Font("KFGQPC Uthmanic Script HAFS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            surahNameLabel.ForeColor = SystemColors.ButtonFace;
            surahNameLabel.Location = new Point(349, 9);
            surahNameLabel.Name = "surahNameLabel";
            surahNameLabel.Size = new Size(359, 169);
            surahNameLabel.TabIndex = 0;
            // 
            // SurahPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._343a40;
            ClientSize = new Size(800, 368);
            Controls.Add(surahNameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SurahPlayer";
            Text = "SurahPlayer";
            Load += SurahPlayer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label surahNameLabel;
    }
}