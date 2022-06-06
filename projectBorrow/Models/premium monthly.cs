using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ManagmentSystem.Models
{
    public class premium_monthly
    {
        public int ID { get; set; }
        public float LoanAmount { get; set; }
        public float LoanPercentage { get; set; }
        public float TotalReturnMoney { get; set; }
        public int NumberOfMonth { get; set; }
        public float PremiumAmountMonthly { get; set; }
        public int NumberOfMonthPay { get; set; }
        public int NumberOfMonthNotPay { get; set; }
        public int StartMonth { get; set; }
        public int EndMonth { get; set; }
        public float RemainingMoney { get; set; }
        [ForeignKey("Customer")]
        public string SND { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
