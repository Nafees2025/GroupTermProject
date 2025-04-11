using GroupTermProject.BusinessLogic;
namespace GroupTermProject;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        FirstNameInput.Text = string.Empty;
        LastNameInput.Text = string.Empty;
        EmailInput.Text = string.Empty;
        PasswordInput.Text = string.Empty;
	}

    // Event handler when the user presses the create button
    private void CreateAccount_Clicked(object sender, EventArgs e)
    {

        try
        {

            // storing all the user inputs from the UI in local varibles
            string firstName = FirstNameInput.Text;
            string lastName = LastNameInput.Text;
            string email = EmailInput.Text;
            string password = PasswordInput.Text;
            bool newsLetterSubscription = NewsLetterSubscription.IsChecked;

            if ((firstName == "") || (lastName == "") || (email == "") || (password == ""))
            {
                throw new Exception();
            }

            // Creating a userInfo object with the account information the user gives in the UI
            UserInformation userInfo = new UserInformation(firstName, lastName, email, password, newsLetterSubscription, true);

            // displaying a message saying that the account has been created
            DisplayAlert("Account Created", "Your account has been created!", "Ok");

            FirstNameInput.Text = "";
            LastNameInput.Text = "";
            EmailInput.Text = "";
            PasswordInput.Text = "";
            NewsLetterSubscription.IsChecked = false;

            Shell.Current.GoToAsync("//HomePage");

        }

        // catch message
        catch (Exception ex)
        {
            DisplayAlert("Error Message", "You have not entered all the information needed.. Try again", "Ok");
        }
    }


    // Event handler for when the user clicks the Home Page button
    private void HomeButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//HomePage");
    }

    // Event handler for twhen the user clicks the Service Plans button
    private void ServicePlanButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ChooseService");
    }
}