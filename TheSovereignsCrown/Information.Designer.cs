namespace TheSovereignsCrown
{
    partial class Information
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
            CloseBTN = new Button();
            SuspendLayout();
            // 
            // CloseBTN
            // 
            CloseBTN.Anchor = AnchorStyles.None;
            CloseBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CloseBTN.BackColor = Color.Black;
            CloseBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CloseBTN.ForeColor = Color.Goldenrod;
            CloseBTN.Location = new Point(831, 1087);
            CloseBTN.Name = "CloseBTN";
            CloseBTN.Size = new Size(232, 64);
            CloseBTN.TabIndex = 2;
            CloseBTN.Text = "Close";
            CloseBTN.UseVisualStyleBackColor = false;
            CloseBTN.Click += CloseBTN_Click;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1940, 1210);
            Controls.Add(CloseBTN);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Information";
            Text = "Character Confirmation";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button CloseBTN;
    }
}