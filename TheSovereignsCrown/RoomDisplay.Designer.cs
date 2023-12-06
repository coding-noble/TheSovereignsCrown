namespace TheSovereignsCrown
{
    partial class RoomDisplay
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
            LocationDisplayLBL = new Label();
            SuspendLayout();
            // 
            // LocationDisplayLBL
            // 
            LocationDisplayLBL.AutoSize = true;
            LocationDisplayLBL.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            LocationDisplayLBL.ForeColor = Color.Goldenrod;
            LocationDisplayLBL.Location = new Point(12, 9);
            LocationDisplayLBL.Name = "LocationDisplayLBL";
            LocationDisplayLBL.Size = new Size(308, 89);
            LocationDisplayLBL.TabIndex = 3;
            LocationDisplayLBL.Text = "Location";
            // 
            // RoomDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2017, 1227);
            Controls.Add(LocationDisplayLBL);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoomDisplay";
            Text = "Character Confirmation";
            WindowState = FormWindowState.Maximized;
            Load += RoomDisplay_Load;
            KeyUp += RoomDisplay_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LocationDisplayLBL;
    }
}