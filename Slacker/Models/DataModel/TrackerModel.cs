using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Slacker.Models.DataModel
{

    public class FinancialTracker
    {
        public long TransactionId { get; set; }

        [Display(Name = "Amount")]
        public int InputValue { get; set; }

        public DateTime CurrentDate { get; set; }
        [Display(Name = "Status")]
        public string SpentGainedStatus { get; set; }
        [Display(Name = "Source")]
        public string SpentGainedSource { get; set; }
        ApplicationContext db = new ApplicationContext();
   
        FinancialTracker y = db
        public List<FinancialTrackerViewModel> FinTrList = new List<FinancialTrackerViewModel>();

    }

    public class FinancialTrackerViewModel
    {
        public long TransactionId { get; set; }

        [Display(Name = "Amount")]
        public int InputValue { get; set; }

        public DateTime CurrentDate { get; set; }
        [Display(Name = "Status")]
        public string SpentGainedStatus { get; set; }
        [Display(Name = "Source")]
        public string SpentGainedSource { get; set; }
    }

    public class FinancialTrackerEditViewModel
    {        
        
 
        public long TransactionId { get; set; }

        [Display(Name = "Amount")]
        public int InputValue { get; set; }

        public DateTime CurrentDate { get; set; }
        [Display(Name = "Status")]
        public string SpentGainedStatus { get; set; }
        [Display(Name = "Source")]
        public string SpentGainedSource { get; set; }
    }


}
