namespace TheSovereignsCrown
{
    partial class Options
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
            MapBTN = new Button();
            CloseBTN = new Button();
            OptionsLBL = new Label();
            EndGameBTN = new Button();
            SuspendLayout();
            // 
            // MapBTN
            // 
            MapBTN.Anchor = AnchorStyles.None;
            MapBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MapBTN.BackColor = Color.Black;
            MapBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            MapBTN.ForeColor = Color.Goldenrod;
            MapBTN.Location = new Point(863, 503);
            MapBTN.Name = "MapBTN";
            MapBTN.Size = new Size(232, 64);
            MapBTN.TabIndex = 2;
            MapBTN.Text = "Map";
            MapBTN.UseVisualStyleBackColor = false;
            MapBTN.Click += MapBTN_Click;
            // 
            // CloseBTN
            // 
            CloseBTN.Anchor = AnchorStyles.None;
            CloseBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseBTN.BackColor = Color.Black;
            CloseBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CloseBTN.ForeColor = Color.Goldenrod;
            CloseBTN.Location = new Point(863, 782);
            CloseBTN.Name = "CloseBTN";
            CloseBTN.Size = new Size(232, 64);
            CloseBTN.TabIndex = 3;
            CloseBTN.Text = "Close";
            CloseBTN.UseVisualStyleBackColor = false;
            CloseBTN.Click += CloseBTN_Click;
            // 
            // OptionsLBL
            // 
            OptionsLBL.Anchor = AnchorStyles.None;
            OptionsLBL.AutoSize = true;
            OptionsLBL.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            OptionsLBL.ForeColor = Color.Goldenrod;
            OptionsLBL.Location = new Point(831, 9);
            OptionsLBL.Name = "OptionsLBL";
            OptionsLBL.Size = new Size(287, 89);
            OptionsLBL.TabIndex = 4;
            OptionsLBL.Text = "Options";
            // 
            // EndGameBTN
            // 
            EndGameBTN.Anchor = AnchorStyles.None;
            EndGameBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EndGameBTN.BackColor = Color.Black;
            EndGameBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            EndGameBTN.ForeColor = Color.Goldenrod;
            EndGameBTN.Location = new Point(863, 886);
            EndGameBTN.Name = "EndGameBTN";
            EndGameBTN.Size = new Size(232, 64);
            EndGameBTN.TabIndex = 5;
            EndGameBTN.Text = "Close Game";
            EndGameBTN.UseVisualStyleBackColor = false;
            EndGameBTN.Click += EndGameBTN_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2000, 1227);
            Controls.Add(EndGameBTN);
            Controls.Add(OptionsLBL);
            Controls.Add(CloseBTN);
            Controls.Add(MapBTN);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Options";
            Text = "Character Confirmation";
            WindowState = FormWindowState.Maximized;
            KeyUp += Options_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MapBTN;
        private Button CloseBTN;
        private Label OptionsLBL;
        private Button EndGameBTN;
    }
}