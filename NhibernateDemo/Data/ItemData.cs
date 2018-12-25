using NhibernateDemo.Domain;
using NhibernateDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateDemo.Data
{
    public static class ItemData
    {
        private static Random random = new Random();
        public static Student Item(StudentAcademicStanding optional)
        {
            var student = new Student
            {
                LastName = RandomString(3),
                FirstName = RandomString(4),
                AcademicStanding = optional
            };
            return student;
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat<string>(chars, length).Select<string, char>(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void AddListItem(int length, StudentAcademicStanding optional)
        {
            for (int i = 0; i < length; i++)
            {
                var student = new Student
                {
                    LastName = RandomString(3),
                    FirstName = RandomString(7),
                    AcademicStanding = optional
                };
            }
        }

        public static Student AddItem(StudentAcademicStanding optional)
        {
            var student = new Student
            {
                FirstName = RandomString(4),
                LastName = RandomString(5),
                AcademicStanding = optional,

                Address = new Location
                {
                    Street = "123 Street",
                    City = "Lahore",
                    Province = "Punjab",
                    Country = "Pakistan"
                }
            };

            return student;
        }

        public static Customer CreateCustomer()
        {
            var customer = new Customer
            {
                FirstName = ItemData.RandomString(4),
                LastName = ItemData.RandomString(8),
                Points = 100,
                HasGoldStatus = true,
                MemberSince = new DateTime(2012, 1, 1),
                CreditRating = CustomerCreditRating.Good,
                AverageRating = 42.242424,
                Address = CreateLocation()
            };
            var orderOne = new Order
            {
                Ordered = DateTime.Now
            };

            customer.AddOrder(orderOne);

            var orderTwo = new Order
            {
                Ordered = DateTime.Now.AddDays(-1),
                Shipped = DateTime.Now,
                ShipTo = CreateLocation()
            };
            customer.AddOrder(orderTwo);
            return customer;
        }

        private static Location CreateLocation()
        {
            return new Location
            {
                Street = "615 Le Trong Tan",
                City = "TP. HCM",
                Province = "Center",
                Country = "VN"
            };
        }
    }
}
