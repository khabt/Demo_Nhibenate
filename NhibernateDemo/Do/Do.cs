using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhibernateDemo.Work;
namespace NhibernateDemo.Do
{
    public static class Do
    {

        public static void Create<Student>(Student entity)
        {
            CRUD.CreateTable<Student>(entity);
        }    
    }
}
