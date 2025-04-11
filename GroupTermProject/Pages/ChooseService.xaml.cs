using System.Collections.ObjectModel;
using GroupTermProject.BusinessLogic;

namespace GroupTermProject;

public partial class ChooseService : ContentPage
{
    CleaningPlanManager cleaningPlanManager = new CleaningPlanManager();

    List<CleaningPlan> cleaningPlans = new List<CleaningPlan>();
    ObservableCollection<CleaningPlan> cleaningPlanList;

    public ChooseService()
    {
        //Gets all the list data to display tiers
        InitializeComponent();
        cleaningPlans = cleaningPlanManager.GetCleaningPlans();
        cleaningPlanList = new ObservableCollection<CleaningPlan>(cleaningPlans);
        PlanListView.ItemsSource = cleaningPlanList;
    }

    //Event handler for user's list view selection
    public void PlanListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
            //Checks for user selection
            CleaningPlan plan = PlanListView.SelectedItem as CleaningPlan;
            planImage.Source = plan.PlanImageFileName;

    }

    //Submition button
    public void ChoosePlan_Clicked(object sender, EventArgs e)
    {
        //Verifies if the user has already created an account
        if (UserInformation.VerifyAccountCreated == true)
        {
            CleaningPlan plan = PlanListView.SelectedItem as CleaningPlan;

            //Checks first if the user has selected an item
            if (plan == null)
            {
                DisplayAlert("Service Error", "No service plan was picked", "Ok");
            }
            else
            {
                //Confirms the users selection page and brings them to the payment page
                try
                {
                    DisplayAlert("Service Choice Confirmation", "Your service choice has been confirmed. Thank You!", "Ok");
                    Shell.Current.GoToAsync("//PaymentInformation");
                }
                //If not, brings an error
                catch (Exception ex)
                {
                    DisplayAlert("Error Message", "There was an error", "Ok");
                }
            }
        }
        //If not, brings back to account creation
        else
        {
            DisplayAlert("Error", "Account has not been created, please create an account", "Ok");
            Shell.Current.GoToAsync("//CreateAccountPage");

        }
    }
     
    


    // Event handler for when the user clicks the Home Page button
    private void HomeButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//HomePage");
    }

    // Event handler for when the user clicks the Create Account button
    private void CreatAccountButton_Clicked(object sender, EventArgs e)
    {
        if (UserInformation.VerifyAccountCreated == false)
        {
            Shell.Current.GoToAsync("//CreateAccountPage");
        }
        else
        {
            DisplayAlert("Error", "Account already created", "Ok");
        }
    }
}