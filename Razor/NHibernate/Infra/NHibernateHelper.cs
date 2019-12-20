﻿using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Infra
{
    public class NHibernateHelper
    {
        private static ISessionFactory factory = CreateSessionFactory();

        public static ISessionFactory CreateSessionFactory()
        {
            Configuration cfg = RecuperaConfiguracao();
            return cfg.BuildSessionFactory();
        }
        public static Configuration RecuperaConfiguracao()
        {

            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            return cfg;

        }

        public static void GeraSchema()
        {
            Configuration cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }


        public static ISession OpenSession()
        {
            return factory.OpenSession();
        }
    }
}
