using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPark.Models;

namespace MediaPark.Data
{
    public class DbInitializer
    {
        public static void Initialize(ParkContext context)
        {
            context.Database.EnsureCreated();

            // Look for any deliverys.
            if (context.Deliveries.Any())
            {
                return;   // DB has been seeded
            }


            //adding new db
            var deliveries = new Delivery[]
            {
            new Delivery{Company="Apple",Mark="Iphone 12 pro MAX",DeliveryDate=DateTime.Parse("2020-09-01")},
            new Delivery{Company="Samsung",Mark="A12",DeliveryDate=DateTime.Parse("2015-09-01")},
            new Delivery{Company="LG",Mark="LG G7+",DeliveryDate=DateTime.Parse("2016-09-01")},
            new Delivery{Company="Samsung",Mark="Samsung S23",DeliveryDate=DateTime.Parse("2026-10-10")},
            new Delivery{Company="Apple",Mark="Iphone 11 pro MAX",DeliveryDate=DateTime.Parse("2019-09-01")},
            new Delivery{Company="LG",Mark="LG Q7+",DeliveryDate=DateTime.Parse("2010-09-01")},
            new Delivery{Company="Apple",Mark="Iphone X MAX",DeliveryDate=DateTime.Parse("2018-09-01")},
            new Delivery{Company="Samsung",Mark="Samsung S20",DeliveryDate=DateTime.Parse("2005-09-01")},
            new Delivery{Company="LG",Mark="LG V30+",DeliveryDate=DateTime.Parse("2013-09-01")},
            new Delivery{Company="Apple",Mark="Iphone 8 plus",DeliveryDate=DateTime.Parse("2016-09-01")},
            new Delivery{Company="Apple",Mark="Iphone SE",DeliveryDate=DateTime.Parse("2016-09-01")},
            new Delivery{Company="LG",Mark="Descover LG Q6",DeliveryDate=DateTime.Parse("2019-09-01")},
            new Delivery{Company="Apple",Mark="Iphone 7S",DeliveryDate=DateTime.Parse("2010-09-01")},
            new Delivery{Company="Samsung",Mark="Samsung B30",DeliveryDate=DateTime.Parse("2011-09-01")},
            new Delivery{Company="LG",Mark="Descover LG G6",DeliveryDate=DateTime.Parse("2013-09-01")},
            new Delivery{Company="Samsung",Mark="Samsung A10",DeliveryDate=DateTime.Parse("2015-09-01")}
            };
            foreach (Delivery s in deliveries)
            {
                context.Deliveries.Add(s);
            }
            context.SaveChanges();


            //adding new db
            var branches = new Branch[]
            {
            new Branch{BranchID=1,BranchName="Alex Popov",BranchLocation="11 Qoratosh"},
            new Branch{BranchID=2,BranchName="Bob Sherlok",BranchLocation="2 Roxat"},
            new Branch{BranchID=3,BranchName="Sam Smith",BranchLocation="744 Qoylik"},
            new Branch{BranchID=4,BranchName="Ali AoA",BranchLocation="11 Qoratosh"},
            new Branch{BranchID=5,BranchName="Roxat Tota",BranchLocation="2 Roxat"},
            new Branch{BranchID=6,BranchName="Akil Mumin",BranchLocation="11 Qoratosh"},
            new Branch{BranchID=7,BranchName="Sito Kim",BranchLocation="744 Qoylik"},
            new Branch{BranchID=8,BranchName="Naruto Uzumaki",BranchLocation="11 Qoratosh"},
            new Branch{BranchID=9,BranchName="Saske Ushiha",BranchLocation="2 Roxat"},
            new Branch{BranchID=10,BranchName="Eren Eger",BranchLocation="744 Qoylik"},
            new Branch{BranchID=11,BranchName="Spider Man",BranchLocation="11 Qoratosh"},
            new Branch{BranchID=12,BranchName="Hulk Noname",BranchLocation="2 Roxat"},
            new Branch{BranchID=13,BranchName="Insta Chika",BranchLocation="11 Qoratosh"},
            new Branch{BranchID=14,BranchName="Zaebiska Tuta",BranchLocation="744 Qoylik"}
            };
            foreach (Branch c in branches)
            {
                context.Branches.Add(c);
            }
            context.SaveChanges();


            //adding new db
            var products = new Product[]
            {
            new Product{DeliveryID=1,BranchID=1,Review=Review.FiveStars},
            new Product{DeliveryID=1,BranchID=2,Review=Review.ThreeStars},
            new Product{DeliveryID=1,BranchID=3,Review=Review.FourStars},
            new Product{DeliveryID=2,BranchID=4,Review=Review.FourStars},
            new Product{DeliveryID=2,BranchID=5,Review=Review.TwoStars},
            new Product{DeliveryID=2,BranchID=6,Review=Review.OneStar},
            new Product{DeliveryID=3,BranchID=7},
            new Product{DeliveryID=3,BranchID=8},
            new Product{DeliveryID=3,BranchID=9,Review=Review.TwoStars},
            new Product{DeliveryID=3,BranchID=10,Review=Review.ThreeStars},
            new Product{DeliveryID=4,BranchID=11},
            new Product{DeliveryID=4,BranchID=12,Review=Review.FiveStars},
            new Product{DeliveryID=4,BranchID=4,Review=Review.FourStars},
            new Product{DeliveryID=5,BranchID=5,Review=Review.TwoStars},
            new Product{DeliveryID=6,BranchID=6,Review=Review.OneStar},
            new Product{DeliveryID=6,BranchID=7},
            new Product{DeliveryID=6,BranchID=8},
            new Product{DeliveryID=7,BranchID=9,Review=Review.TwoStars},
            new Product{DeliveryID=7,BranchID=10,Review=Review.ThreeStars},
            new Product{DeliveryID=8,BranchID=11},
            new Product{DeliveryID=8,BranchID=12,Review=Review.FiveStars},
            new Product{DeliveryID=9,BranchID=5,Review=Review.TwoStars},
            new Product{DeliveryID=9,BranchID=6,Review=Review.OneStar},
            new Product{DeliveryID=9,BranchID=7},
            new Product{DeliveryID=9,BranchID=8},
            new Product{DeliveryID=10,BranchID=9,Review=Review.TwoStars},
            new Product{DeliveryID=10,BranchID=10,Review=Review.ThreeStars},
            new Product{DeliveryID=11,BranchID=11},
            new Product{DeliveryID=12,BranchID=12,Review=Review.FiveStars},
            };
            foreach (Product e in products)
            {
                context.Products.Add(e);
            }
            context.SaveChanges();
        }
    }
}
