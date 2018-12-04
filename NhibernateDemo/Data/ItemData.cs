using NhibernateDemo.Domain;
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
    }
}
