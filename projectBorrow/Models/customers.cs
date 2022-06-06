using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ManagmentSystem.Models
{
    public class Customer
    {
        [Key]
        public string SND { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string warranty { get; set; }
        public int TypePremium { get; set; }

    }
}
