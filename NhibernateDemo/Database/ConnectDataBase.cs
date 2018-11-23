using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateDemo.Database
{
    public class ConnectDataBase
    {
        public Configuration Configuration;
        public ISessionFactory Sefact;

        public ConnectDataBase()
        {
            Configuration = new Configuration();
            Configuration.DataBaseIntegration(x => {
                x.ConnectionString = "Data Source=DESKTOP-T2ADMJE\\SQLEXPRESS;Initial Catalog=NHibernateDemo;Persist Security Info=True;User ID=sa;Password=12345678";
                x.Driver<SqlClientDriver>();
                x.Dialect<MsSql2008Dialect>();
            });
            Configuration.AddAssembly(Assembly.GetExecutingAssembly());

            Sefact = Configuration.BuildSessionFactory();
        }
    }
}
