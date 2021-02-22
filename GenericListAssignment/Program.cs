﻿using System;
using System.Collections.Generic;
            //using Dictionary 
namespace GenericListAssignment {
    class Program {
        static void Main(string[] args) {
            var friends = new Dictionary<long, Friend>();

            var ray = new Friend { Name = "Ray", Email = "Ray@gmail.com", BFF = true, Phone = 123 };
            friends.Add(ray.Phone, ray);
            var randy = new Friend { Name = "Randy", Email = "Randy@gmail.com", BFF = true, Phone = 456 };
            var susie = new Friend { Name = "Susie", Email = "Susie@gmail.com", BFF = true, Phone = 789 };
            friends.Add(randy.Phone, randy);
            friends.Add(susie.Phone, susie);

            foreach (var phone in friends.Keys) {
                var friend = friends[phone];
                Console.WriteLine($"{friend.Phone} : {friend.Name}");
            }
        }
    }
}





//using genericList
//namespace GenericListAssignment {
//    class Program {
//        static void Main(string[] args) {
//            var freinds = new List<Freinds>(3);

//            var ray = new Freinds { Name = "Ray", Email = "Ray@gmail.com", BFF = true };
//            freinds.Add(ray);
//            var randy = new Freinds { Name = "Randy", Email = "Randy@gmail.com", BFF = true };
//            var susie = new Freinds { Name = "Susie", Email = "Susie@gmail.com", BFF = true };
//            freinds.Add(randy);
//            freinds.Add(susie);

//            foreach(var freind in freinds) {
//                Console.WriteLine($"{freind.Name}");
//            }
//        }
//    }
//}
