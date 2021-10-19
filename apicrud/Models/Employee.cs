using System;
using System.ComponentModel.DataAnnotations;
namespace apicrud.Models
{
    public class Employee
    {

        [Key]
        public Guid Id { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage ="Name can only be 50 characters long")]
        public String Name { get; set; }

        [Required]
        public String Image { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public String Department { get; set; }

        [Required]
        public int Values { get; set; }

        [Required]
        public int Paid { get; set; }

        [Required]
        public String Symbol { get; set; }

        [Required]
        public String Lastpayment { get; set; }

        [Required]
        public String Type { get; set; }

        [Required]
        public String Status { get; set; }

        [Required]
        public String imageFile { get; set;  }


    }
}
