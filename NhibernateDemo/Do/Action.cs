using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhibernateDemo.Work;
using NhibernateDemo.Domain;

namespace NhibernateDemo.Do
{
    public static class Action
    {
        //Class Action - no used
        public static void Add<Student>(Student entity)
        {
            CRUD.AddItem(entity);            
        }    
    }
}
