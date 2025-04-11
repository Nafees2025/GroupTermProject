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
        InitializeComponent();
        cleaningPlans = cleaningPlanManager.GetCleaningPlans();
        cleaningPlanList = new ObservableCollection<CleaningPlan>(cleaningPlans);
        PlanListView.ItemsSource = cleaningPlanList;
    }

    public void PlanListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

            CleaningPlan plan = PlanListView.SelectedItem as CleaningPlan;
            planImage.Source = plan.PlanImageFileName;

    }

    public void ChoosePlan_Clicked(object sender, EventArgs e)
    {

        if (UserInformation.VerifyAccountCreated == true)
        {
            CleaningPlan plan = PlanListView.SelectedItem as CleaningPlan;

            if (plan == null)
            {
                DisplayAlert("Service Error", "No service plan was picked", "Ok");
            }
            else
            {
                try
                {
                    Shell.Current.GoToAsync("//HomePage");
                    DisplayAlert("Service Choise Confermation", "Your service choise has been condirmed. Thank You!", "Ok");
                    Shell.Current.GoToAsync("//PaymentInformation");
                }
                catch (Exception ex)
                {
                    DisplayAlert("Error Message", "There was an error", "Ok");
                }
            }
        }
        else
        {
            DisplayAlert("Error", "Account already created", "Ok");
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