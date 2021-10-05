using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>() {
                new Customer { Id = 1, Name = "Amazon" },
                new Customer { Id = 2, Name = "Target" },
                new Customer { Id = 3, Name = "Microsoft" }
            };
            var orders = new List<Order>() {
                new Order { Id = 1, Description = "1st Order", Sales = 1000, CustomerId = 1 },
                new Order { Id = 2, Description = "2nd Order", Sales = 2000, CustomerId = 3 },
                new Order { Id = 3, Description = "3rd Order", Sales = 3000, CustomerId = 2 }
            };
            var lolz = from c in customers
                       join o in orders
                       on c.Id equals o.CustomerId
                       select new { o, c };
            foreach( var lol in lolz)
            {
                Console.WriteLine($"{lol.c.Name} | {lol.o.Description} | {lol.o.Sales}");
            }
        }
        static void X()
        { 
            var ints = new int[] 
            {
                620, 849, 649, 989, 993, 524, 216, 173, 136, 482,
                842, 308, 251, 572, 150, 797, 611, 489, 934, 310,
                985, 764, 484, 816, 753, 925, 289, 231, 486, 761,
                621, 981, 103, 482, 917, 124, 276, 839, 476 ,789,
                582, 631, 841, 398, 521, 796, 199, 941, 782, 953,
                412, 362, 424, 336, 812, 344, 579, 570, 212, 483,
                250, 829, 835, 429, 833, 992, 657, 461, 782, 498,
                829, 648, 189, 579, 645, 584, 989, 254, 859, 321,
                991, 421, 151, 350, 687, 491, 568, 548, 403, 836,
                303, 104, 538, 426, 150, 843, 943, 864, 694, 639
            };
            //var trimsum = ints.Sum() - ints.Min() - ints.Max();
            //var averagetrim = trimsum / (ints.Count() - 2.0);
            //Console.WriteLine(averagetrim);

            //var result = from I in ints
            //             where I % 2 == 0
            //             orderby ints descending
            //             select I;
            //foreach(int r in result)
            //{

            //Console.Write($"{r}, ");
            //}

            var avg = ints.Average();
            var res1 = from I in ints
                       where I < avg
                       orderby I descending
                       select I;
            foreach(int r in res1)
            {
                Console.Write($"{r}, ");
            }

            var res2 = ints.Where(i => i < ints.Average()).OrderByDescending(i => i);
            foreach (int r in res2)
            {
                Console.Write($"{r}, ");
            }
        }
    }
}
