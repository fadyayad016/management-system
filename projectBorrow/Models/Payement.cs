using Project_ManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBorrow.Models
{
  public class Payement
    {
        public int ID { get; set; }
        public float AmountToPay { get; set; }
        public DateTime DateOfPayement { get; set;}
        [ForeignKey("Customer")]
        public string SND { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
