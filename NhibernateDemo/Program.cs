using NhibernateDemo.Domain;
using NhibernateDemo.Work;
using NhibernateDemo.Data;
using HibernatingRhinos.Profiler.Appender.NHibernate;
using System.Collections.Generic;
using System;

namespace NhibernateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NHibernateProfiler.Initialize();

            //var entity = ItemData.Item(StudentAcademicStanding.Excellent);
            //var entity1 = ItemData.Item(StudentAcademicStanding.Good);
            //List<Student> ListStudent = new List<Student>();

            ////CRUD.ReadList();
            //CRUD.ReadData(3);
            try
            {
                Guid id = CRUD.AddItem(ItemData.CreateCustomer());
                CRUD.ReadCustomer(id);
            }
            catch (TypeInitializationException ex)
            {
                ex.Message.ToString();
            }
           
        }
    }
}

