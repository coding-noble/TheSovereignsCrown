using System.Text.Json;

namespace TheSovereignsCrown
{
    public partial class CharacterCreation : Form
    {
        public CharacterCreation()
        {
            InitializeComponent();
        }

        public void BackBTN_Click(object sender, EventArgs e)
        {
            Program.mainMenu.Show();
            this.Close();
        }

        private void ClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassErrorLBL.Visible = false;
            BackgroundCB.Enabled = (ClassCB.SelectedItem != null);

            if (ClassCB.SelectedItem is string selectedClass)
            {
                BackgroundCB.Items.Clear();
                BackgroundCB.SelectedItem = null;

                JsonElement classDescriptions = Utilities.NarrativesJsonRoot.GetProperty("class-descriptions");

                ClassDescriptionLBL.Text = classDescriptions
                    .GetProperty(Utilities.JsonPropertyFormatter(selectedClass))
                    .GetProperty("description").GetString();

                JsonElement backgroundOptions = classDescriptions
                    .GetProperty(Utilities.JsonPropertyFormatter(selectedClass))
                    .GetProperty("backgrounds");

                foreach (JsonElement background in backgroundOptions.EnumerateArray())
                {
                    BackgroundCB.Items.Add(background);
                }
            }
        }

        private void BackgroundCB_TextChanged(object sender, EventArgs e)
        {
            BackgroundErrorLBL.Visible = false;
            if (ClassCB.SelectedItem is string selectedClass && BackgroundCB.Text is string selectedBackground)
            {
                BackgroundDescriptionLBL.Text = Utilities.NarrativesJsonRoot
                    .GetProperty("class-descriptions")
                    .GetProperty(Utilities.JsonPropertyFormatter(selectedClass))
                    .GetProperty("background-descriptions")
                    .GetProperty(Utilities.JsonPropertyFormatter(selectedBackground))
                    .GetString();
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {
            ClassCB.SelectedIndex = -1;
            BackgroundCB.SelectedIndex = -1;
            ClassDescriptionLBL.Text = "Please select a class to learn more about it.";
            BackgroundDescriptionLBL.Text = "You must select a class before a background.";
            NameInput.Clear();
            MaleRB.Checked = false;
            FemaleRB.Checked = false;
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            if (RunValidation())
            {
                CharacterConfirmation characterConfirmation = new CharacterConfirmation(this);
                characterConfirmation.Show();
            }
        }

        private bool RunValidation()
        {
            bool validationResult = true;

            // Validate Name Input
            NameErrorLBL.Visible = string.IsNullOrEmpty(NameInput.Text);
            validationResult &= !NameErrorLBL.Visible;

            // Validate Gender Selection
            GenderErrorLBL.Visible = !(MaleRB.Checked || FemaleRB.Checked);
            validationResult &= !GenderErrorLBL.Visible;

            // Validate Class Selection
            ClassErrorLBL.Visible = ClassCB.SelectedItem == null;
            validationResult &= !ClassErrorLBL.Visible;

            // Validate Background Selection
            BackgroundErrorLBL.Visible = BackgroundCB.SelectedItem == null;
            validationResult &= !BackgroundErrorLBL.Visible;

            return validationResult;
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            NameErrorLBL.Visible = false;
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            GenderErrorLBL.Visible = false;
        }

        public string GetName()
        {
            return NameInput.Text;
        }

        public string GetGender()
        {
            return MaleRB.Checked ? "Male" : "Female";
        }

        public string? GetClass()
        {
            return ClassCB.SelectedItem as string;
        }

        public string? GetBackground()
        {
            return BackgroundCB.Text;
        }
    }
}
