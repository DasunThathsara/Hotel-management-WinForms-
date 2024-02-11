namespace Hotel_management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable maximize box
            this.MaximizeBox = false;

            // Disable minimize box
            this.MinimizeBox = false;

            // Set form border style to fixed single
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Set background image path
            string imagePath = Path.Combine(Application.StartupPath, "Images", "background_image1.jpg");

            // Check if the file exists
            if (File.Exists(imagePath))
            {
                // Load the image
                Image backgroundImage = Image.FromFile(imagePath);

                // Set the background image with Stretch layout
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackgroundImage = backgroundImage;
            }
            else
            {
                // Display a message if the file doesn't exist
                MessageBox.Show("Background image not found!");
            }



        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UserID_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user_id = UserIDTextBox.Text; // Retrieve user ID from UserIDTextBox
            string password = PasswordTextBox.Text; // Retrieve password from PasswordTextBox

            if (user_id == "esoft" && password == "esoft123")
            {
                // Close the login form
                this.Hide();

                // Open the home page
                Home hp = new Home();
                hp.Closed += (s, args) => this.Close(); // Close the login form when home page is closed
                hp.Show();
            }
            else
            {
                MessageBox.Show("Invalid user ID or password");
            }
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // If the user clicks OK, close the form
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
