using NhibernateDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateDemo.Domain
{
    public class Student
    {
        public virtual int ID { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual StudentAcademicStanding AcademicStanding { get; set; }
        public virtual Location Address { get; set; }
    }

    public enum StudentAcademicStanding
    {        
        Excellent,
        Good,
        Fair,
        Poor,
        Terrible
    }
}
