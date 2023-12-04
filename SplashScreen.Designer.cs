namespace Quran_Player
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            pictureBox1 = new PictureBox();
            surahPicker = new FlowLayoutPanel();
            searchbar = new TextBox();
            enterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._343a40;
            pictureBox1.Image = Properties.Resources.Quran_Kareem1;
            pictureBox1.Location = new Point(2, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // surahPicker
            // 
            surahPicker.AutoScroll = true;
            surahPicker.BackgroundImage = Properties.Resources._343a40;
            surahPicker.FlowDirection = FlowDirection.TopDown;
            surahPicker.Location = new Point(2, 136);
            surahPicker.Name = "surahPicker";
            surahPicker.RightToLeft = RightToLeft.No;
            surahPicker.Size = new Size(330, 343);
            surahPicker.TabIndex = 1;
            // 
            // searchbar
            // 
            searchbar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchbar.Location = new Point(135, 60);
            searchbar.Name = "searchbar";
            searchbar.PlaceholderText = "Search for a Surah";
            searchbar.Size = new Size(197, 25);
            searchbar.TabIndex = 2;
            // 
            // enterButton
            // 
            enterButton.FlatStyle = FlatStyle.Popup;
            enterButton.Location = new Point(193, 91);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(75, 25);
            enterButton.TabIndex = 0;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += EnterButton_Click;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources._343a40;
            ClientSize = new Size(334, 491);
            Controls.Add(enterButton);
            Controls.Add(searchbar);
            Controls.Add(surahPicker);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SplashScreen";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Quran";
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel surahPicker;
        private TextBox searchbar;
        private Button enterButton;
    }
}