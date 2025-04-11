using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTermProject.BusinessLogic
{
    public class CleaningPlan
    {
        public int PlanId { get; set; }
        public string PlanImageFileName { get; set; }
        public string PlanTypeIcon { get; set; }
        public double Price { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Service3 { get; set; }
        public string ListViewInfo { get; set; }

        public CleaningPlan() { }
        public CleaningPlan(int planId, string planImageFileName, string planTypeIcon, double price, string service1, string service2, string service3)
        {
            PlanId = planId;
            PlanImageFileName = planImageFileName;
            PlanTypeIcon = planTypeIcon;
            Price = price;
            Service1 = service1;
            Service2 = service2;
            Service3 = service3;


            ListViewInfo = $"Price: ${Price}\n{Service1}\n{Service2}\n{Service3}";
            
        }
    }
}

