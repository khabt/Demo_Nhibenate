using NHibernate;
using NhibernateDemo.Database;
using NhibernateDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateDemo.Work
{
    public static class CRUD
    {
        //public static ConnectDataBase db = new ConnectDataBase();        
        public static ConnectDataBase db = new ConnectDataBase(true);
        public static void AddItem<T>(T entity)
        {
            using (var session = db.Sefact.OpenSession())
            {
                using(var tx = session.BeginTransaction())
                {
                    session.Save(entity);
                    tx.Commit();
                }
            }
        }

        public static void ReadData(int ID)
        {
            using (var session = db.Sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var stdntOne = session.Get<Student>(ID);
                    var stdntTwo = session.Get<Student>(ID);
                    if (stdntOne != null)
                    {
                        Console.WriteLine("Retrieved  by ID");
                        Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4} \t{5} \t{6} \t{7}", 
                            stdntOne.ID, stdntOne.FirstName, stdntOne.LastName,
                            stdntOne.Address.Street, stdntOne.Address.City, stdntOne.Address.Province, stdntOne.Address.Country
                            );
                    }
                    if (stdntTwo != null)
                    {
                        Console.WriteLine("Retrieved  by ID");
                        Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4} \t{5} \t{6} \t{7}", 
                            stdntTwo.ID, stdntTwo.FirstName, stdntTwo.LastName,
                            stdntTwo.Address.Street, stdntTwo.Address.City, stdntTwo.Address.Province, stdntTwo.Address.Country
                            );
                    }
                    tx.Commit();
                }                
            }
        }        

        public static void ReadList()
        {
            using(var session = db.Sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var students = session.CreateCriteria<Student>().List<Student>();

                    foreach (var student in students)
                    {
                        Console.WriteLine("{0} \t{1} \t{2} \t{3}", student.ID, student.FirstName, student.LastName, student.AcademicStanding);
                    }
                }                
            }
        }

        public static void UpdateItem(int ID, string LasName, string FirstMidName)
        {
            using (var session = db.Sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var stdnt = session.Get<Student>(ID);
                    Console.WriteLine("Retrieved by ID");
                    
                    if(stdnt !=null)
                    {
                        Console.WriteLine("{0} \t{1} \t{2}", stdnt.ID, stdnt.FirstName, stdnt.LastName);

                        Console.WriteLine("Update the last name os ID = {0}", stdnt.ID);
                        stdnt.LastName = LasName;
                        stdnt.FirstName = FirstMidName;
                        session.Update(stdnt);
                    }
                    tx.Commit();
                }                
            }
        }

        public static void DeleteItem(int ID)
        {
            using (var session = db.Sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var stdnt = session.Get<Student>(ID);
                    Console.WriteLine("Retrieved by ID");

                    if (stdnt != null)
                    {
                        Console.WriteLine("{0} \t{1} \t{2}", stdnt.ID, stdnt.FirstName, stdnt.LastName);
                        Console.WriteLine("Delete the record which has ID = {0}", stdnt.ID);
                        session.Delete(stdnt);
                    }                       
                    tx.Commit();
                }
            }
        }
        public static void DeleteItemList(int[] IDs)
        {
            using (var session = db.Sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    List<Student> listStudent = new List<Student>();
                    Console.WriteLine("Retrieved by ID");
                    string textIDs = "";
                    foreach (int ID in IDs)
                    {
                        var stdnt = session.Get<Student>(ID);
                        if(stdnt != null)
                        {
                            listStudent.Add(stdnt);
                            textIDs = textIDs + stdnt.ID + ",";
                            Console.WriteLine("{0} \t{1} \t{2}", stdnt.ID, stdnt.FirstName, stdnt.LastName);
                            session.Delete(stdnt);
                        }                        
                    }
                    Console.WriteLine("Delete the record which has ID = {0}", textIDs.Trim());                                       
                    tx.Commit();
                }
            }
        }
    }
}
