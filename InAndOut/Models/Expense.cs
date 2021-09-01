using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }

        [DisplayName("Amount")]
        [Required]
        [Range(1,int.MaxValue , ErrorMessage ="Amount Must be Greater than 0")]
        public int Amount { get; set; }

    }
}
