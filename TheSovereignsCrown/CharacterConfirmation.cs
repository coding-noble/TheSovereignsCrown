namespace TheSovereignsCrown
{
    public partial class CharacterConfirmation : Form
    {
        CharacterCreation CharacterCreationRef;
        private string ChosenName {  get; set; }
        private string ChosenGender { get; set; }
        private string ChosenClass { get; set; }
        private string ChosenBackground { get; set; }
        public CharacterConfirmation(CharacterCreation characterCreationRef)
        {
            InitializeComponent();
            this.CharacterCreationRef = characterCreationRef;
            ChosenName = this.CharacterCreationRef.GetName();
            ChosenGender = this.CharacterCreationRef.GetGender();
            ChosenClass = this.CharacterCreationRef.GetClass();
            ChosenBackground = this.CharacterCreationRef.GetBackground();
            OnLoad();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            GenderEnums gender = ChosenGender.Equals("Male") ? GenderEnums.Male : GenderEnums.Female;
            Program.loadedUser = new Player(ChosenName, gender, ChosenClass, ChosenBackground);
            Opening opening = new Opening();
            opening.Show();
            CharacterCreationRef.Close();
            this.Close();
        }

        private void OnLoad()
        {
            NameConfirmationLBL.Text = ChosenName;
            GenderConfirmationLBL.Text = ChosenGender;
            ClassConfirmationLBL.Text = ChosenClass;
            BackgroundConfirmationLBL.Text = ChosenBackground;
        }
    }
}
