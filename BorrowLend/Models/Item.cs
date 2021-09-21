using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BorrowLend.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name ="Item name")]
        public string ItemName { get; set; }
        [Required]
        public string Borrower { get; set; }
        [Required]
        public string Lender { get; set; }


    }
}
