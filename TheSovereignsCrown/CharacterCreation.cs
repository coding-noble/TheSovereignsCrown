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

            string? selectedClass = ClassCB.SelectedItem as string;
            BackgroundCB.Items.Clear();
            BackgroundCB.SelectedItem = null;

            switch (selectedClass)
            {
                case "Courtly scion":
                    ClassDescriptionLBL.Text = "A Courtly Scion is born into nobility, raised in opulence, and groomed for the complexities of courtly life. They inherit titles, privileges, and connections, excelling in the art of diplomacy and navigating the intricate social structures of high society. Trained in etiquette, they possess a refined demeanor, strategic wit, and access to resources that influence the court's power plays.";
                    BackgroundCB.Items.AddRange(new string[] {
                        "Courtly Favor and Hidden Rivalries",
                        "Securing the Succession",
                        "Disinherited Heir"
                    });
                    break;
                case "Humble Beginnings":
                    ClassDescriptionLBL.Text = "Those with Humble Beginnings come from modest backgrounds, devoid of noble lineage or wealth. Their upbringing is marked by struggle and resilience, navigating life's challenges through hard work, resourcefulness, and community support. Despite lacking the advantages of nobility, they embody determination, empathy, and a profound connection to the common folk, earning respect through their perseverance and down-to-earth nature.";
                    BackgroundCB.Items.AddRange(new string[] {
                        "Champion of the Common Folk",
                        "Outcast Survivor",
                        "Undercover Rebel"
                    });
                    break;
                case "Faux Blue Blood":
                    ClassDescriptionLBL.Text = "The Faux Blue Blood emerges as a commoner masquerading as nobility, donning a fabricated lineage and adopting the trappings of aristocracy. They weave a web of deception, maneuvering through courts and social circles while concealing their true origins. Their intelligence, adaptability, and knack for espionage or manipulation allow them to seamlessly blend into elite circles, harboring secrets while playing a dangerous game of pretense.";
                    BackgroundCB.Items.AddRange(new string[] {
                        "Intrigue-riddled Courtier",
                        "Aspiring Scholar/Artisan",
                        "Undercover Rebel"
                    });
                    break;
                case "Covert Lineage":
                    ClassDescriptionLBL.Text = "Those with a Covert Lineage possess hidden noble roots concealed beneath the veneer of commonality. Raised as commoners without knowledge of their true heritage, they embark on a journey to uncover their hidden lineage. Their quest for identity and the revelation of their noble roots drive them to navigate the worlds of both nobility and commoners, facing challenges of dual identity while striving to reclaim their rightful place.";
                    BackgroundCB.Items.AddRange(new string[] {
                        "Heritage Unveiled"
                    });
                    break;
                default:
                    ClassDescriptionLBL.Text = "Please select a class to learn more about it.";
                    break;
            }
        }

        private void BackgroundCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackgroundErrorLBL.Visible = false;
            string? selectedClass = ClassCB.SelectedItem as string;
            string? selectedBackground = BackgroundCB.SelectedItem as string;

            if (selectedClass == "Courtly scion")
            {
                switch (selectedBackground)
                {
                    case "Courtly Favor and Hidden Rivalries":
                        BackgroundDescriptionLBL.Text = "Navigating the intricate courtly realm, mastering the delicate art of securing allies while uncovering clandestine adversaries. Skillfully wielding influence in a web of alliances, concealing tensions beneath an elegant façade of cooperation.";
                        break;
                    case "Securing the Succession":
                        BackgroundDescriptionLBL.Text = "Engaging in political maneuvering, strategizing to cement a rightful claim to inheritance or ascendancy. Delving into intrigues, forming alliances, and skillfully positioning oneself in the line of succession amidst rival contenders.";
                        break;
                    case "Disinherited Heir":
                        BackgroundDescriptionLBL.Text = "Deprived of rightful inheritance, navigating a path to carve a new legacy. Seeking opportunities to prove worthiness, forging an independent destiny, and aiming to leave a mark beyond the shadow of a lost lineage.";
                        break;
                    default:
                        BackgroundDescriptionLBL.Text = "Description for the selected background is not available.";
                        break;
                }
            }
            else if (selectedClass == "Humble Beginnings")
            {
                switch (selectedBackground)
                {
                    case "Paradigm Challenger":
                        BackgroundDescriptionLBL.Text = "Embracing a life dedicated to challenging societal norms, advocating for change, and breaking down barriers. A paradigm challenger seeks to reshape existing constructs, fostering inclusivity, and championing diversity in pursuit of a more just and open-minded society.";
                        break;
                    case "Rise from Humble Beginnings":
                        BackgroundDescriptionLBL.Text = "Ascending from modest origins, overcoming early hardships with determination, and carving a path towards success through relentless perseverance. Starting with limited resources, showcasing resilience, and embodying the victory of self-made accomplishments.";
                        break;
                    case "Champion of the Common Folk":
                        BackgroundDescriptionLBL.Text = "Becoming an advocate for the marginalized and underprivileged, fighting for the rights and dignity of everyday individuals. Standing against inequality, offering assistance and inspiration to those in need, and working towards community empowerment.";
                        break;
                    case "Outcast Survivor":
                        BackgroundDescriptionLBL.Text = "Enduring social exclusion, navigating life's challenges as an outsider, and triumphing over adversity with resilience and individuality. Transforming isolation into strength, embracing uniqueness, and forging an unconventional path towards acceptance.";
                        break;
                    case "Aspiring Scholar/Artisan":
                        BackgroundDescriptionLBL.Text = "Pursuing intellectual or artistic passions despite limited opportunities, striving for excellence in academia or artistic pursuits, and seeking self-improvement through dedicated pursuit of knowledge or mastery of a creative craft.";
                        break;
                    case "Undercover Rebel":
                        BackgroundDescriptionLBL.Text = "Navigating societal norms while subtly challenging established systems or norms from within. Balancing between conformity and dissent, harboring unconventional perspectives while strategically operating within traditional boundaries.";
                        break;
                    default:
                        BackgroundDescriptionLBL.Text = "Description for the selected background is not available.";
                        break;
                }
            }
            else if (selectedClass == "Faux Blue Blood")
            {
                switch (selectedBackground)
                {
                    case "Courtly Favor and Hidden Rivalries":
                        BackgroundDescriptionLBL.Text = "Navigating the intricate courtly realm, adeptly securing alliances while uncovering hidden adversaries. Skilled in wielding influence within a web of alliances, concealing tensions beneath a sophisticated guise of cooperation.";
                        break;
                    case "Securing the Succession":
                        BackgroundDescriptionLBL.Text = "Engaged in strategic political maneuvering, vying for rightful inheritance or ascendancy. Delving into intrigues, forming alliances, and skillfully positioning amidst rival contenders competing for succession.";
                        break;
                    case "Intrigue-riddled Courtier":
                        BackgroundDescriptionLBL.Text = "Immersed in the labyrinth of courtly intrigues, entangled in webs of secrets, spies, and clandestine dealings. Proficient in espionage, deciphering hidden motives, and playing a crucial role within a tangled political landscape.";
                        break;
                    case "Aspiring Scholar/Artisan":
                        BackgroundDescriptionLBL.Text = "Striving for academic or artistic excellence within limited aristocratic avenues. Endeavoring to elevate through dedication to scholarship or mastery of an art form despite social constraints.";
                        break;
                    case "Undercover Rebel":
                        BackgroundDescriptionLBL.Text = "Striking a balance between noble birth and covert insurgency, masking true intentions while challenging established norms from within. Juggling between conformity and dissent, harboring unconventional beliefs amidst aristocratic society.";
                        break;
                    case "Dual Identity Diplomat":
                        BackgroundDescriptionLBL.Text = "Operating with dual personas, navigating the aristocratic realm while concealing a separate identity. Skillfully negotiating diplomatic circles, wielding influence through astute diplomatic strategies while safeguarding hidden affiliations or allegiances.";
                        break;
                    default:
                        BackgroundDescriptionLBL.Text = "Description for the selected background is not available.";
                        break;
                }
            }
            else if (selectedClass == "Covert Lineage")
            {
                switch (selectedBackground)
                {
                    case "Concealed Legacy":
                        BackgroundDescriptionLBL.Text = "Unaware of aristocratic lineage, raised in obscurity among common folk, until encountering clues hinting at a hidden noble heritage. Initiating a quest to uncover the obscured family legacy, grappling with the implications of a dual identity.";
                        break;
                    case "Heritage Unveiled":
                        BackgroundDescriptionLBL.Text = "Born into anonymity, raised with a commoner's upbringing, only to later uncover a concealed noble lineage. Embarking on a quest to unravel the hidden truth of aristocratic ancestry, navigating challenges of identity and societal expectations.";
                        break;
                    case "Disdainful Disinheritance":
                        BackgroundDescriptionLBL.Text = "A commoner upbringing turns tumultuous upon the revelation of royal lineage, sparking deep-seated resentment towards aristocracy. The revelation of noble ancestry instigates a sense of betrayal and bitterness, fostering disdain towards nobility and fueling a desire to renounce the entitled heritage.";
                        break;
                    case "Ascension Ambition":
                        BackgroundDescriptionLBL.Text = "Raised as a commoner, discovering royal lineage triggers a fervent aspiration to claim rightful heritage. Despite a humble upbringing, the revelation sparks a deep longing to ascend to the noble echelons, harboring ambitions to embrace the hidden heritage and seek recognition within aristocratic realms.";
                        break;
                    default:
                        BackgroundDescriptionLBL.Text = "Description for the selected background is not available.";
                        break;
                }
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
            return BackgroundCB.SelectedItem as string;
        }
    }
}
