using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTermProject.BusinessLogic
{
    public class CleaningPlanManager
    {

        List<CleaningPlan> cleaningPlans = new List<CleaningPlan>();

        public CleaningPlanManager()
        {
            cleaningPlans.Add(new CleaningPlan(planId: 1, planTypeIcon: "badge_bronze.png", planImageFileName: "preview_window.jpg", price: 199.99, service1: "Window cleaning", service2: "", service3: ""));
            cleaningPlans.Add(new CleaningPlan(planId: 2, planTypeIcon: "badge_silver.png", planImageFileName: "preview_carpet.png", price: 399.99, service1: "Window cleaning", service2: "Carpet cleaning", service3: ""));
            cleaningPlans.Add(new CleaningPlan(planId: 3, planTypeIcon: "badge_gold.png", planImageFileName: "preview_power_washing.jpeg", price: 599.99, service1: "Window cleaning", service2: "Carpet cleaning", service3: "Power washing" ));
        }
        public List<CleaningPlan> GetCleaningPlans()
        {
            return cleaningPlans;
        }
    }
}
