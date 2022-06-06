using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project_ManagmentSystem.Models
{
    public class premium_long
    {
        public int ID { get; set; }
        public float LoanAmount { get; set; }
        public float LoanPercentage { get; set; }
        public float PremiumAmountMonthly { get; set; }
        public int NumberOfMonthPaid{ get; set; }
        public int StartMonth { get; set; }
        [ForeignKey("Customer")]
        public string SND { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
