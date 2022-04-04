using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPark.Models
{
    public class Delivery
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Mark"), DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Mark name not be exceed 20 letters and minimum least 2 letters")]
        public string Mark { get; set; }


        [Required]
        [Display(Name = "Company"), DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Company name not be exceed 20 letters and at least 2 letters")]
        public string Company { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
