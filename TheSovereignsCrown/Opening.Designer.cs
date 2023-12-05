namespace TheSovereignsCrown
{
    partial class Opening
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
            ContinueLBL = new Label();
            DescriptionBox = new Label();
            BackstoryLBL = new Label();
            SuspendLayout();
            // 
            // ContinueLBL
            // 
            ContinueLBL.Anchor = AnchorStyles.None;
            ContinueLBL.AutoSize = true;
            ContinueLBL.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ContinueLBL.ForeColor = Color.Goldenrod;
            ContinueLBL.Location = new Point(755, 1191);
            ContinueLBL.Name = "ContinueLBL";
            ContinueLBL.Size = new Size(287, 30);
            ContinueLBL.TabIndex = 0;
            ContinueLBL.Text = "Press [ENTER] To Continue";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Font = new Font("Segoe UI", 16F);
            DescriptionBox.ForeColor = Color.Goldenrod;
            DescriptionBox.Location = new Point(37, 147);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(1800, 1004);
            DescriptionBox.TabIndex = 1;
            DescriptionBox.Text = "Filler";
            DescriptionBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackstoryLBL
            // 
            BackstoryLBL.Anchor = AnchorStyles.None;
            BackstoryLBL.AutoSize = true;
            BackstoryLBL.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            BackstoryLBL.ForeColor = Color.Goldenrod;
            BackstoryLBL.Location = new Point(734, 20);
            BackstoryLBL.Name = "BackstoryLBL";
            BackstoryLBL.Size = new Size(348, 89);
            BackstoryLBL.TabIndex = 2;
            BackstoryLBL.Text = "Backstory";
            // 
            // Opening
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1871, 1230);
            Controls.Add(BackstoryLBL);
            Controls.Add(DescriptionBox);
            Controls.Add(ContinueLBL);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Opening";
            Text = "Opening";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ContinueLBL;
        private Label DescriptionBox;
        private Label BackstoryLBL;
    }
}