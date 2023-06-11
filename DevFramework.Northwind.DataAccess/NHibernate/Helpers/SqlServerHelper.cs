﻿using System.Reflection;
using DevFramework.Core.DataAccess.NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace DevFramework.Northwind.DataAccess.NHibernate.Helpers;

public class SqlServerHelper : NHibernateHelper
{
    protected override ISessionFactory InitializeFactory()
    {
        return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(c => c.FromConnectionStringWithKey("NorthwindContext")))
            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .BuildSessionFactory();
    }
}


