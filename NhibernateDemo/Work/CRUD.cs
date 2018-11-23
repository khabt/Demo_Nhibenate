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
        public static ConnectDataBase db = new ConnectDataBase();
        public static void CreateTable<T>(T entity)
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
    }
}
