namespace TheSovereignsCrown
{
    partial class CharacterCreation
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
            CreationLBL = new Label();
            BackBTN = new Button();
            CreateBTN = new Button();
            ClearBTN = new Button();
            NameInput = new TextBox();
            NameLBL = new Label();
            GenderLBL = new Label();
            MaleRB = new RadioButton();
            FemaleRB = new RadioButton();
            ClassLBL = new Label();
            BackgroundLBL = new Label();
            ClassCB = new ComboBox();
            ClassDescriptionLBL = new Label();
            BackgroundCB = new ComboBox();
            BackgroundDescriptionLBL = new Label();
            NameErrorLBL = new Label();
            BackgroundErrorLBL = new Label();
            ClassErrorLBL = new Label();
            GenderErrorLBL = new Label();
            SuspendLayout();
            // 
            // CreationLBL
            // 
            CreationLBL.Anchor = AnchorStyles.None;
            CreationLBL.AutoSize = true;
            CreationLBL.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            CreationLBL.ForeColor = Color.Goldenrod;
            CreationLBL.Location = new Point(608, 73);
            CreationLBL.Name = "CreationLBL";
            CreationLBL.Size = new Size(626, 89);
            CreationLBL.TabIndex = 0;
            CreationLBL.Text = "Character Creation";
            // 
            // BackBTN
            // 
            BackBTN.Anchor = AnchorStyles.None;
            BackBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackBTN.BackColor = Color.Black;
            BackBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BackBTN.ForeColor = Color.Goldenrod;
            BackBTN.Location = new Point(587, 1118);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(232, 64);
            BackBTN.TabIndex = 2;
            BackBTN.Text = "Back";
            BackBTN.UseVisualStyleBackColor = false;
            BackBTN.Click += BackBTN_Click;
            // 
            // CreateBTN
            // 
            CreateBTN.Anchor = AnchorStyles.None;
            CreateBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreateBTN.BackColor = Color.Black;
            CreateBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            CreateBTN.ForeColor = Color.Goldenrod;
            CreateBTN.Location = new Point(1063, 1118);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(232, 64);
            CreateBTN.TabIndex = 4;
            CreateBTN.Text = "Create";
            CreateBTN.UseVisualStyleBackColor = false;
            CreateBTN.Click += CreateBTN_Click;
            // 
            // ClearBTN
            // 
            ClearBTN.Anchor = AnchorStyles.None;
            ClearBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearBTN.BackColor = Color.Black;
            ClearBTN.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ClearBTN.ForeColor = Color.Goldenrod;
            ClearBTN.Location = new Point(825, 1118);
            ClearBTN.Name = "ClearBTN";
            ClearBTN.Size = new Size(232, 64);
            ClearBTN.TabIndex = 5;
            ClearBTN.Text = "Clear";
            ClearBTN.UseVisualStyleBackColor = false;
            ClearBTN.Click += ClearBTN_Click;
            // 
            // NameInput
            // 
            NameInput.Anchor = AnchorStyles.None;
            NameInput.BackColor = Color.Black;
            NameInput.BorderStyle = BorderStyle.FixedSingle;
            NameInput.Font = new Font("Segoe UI", 24F);
            NameInput.ForeColor = Color.Goldenrod;
            NameInput.Location = new Point(246, 202);
            NameInput.Name = "NameInput";
            NameInput.PlaceholderText = "EnterName";
            NameInput.Size = new Size(241, 50);
            NameInput.TabIndex = 6;
            NameInput.TextAlign = HorizontalAlignment.Center;
            NameInput.TextChanged += NameInput_TextChanged;
            // 
            // NameLBL
            // 
            NameLBL.Anchor = AnchorStyles.None;
            NameLBL.AutoSize = true;
            NameLBL.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            NameLBL.ForeColor = Color.Goldenrod;
            NameLBL.Location = new Point(123, 202);
            NameLBL.Name = "NameLBL";
            NameLBL.Size = new Size(117, 45);
            NameLBL.TabIndex = 7;
            NameLBL.Text = "Name:";
            // 
            // GenderLBL
            // 
            GenderLBL.Anchor = AnchorStyles.None;
            GenderLBL.AutoSize = true;
            GenderLBL.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            GenderLBL.ForeColor = Color.Goldenrod;
            GenderLBL.Location = new Point(1136, 220);
            GenderLBL.Name = "GenderLBL";
            GenderLBL.Size = new Size(139, 45);
            GenderLBL.TabIndex = 9;
            GenderLBL.Text = "Gender:";
            // 
            // MaleRB
            // 
            MaleRB.Anchor = AnchorStyles.None;
            MaleRB.AutoSize = true;
            MaleRB.Font = new Font("Segoe UI", 24F);
            MaleRB.ForeColor = Color.Goldenrod;
            MaleRB.Location = new Point(1334, 220);
            MaleRB.Name = "MaleRB";
            MaleRB.Size = new Size(108, 49);
            MaleRB.TabIndex = 10;
            MaleRB.TabStop = true;
            MaleRB.Text = "Male";
            MaleRB.UseVisualStyleBackColor = true;
            MaleRB.Click += Radio_Click;
            // 
            // FemaleRB
            // 
            FemaleRB.Anchor = AnchorStyles.None;
            FemaleRB.AutoSize = true;
            FemaleRB.Font = new Font("Segoe UI", 24F);
            FemaleRB.ForeColor = Color.Goldenrod;
            FemaleRB.Location = new Point(1466, 220);
            FemaleRB.Name = "FemaleRB";
            FemaleRB.Size = new Size(140, 49);
            FemaleRB.TabIndex = 11;
            FemaleRB.TabStop = true;
            FemaleRB.Text = "Female";
            FemaleRB.UseVisualStyleBackColor = true;
            FemaleRB.Click += Radio_Click;
            // 
            // ClassLBL
            // 
            ClassLBL.Anchor = AnchorStyles.None;
            ClassLBL.AutoSize = true;
            ClassLBL.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            ClassLBL.ForeColor = Color.Goldenrod;
            ClassLBL.Location = new Point(634, 322);
            ClassLBL.Name = "ClassLBL";
            ClassLBL.Size = new Size(103, 45);
            ClassLBL.TabIndex = 9;
            ClassLBL.Text = "Class:";
            // 
            // BackgroundLBL
            // 
            BackgroundLBL.Anchor = AnchorStyles.None;
            BackgroundLBL.AutoSize = true;
            BackgroundLBL.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            BackgroundLBL.ForeColor = Color.Goldenrod;
            BackgroundLBL.Location = new Point(481, 647);
            BackgroundLBL.Name = "BackgroundLBL";
            BackgroundLBL.Size = new Size(211, 45);
            BackgroundLBL.TabIndex = 12;
            BackgroundLBL.Text = "Background:";
            // 
            // ClassCB
            // 
            ClassCB.AccessibleDescription = "";
            ClassCB.AccessibleName = "";
            ClassCB.Anchor = AnchorStyles.None;
            ClassCB.BackColor = Color.Black;
            ClassCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassCB.Font = new Font("Segoe UI", 24F);
            ClassCB.ForeColor = Color.Goldenrod;
            ClassCB.FormattingEnabled = true;
            ClassCB.Items.AddRange(new object[] { "Courtly scion", "Humble Beginnings", "Faux Blue Blood", "Covert Lineage" });
            ClassCB.Location = new Point(805, 314);
            ClassCB.Name = "ClassCB";
            ClassCB.Size = new Size(323, 53);
            ClassCB.TabIndex = 13;
            ClassCB.SelectedIndexChanged += ClassCB_SelectedIndexChanged;
            // 
            // ClassDescriptionLBL
            // 
            ClassDescriptionLBL.Anchor = AnchorStyles.None;
            ClassDescriptionLBL.Font = new Font("Segoe UI", 24F);
            ClassDescriptionLBL.ForeColor = Color.Goldenrod;
            ClassDescriptionLBL.Location = new Point(372, 397);
            ClassDescriptionLBL.Name = "ClassDescriptionLBL";
            ClassDescriptionLBL.Size = new Size(1020, 194);
            ClassDescriptionLBL.TabIndex = 14;
            ClassDescriptionLBL.Text = "Please select a class to learn more about it.";
            ClassDescriptionLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundCB
            // 
            BackgroundCB.Anchor = AnchorStyles.None;
            BackgroundCB.BackColor = Color.Black;
            BackgroundCB.DropDownStyle = ComboBoxStyle.DropDownList;
            BackgroundCB.Enabled = false;
            BackgroundCB.Font = new Font("Segoe UI", 24F);
            BackgroundCB.ForeColor = Color.Goldenrod;
            BackgroundCB.FormattingEnabled = true;
            BackgroundCB.Location = new Point(714, 639);
            BackgroundCB.Name = "BackgroundCB";
            BackgroundCB.Size = new Size(531, 53);
            BackgroundCB.TabIndex = 15;
            BackgroundCB.TextChanged += BackgroundCB_TextChanged;
            // 
            // BackgroundDescriptionLBL
            // 
            BackgroundDescriptionLBL.Anchor = AnchorStyles.None;
            BackgroundDescriptionLBL.Font = new Font("Segoe UI", 24F);
            BackgroundDescriptionLBL.ForeColor = Color.Goldenrod;
            BackgroundDescriptionLBL.Location = new Point(402, 789);
            BackgroundDescriptionLBL.Name = "BackgroundDescriptionLBL";
            BackgroundDescriptionLBL.Size = new Size(1020, 194);
            BackgroundDescriptionLBL.TabIndex = 16;
            BackgroundDescriptionLBL.Text = "You must select a class before a background.";
            BackgroundDescriptionLBL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameErrorLBL
            // 
            NameErrorLBL.Anchor = AnchorStyles.None;
            NameErrorLBL.AutoSize = true;
            NameErrorLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            NameErrorLBL.ForeColor = Color.White;
            NameErrorLBL.Location = new Point(317, 178);
            NameErrorLBL.Name = "NameErrorLBL";
            NameErrorLBL.Size = new Size(170, 21);
            NameErrorLBL.TabIndex = 17;
            NameErrorLBL.Text = "*Name Field Requierd";
            NameErrorLBL.Visible = false;
            // 
            // BackgroundErrorLBL
            // 
            BackgroundErrorLBL.Anchor = AnchorStyles.None;
            BackgroundErrorLBL.AutoSize = true;
            BackgroundErrorLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            BackgroundErrorLBL.ForeColor = Color.White;
            BackgroundErrorLBL.Location = new Point(1000, 615);
            BackgroundErrorLBL.Name = "BackgroundErrorLBL";
            BackgroundErrorLBL.Size = new Size(245, 21);
            BackgroundErrorLBL.TabIndex = 18;
            BackgroundErrorLBL.Text = "*Background Selection Requierd";
            BackgroundErrorLBL.Visible = false;
            // 
            // ClassErrorLBL
            // 
            ClassErrorLBL.Anchor = AnchorStyles.None;
            ClassErrorLBL.AutoSize = true;
            ClassErrorLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            ClassErrorLBL.ForeColor = Color.White;
            ClassErrorLBL.Location = new Point(933, 290);
            ClassErrorLBL.Name = "ClassErrorLBL";
            ClassErrorLBL.Size = new Size(195, 21);
            ClassErrorLBL.TabIndex = 19;
            ClassErrorLBL.Text = "*Class Selection Requierd";
            ClassErrorLBL.Visible = false;
            // 
            // GenderErrorLBL
            // 
            GenderErrorLBL.Anchor = AnchorStyles.None;
            GenderErrorLBL.AutoSize = true;
            GenderErrorLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            GenderErrorLBL.ForeColor = Color.White;
            GenderErrorLBL.Location = new Point(1468, 196);
            GenderErrorLBL.Name = "GenderErrorLBL";
            GenderErrorLBL.Size = new Size(138, 21);
            GenderErrorLBL.TabIndex = 20;
            GenderErrorLBL.Text = "*Gender Requierd";
            GenderErrorLBL.Visible = false;
            // 
            // CharacterCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1869, 1239);
            Controls.Add(GenderErrorLBL);
            Controls.Add(ClassErrorLBL);
            Controls.Add(BackgroundErrorLBL);
            Controls.Add(NameErrorLBL);
            Controls.Add(BackgroundDescriptionLBL);
            Controls.Add(BackgroundCB);
            Controls.Add(ClassDescriptionLBL);
            Controls.Add(ClassCB);
            Controls.Add(BackgroundLBL);
            Controls.Add(FemaleRB);
            Controls.Add(MaleRB);
            Controls.Add(ClassLBL);
            Controls.Add(GenderLBL);
            Controls.Add(NameLBL);
            Controls.Add(NameInput);
            Controls.Add(ClearBTN);
            Controls.Add(CreateBTN);
            Controls.Add(BackBTN);
            Controls.Add(CreationLBL);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CharacterCreation";
            ShowIcon = false;
            Text = "The Sovereign's Crown Main Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreationLBL;
        private Button BackBTN;
        private Button CreateBTN;
        private Button ClearBTN;
        private TextBox NameInput;
        private Label NameLBL;
        private Label GenderLBL;
        private RadioButton MaleRB;
        private RadioButton FemaleRB;
        private Label ClassLBL;
        private Label BackgroundLBL;
        private ComboBox ClassCB;
        private Label ClassDescriptionLBL;
        private ComboBox BackgroundCB;
        private Label BackgroundDescriptionLBL;
        private Label NameErrorLBL;
        private Label BackgroundErrorLBL;
        private Label ClassErrorLBL;
        private Label GenderErrorLBL;
    }
}