using NhibernateDemo.Domain;
using System;
using NhibernateDemo.Database;

namespace NhibernateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var cfg = new Configuration();
            

            cfg.DataBaseIntegration(x => { x.ConnectionString = "Data Source=DESKTOP-T2ADMJE\\SQLEXPRESS;Initial Catalog=NHibernateDemo;Persist Security Info=True;User ID=sa;Password=12345678";
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2008Dialect>();
            });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            var sefact = cfg.BuildSessionFactory();

            using (var session = sefact.OpenSession()){
                using (var tx = session.BeginTransaction()){
                    //tx.Commit();

                    var student1 = new Student
                    {
                        ID = 1,
                        LastName = "Bommer",
                        FirstMidName = "Allan"
                    };

                    var student2 = new Student
                    {
                        ID = 2,
                        LastName = "Lewis",
                        FirstMidName = "Jerry"
                    };
                    session.Save(student1);
                    session.Save(student2);
                    tx.Commit();

                }
                Console.ReadLine();
            }*/
            ConnectDataBase db = new ConnectDataBase();
            CreateTable<Student>(Create(), db);

        }

        public static void CreateTable<T>(T entity, ConnectDataBase db)
        {
            using (var session = db.Sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(entity);
                    tx.Commit();
                }
            }
            Console.ReadLine();
        }

        public static Student Create()
        {
            var student = new Student
            {
                ID = 3,
                LastName = "KHA",
                FirstMidName = "BT"
            };

            return student;
        }
    }
}
