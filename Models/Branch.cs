using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaPark.Models
{
    public class Branch
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public string BranchLocation { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
