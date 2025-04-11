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
        CleaningPlan plan = PlanListView.SelectedItem as CleaningPlan;

        if (plan == null)
        {
            return;
        }
        else
        {


            //confirmation message and return plan information
            //user.SelectedPlan = plan;
        }
    }

}