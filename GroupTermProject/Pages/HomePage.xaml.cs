

namespace GroupTermProject;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    // Event handler for when the user clickes the Create Account button 
    private void CreatAccountButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//CreateAccountPage");
    }

    // Event handler for when the user clcikes the Service Plans button
    private void ServicePlansButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ChooseService");
    }

}
