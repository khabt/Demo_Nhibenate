﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateDemo.Domain
{
    public class Customer
    {
        public virtual Guid Id { get; set; }      
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual double AverageRating { get; set; }
        public virtual int Points { get; set; }

        public virtual bool HasGoldStatus { get; set; }
        public virtual DateTime MemberSince { get; set; }
        public virtual CustomerCreditRating CreditRating { get; set; }
    }

    public enum CustomerCreditRating
    {
        Excellent,
        VeryVeryGood,
        VeryGood,
        Good,
        Neutral,
        Poor,
        Terrible
    }
}
