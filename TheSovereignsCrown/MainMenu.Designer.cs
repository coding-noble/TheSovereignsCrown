namespace TheSovereignsCrown
{
    partial class MainMenu
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
            mainMenuTitle = new Label();
            newGameBTN = new Button();
            loadGameBTN = new Button();
            informationBTN = new Button();
            quitGameBTN = new Button();
            SuspendLayout();
            // 
            // mainMenuTitle
            // 
            mainMenuTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mainMenuTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            mainMenuTitle.ForeColor = Color.Goldenrod;
            mainMenuTitle.Location = new Point(148, 418);
            mainMenuTitle.Name = "mainMenuTitle";
            mainMenuTitle.Size = new Size(1552, 59);
            mainMenuTitle.TabIndex = 0;
            mainMenuTitle.Text = "The Sovereign's Crown";
            mainMenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newGameBTN
            // 
            newGameBTN.Anchor = AnchorStyles.None;
            newGameBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            newGameBTN.BackColor = Color.Black;
            newGameBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            newGameBTN.ForeColor = Color.Goldenrod;
            newGameBTN.Location = new Point(801, 518);
            newGameBTN.Name = "newGameBTN";
            newGameBTN.Size = new Size(232, 64);
            newGameBTN.TabIndex = 1;
            newGameBTN.Text = "New Game";
            newGameBTN.UseVisualStyleBackColor = false;
            newGameBTN.Click += newGameBTN_Click;
            // 
            // loadGameBTN
            // 
            loadGameBTN.Anchor = AnchorStyles.None;
            loadGameBTN.BackColor = Color.Black;
            loadGameBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            loadGameBTN.ForeColor = Color.Goldenrod;
            loadGameBTN.Location = new Point(801, 588);
            loadGameBTN.Name = "loadGameBTN";
            loadGameBTN.Size = new Size(232, 64);
            loadGameBTN.TabIndex = 2;
            loadGameBTN.Text = "Load Game";
            loadGameBTN.UseVisualStyleBackColor = false;
            // 
            // informationBTN
            // 
            informationBTN.Anchor = AnchorStyles.None;
            informationBTN.BackColor = Color.Black;
            informationBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            informationBTN.ForeColor = Color.Goldenrod;
            informationBTN.Location = new Point(801, 658);
            informationBTN.Name = "informationBTN";
            informationBTN.Size = new Size(232, 64);
            informationBTN.TabIndex = 3;
            informationBTN.Text = "Information";
            informationBTN.UseVisualStyleBackColor = false;
            informationBTN.Click += informationBTN_Click;
            // 
            // quitGameBTN
            // 
            quitGameBTN.Anchor = AnchorStyles.None;
            quitGameBTN.BackColor = Color.Black;
            quitGameBTN.FlatAppearance.BorderColor = Color.Gold;
            quitGameBTN.FlatAppearance.BorderSize = 10;
            quitGameBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            quitGameBTN.ForeColor = Color.Goldenrod;
            quitGameBTN.Location = new Point(801, 728);
            quitGameBTN.Name = "quitGameBTN";
            quitGameBTN.Size = new Size(232, 64);
            quitGameBTN.TabIndex = 4;
            quitGameBTN.Text = "Quit Game";
            quitGameBTN.UseVisualStyleBackColor = false;
            quitGameBTN.Click += quitGameBTN_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1871, 1269);
            Controls.Add(quitGameBTN);
            Controls.Add(informationBTN);
            Controls.Add(loadGameBTN);
            Controls.Add(newGameBTN);
            Controls.Add(mainMenuTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenu";
            ShowIcon = false;
            Text = "The Sovereign's Crown Main Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Label mainMenuTitle;
        private Button newGameBTN;
        private Button loadGameBTN;
        private Button informationBTN;
        private Button quitGameBTN;
    }
}
