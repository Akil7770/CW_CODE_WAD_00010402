using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPark.Models
{
    public enum Review
    {
        FiveStars, FourStars, ThreeStars, TwoStars, OneStar
    }
    public class Product
    {
        public int ProductID { get; set; }
        public int BranchID { get; set; }
        public int DeliveryID { get; set; }
        public Review? Review { get; set; }

        public Branch Branch { get; set; }
        public Delivery Delivery { get; set; }
    }
}
