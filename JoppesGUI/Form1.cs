using JoppesDjurFamilj;
using JoppesDjurFamilj.Toys;

namespace JoppesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PetOwner petOwner = new();
        Animal currentSetAnimal;
        Toy currentSetToy;

        // Method for updating the display view box when needed
        private void UpdatePetsDisplay()
        {
            outputDisplay.Clear();

            foreach (var animal in petOwner.ViewAnimals())
            {
                outputDisplay.AppendText(animal.ToString());
                outputDisplay.AppendText(Environment.NewLine);
            }
        }

        // Event that updates the display view on View Toys button
        private void btnToys_Click(object sender, EventArgs e)
        {
            UpdateToysDisplay();
        }

        // Method for updating the display view box when needed
        private void UpdateToysDisplay()
        {
            int num = 0;
            outputDisplay.Clear();
            foreach (var toy in petOwner.ViewToys())
            {

                outputDisplay.AppendText("Toy " + num + ": " + toy.ToString());
                outputDisplay.AppendText(Environment.NewLine);
                num++;
            }
        }

        // Changes the inputHeader text and the PlaceholderText in the input box
        private void radiobtnInteract_CheckedChanged(object sender, EventArgs e)
        {
            inputHeader.Text = "Enter the name of the Pet you want to interact with";
            inputField.PlaceholderText = "Enter Name of Pet here";

            UpdatePetsDisplay();
        }

        // Changes the inputHeader text and the PlaceholderText in the input box
        private void radioBtnToyOpt_CheckedChanged(object sender, EventArgs e)
        {
            inputHeader.Text = "Enter the Toy number that you want to use";
            inputField.PlaceholderText = "Enter a valid option";

            UpdateToysDisplay();
        }

        // Event listener that listens for when Enter is pressed and checks which radio button is checked.
        // If the validation checks passes it will run the apropriate method that returns a string for display.
        // At the end of each block is a SupressKeyPress to avoid the noise that hitting enter makes. There is probably a better way to handle this.
        private void inputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (radiobtnInteract.Checked == true && e.KeyCode == Keys.Enter)
            {
                var pet = petOwner.InitializeInteract(inputField.Text);

                if (pet == null)
                {
                    outputMain.Text = "Could not find a Pet with that name";
                }
                else
                {
                    currentSetAnimal = pet;
                    currentPet.Text = "Current Pet: " + pet.ToString();
                    outputMain.Clear();
                }
                inputField.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (radioBtnToyOpt.Checked == true && e.KeyCode == Keys.Enter)
            {
                var toy = petOwner.SetCurrentToy(int.Parse(inputField.Text));

                if (toy == null)
                {
                    outputMain.Text = "Could not find a Toy with that number";
                }
                else
                {
                    currentSetToy = toy;
                    currentToy.Text = toy.ToString();
                    outputMain.Clear();
                }
                inputField.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (btnNewBall.Checked == true && e.KeyCode == Keys.Enter)
            {
                petOwner.MakeBall(inputField.Text);
                outputMain.Text = $"Made a ball with {inputField.Text} color";

                UpdateToysDisplay();
                inputField.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (btnRefill.Checked == true && e.KeyCode == Keys.Enter)
            {
                int amount;
                if(!int.TryParse(inputField.Text, out amount))
                {
                    outputMain.Text = "Not a valid amount";
                }
                else
                {
                    petOwner.Refill(amount);
                    outputMain.Text = $"{amount} treats has been inserted into the Treat Dispenser";

                    UpdateToysDisplay();
                    inputField.Clear();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        // When play button is clicked
        // Uses the currentSetPet and currentSetToy to run the Iteract method with chosen toy as parameter
        private void btnPlay_Click(object sender, EventArgs e)
        {
            string result;
            if(currentSetAnimal == null || currentSetToy == null)
            {
                outputMain.Text = "Please choose a Pet and a Toy first...";
            }
            else if (currentSetToy.Quality <= 0)
            {
                outputMain.Text = "That toy is broken or empty, choose another one";
            }
            else
            {
                result = currentSetAnimal.Interact(currentSetToy);

                outputMain.Text = result;
                currentToy.Text = "Current Toy: " + currentSetToy.ToString();
                UpdatePetsDisplay();
            }
        }
        // Uses the CurrentSetPet to run their Eat method on Feed button click
        private void btnFeed_Click(object sender, EventArgs e)
        {
            string result;
            if(currentSetAnimal == null)
            {
                outputMain.Text = "Please choose a Pet to Feed first...";
            }
            else
            {
                result = currentSetAnimal.Eat();

                outputMain.Text = result;
                UpdatePetsDisplay();
            }
        }
        // Changes the inputHeader text and the PlaceholderText in the input box
        private void btnNewBall_CheckedChanged(object sender, EventArgs e)
        {
            inputHeader.Text = "Enter the Color of the ball";
            inputField.PlaceholderText = "Color of Ball";
        }
        // Changes the inputHeader text and the PlaceholderText in the input box
        private void btnRefill_CheckedChanged(object sender, EventArgs e)
        {
            inputHeader.Text = "Enter an Amount to put in the Treat Dispenser";
            inputField.PlaceholderText = "Amount";
        }
        // Method for updating the display view box when needed
        private void btnAnimals_Click(object sender, EventArgs e)
        {
            UpdatePetsDisplay();
        }
    }
}