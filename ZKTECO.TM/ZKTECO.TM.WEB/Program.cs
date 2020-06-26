using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using NHibernate;
using System;
using System.Reflection;
using ZKTECO.TM.Database.NHibernate;
using ZKTECO.TM.Entities.Entities;

namespace ZKTECO.TM.WEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            try
            {
                SessionUtilities.SessionFactoryHost = CreateSessionFactory();
                var host = BuildWebHost(args);
                host.Run();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        private static ISessionFactory CreateSessionFactory()
        {
            // configure jwt authentication
            return Fluently.Configure()
                    .Database(MySQLConfiguration.Standard
                    .ConnectionString("Server=localhost;Port=3306;Database=test;Uid=test;Pwd=test; "))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<User>())                    
                    .BuildSessionFactory();
        }
    }
}
