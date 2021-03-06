﻿using NHibernate;
using NHibernate.Cache;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Data;
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
                x.LogSqlInConsole = true;
                x.BatchSize = 10;
                x.Timeout = 10;                
                x.IsolationLevel = IsolationLevel.RepeatableRead;
            });
            Configuration.Cache(c =>
            {
                c.UseMinimalPuts = true;
                c.UseQueryCache = true;
            });
            Configuration.SessionFactory().Caching.Through<HashtableCacheProvider>()
                .WithDefaultExpiration(1440);
            Configuration.AddAssembly(Assembly.GetExecutingAssembly());
            Sefact = Configuration.BuildSessionFactory();
        }

        public ConnectDataBase(bool check)
        {
            string FileConfig = System.Configuration.ConfigurationManager.ConnectionStrings["PathFileConfigHibernate"].ToString();
            Configuration = new Configuration();
            Configuration.Configure(FileConfig);
            Configuration.SessionFactory().GenerateStatistics();
            Sefact = Configuration.BuildSessionFactory();
        }
    }
}
